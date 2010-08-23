using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinRobo
{
    public partial class SettingsForm : Form
    {
        private string configDB = Application.StartupPath + @"\config.dll";

        public SettingsForm()
        {
            InitializeComponent();
        }

        private DialogResult confirm(string str)
        {
            return MessageBox.Show(str,"警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
        }

        private void clearPath(int pathType)
        {
            string pathtxt="";
            switch(pathType)
            {
                case 1:
                    pathtxt="来源";
                    break;
                case 2:
                    pathtxt="目标";
                    break;
                default:
                    break;
            }
            if (DialogResult.OK == confirm("清除" + pathtxt + "目录列表？"))
            {
                DataClass dataclass = new DataClass(configDB);
                dataclass.clearPath(pathType);
                dataclass.Close();
                MessageBox.Show("路径已经清空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveConf()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("path_list_num", this.tb_pathnum.Text);
            //TODO:各种设置
            DataClass dataclass = new DataClass(configDB);
            dataclass.saveSetting(dict);
            dataclass.Close();
        }

        private bool setFilter(string filter, int flag)
        {
            DataClass dataclass = new DataClass(configDB);
            return dataclass.setFilter(filter, flag);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            DataClass dataclass=new DataClass(configDB);
            Dictionary<string, string> myDic = dataclass.SettingsDict();
            this.tb_pathnum.Text = myDic["path_list_num"];

            DataTable dt = dataclass.FilterList(0);
            foreach (DataRow dr in dt.Rows)
            {
                this.list_Filter.Items.Add(dr["filter"].ToString());
            }

            dataclass.Close();
        }

        private void btn_clearSource_Click(object sender, EventArgs e)
        {
            clearPath(1);
        }

        private void btn_clearDest_Click(object sender, EventArgs e)
        {
            clearPath(2);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveConf();
            string msg = "设置已经保存，立即重启程序应用最新的设置吗？\n\n否则，程序将在下次启动时应用设置。";
            if (DialogResult.OK == confirm(msg))
            {
                Application.Restart();
            }
            else
            {
                this.Close();
            }
        }

        private void btn_addFilter_Click(object sender, EventArgs e)
        {
            if (this.tb_newFilter.Text != "" && setFilter(this.tb_newFilter.Text,1)) {
                this.list_Filter.Items.Insert(0,this.tb_newFilter.Text);
            }
        }

        private void btn_delFilter_Click(object sender, EventArgs e)
        {
            int idx = this.list_Filter.SelectedIndex;
            if (idx>=0 && setFilter(this.list_Filter.SelectedItem.ToString(), 2)) {
                this.list_Filter.Items.RemoveAt(idx);
            }
        }

        private void list_Filter_DoubleClick(object sender, EventArgs e)
        {
            btn_delFilter_Click(sender,e);
        }

    }
}
