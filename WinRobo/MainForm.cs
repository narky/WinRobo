using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WinRobo
{
    public partial class MainForm : Form
    {
        private string cmdfile = "robocopy.exe";
        private string configDB = Application.StartupPath + @"\config.dll";
        private string startTxt = @"
    文件备份工具 Narky 2008-06-10
    ==============================
    = 本工具基于robocopy.exe程序
    = 当前默认目标目录为：
    = " + Application.StartupPath + @"\backup
    ==============================

    更新：2010-06-22
    1.新增：可保存使用过的路径信息
    2.新增：自定义文件名过滤项
    3.新增：可设置下拉显示使用过的路径的条数";
        private string statusTxt = @"Robocopy GUI by Narky 2008-06-10 Last Modified:2010-06-22";
        private int pValue = 1;
        private DataClass pathDB;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.btn_run.Enabled = false;
            this.Text = "文件提取工具 WinRobo [Narky 2008-06-10]";
            this.rtb_output.Text = startTxt;
            this.toolStripStatusLabel1.Text = statusTxt;

            //检测需要的程序  robocopy.exe
            if (!File.Exists(Application.StartupPath + @"\" + cmdfile))
            {
                MessageBox.Show("需要 " + cmdfile,"需要必须的运行程序",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Form_Close();
            }
            //检测配置文件
            if (!File.Exists(configDB))
            {
                MessageBox.Show("配置数据文件不存在。", "严重错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form_Close();
            }
            Init_PathField();
            this.cbbox_Source.Text = "";
            this.cbbox_Dest.Text = "";
            this.cbbox_FilterFiles.Text = "";
        }

        private void Form_Close()
        {
            Environment.Exit(Environment.ExitCode);
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// 初始化填充路径下拉列表 narky 20100622
        /// </summary>
        private void Init_PathField()
        {
            try
            {
                pathDB = new DataClass(configDB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "严重错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
            }
            DataTable dt = new DataTable();
            //来源地址
            dt = pathDB.PathData();
            this.cbbox_Source.DataSource = dt;
            this.cbbox_Source.DisplayMember = "pathString";
            
            //目标地址
            dt = pathDB.PathData(2);
            this.cbbox_Dest.DataSource = dt;
            this.cbbox_Dest.DisplayMember = "pathString";

            //文件名过滤器
            dt = pathDB.FilterList();
            this.cbbox_FilterFiles.DataSource = dt;
            this.cbbox_FilterFiles.DisplayMember = "filter";

            pathDB.Close();
        }

        private void ProcessStatus(int flag)
        {
            switch (flag) {
                case 1:
                    this.panel2.Location = new Point(0, 0);
                    this.panel2.Size = this.panel1.Size;
                    this.label5.Text = "正在提取文件，请稍等...";
                    this.panel2.Visible = true;
                    break;
                case 2:
                    if (this.bgWorker.IsBusy) this.bgWorker.CancelAsync();
                    this.panel2.Visible = false;
                    break;
                default:
                    return;
            }
        }

        private void ShowProcessStatus()
        {
            ProcessStatus(1);
        }

        private void HideProcessStatus()
        {
            ProcessStatus(2);
        }

        // 因为使用了BackgroundWorker，所以不能跨线程设置rtb_output的值
        // 需要走代理Invoke的方式
        delegate void SetOutputCallback(string output);
        private void SetOutput(string text)
        {
            if (this.rtb_output.InvokeRequired)
            {
                SetOutputCallback d = new SetOutputCallback(SetOutput);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rtb_output.Text = text;
            }
        }

        private bool MainProcess(string[] param)
        {
            bool rValue = false;
            try
            {
                string source = param[0];
                string dest = param[1];
                string filter = param[2];
                string modifydate = param[3];
                string arguments = "\"" + source + "\" \"" + dest + "\" " + filter + " /S /MAXAGE:" + modifydate;
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = cmdfile;
                ps.UseShellExecute = false;
                ps.RedirectStandardOutput = true;
                ps.CreateNoWindow = true;
                ps.Arguments = arguments;
                Process p = Process.Start(ps);
                //p.WaitForExit();
                string output = p.StandardOutput.ReadToEnd();
                SetOutput("");
                SetOutput(output);
                p.Close();

                //将使用过的路径信息存到配置数据库 narky 20100622
                pathDB = new DataClass(configDB);
                pathDB.SavePath(Base64.EncodeBase64(source));
                pathDB.SavePath(Base64.EncodeBase64(dest), 2);
                pathDB.Close();

                MessageBox.Show("文件全部提取成功。所有文件已经提取到 "+dest+" 下。", "文件提取成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rValue = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //HideProcessStatus();
            }
            return rValue;
        }

        #region 功能按钮操作
        private void btn_vfolder1_Click(object sender, EventArgs e)
        {

            fbd_Folder.ShowNewFolderButton = false;
            fbd_Folder.Description = "选择需要提取文件文件夹：";
            fbd_Folder.SelectedPath = cbbox_Source.Text;
            if (fbd_Folder.ShowDialog() == DialogResult.OK)
            {
                cbbox_Source.Text = fbd_Folder.SelectedPath;
                this.btn_run.Enabled = true;
            }
            
        }

        private void btn_vfolder2_Click(object sender, EventArgs e)
        {
            //fbd_Folder.ShowNewFolderButton = false;
            fbd_Folder.Description = "选择保存提取文件的目标文件夹，或新建一个文件夹：";
            fbd_Folder.SelectedPath = cbbox_Dest.Text;
            if (fbd_Folder.ShowDialog() == DialogResult.OK) cbbox_Dest.Text = fbd_Folder.SelectedPath;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            string source = cbbox_Source.Text.Trim();
            string dest = cbbox_Dest.Text.Trim();
            string modifydate = dtp_date.Value.ToString("yyyyMMdd");
            string filter = tb_Filter.Text.Trim();

            if (source.Length < 3)
            {
                MessageBox.Show("请选择来源文件夹", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HideProcessStatus();
                return;
            }
            else
            {
                if (!Directory.Exists(source))
                {
                    MessageBox.Show("请选择正确的来源文件夹", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HideProcessStatus();
                    return;
                }
            }
            if (dest.Length < 3)
            {
                MessageBox.Show("未选择目标文件夹，将默认备份到 " + Application.StartupPath + @"\backup", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dest = Application.StartupPath.ToString() + @"\backup";
            }

            //构建参数字符串
            //string arguments = "\"" + source + "\" \"" + dest + "\" " + filter + " /S /MAXAGE:" + modifydate;
            string[] args = { source, dest, filter, modifydate };
            this.bgWorker.RunWorkerAsync(args);
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.UseShellExecute = false;
            ps.RedirectStandardOutput = true;
            ps.CreateNoWindow = true;
            ps.FileName = cmdfile;
            ps.Arguments = "/?";
            Process p = Process.Start(ps);
            string output = p.StandardOutput.ReadToEnd();
            this.rtb_output.Text = "";
            this.rtb_output.Text = output;
            p.Close();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            this.rtb_output.Text = "";
            this.rtb_output.Text = startTxt;
        }

        private void btn_Terminal_Click(object sender, EventArgs e)
        {
            //打开一个终端供自定义操作
            Process p = Process.Start("cmd.exe", "/K \"Title Robocopy GUI by Narky && robocopy.exe\"");
            p.Close();
        }

        private void cbbox_Source_TextChanged(object sender, EventArgs e)
        {
            if (cbbox_Source.Text.Length < 3)
            {
                this.btn_run.Enabled = false;
            }
            else
            {
                this.btn_run.Enabled = true;
            }
        }

        private void btn_SetFilter_Click(object sender, EventArgs e)
        {
            if (this.cbbox_FilterFiles.Text != "")
            {
                if (this.tb_Filter.Text == "*.*")
                {
                    this.tb_Filter.Text = this.cbbox_FilterFiles.Text;
                }
                else
                {
                    this.tb_Filter.Text += " " + this.cbbox_FilterFiles.Text;
                }
                if (this.cbbox_FilterFiles.Text == "*.*") this.tb_Filter.Text = this.cbbox_FilterFiles.Text;
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //BackgroundWorker bgwValue = (BackgroundWorker)sender;
            this.bgWorker.ReportProgress(pValue);
            MainProcess((string[])e.Argument) ;
            //if (MainProcess() == true) this.bgWorker.ReportProgress(100); 
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ShowProcessStatus();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideProcessStatus();
        }

        private void btn_Conf_Click(object sender, EventArgs e)
        {
            Form setForm = new SettingsForm();
            setForm.Text = "设置";
            setForm.ShowDialog();
        }

        #endregion
    }
}