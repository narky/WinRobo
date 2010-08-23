namespace WinRobo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_vfolder1 = new System.Windows.Forms.Button();
            this.fbd_Folder = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_vfolder2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_run = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Conf = new System.Windows.Forms.Button();
            this.btn_SetFilter = new System.Windows.Forms.Button();
            this.cbbox_FilterFiles = new System.Windows.Forms.ComboBox();
            this.btn_Info = new System.Windows.Forms.Button();
            this.cbbox_Dest = new System.Windows.Forms.ComboBox();
            this.cbbox_Source = new System.Windows.Forms.ComboBox();
            this.btn_Terminal = new System.Windows.Forms.Button();
            this.tb_Filter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "源目录";
            // 
            // btn_vfolder1
            // 
            this.btn_vfolder1.Location = new System.Drawing.Point(460, 6);
            this.btn_vfolder1.Name = "btn_vfolder1";
            this.btn_vfolder1.Size = new System.Drawing.Size(33, 23);
            this.btn_vfolder1.TabIndex = 2;
            this.btn_vfolder1.Text = "...";
            this.ttip.SetToolTip(this.btn_vfolder1, "选择源文件夹");
            this.btn_vfolder1.UseVisualStyleBackColor = true;
            this.btn_vfolder1.Click += new System.EventHandler(this.btn_vfolder1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "目标目录";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btn_vfolder2
            // 
            this.btn_vfolder2.Location = new System.Drawing.Point(460, 31);
            this.btn_vfolder2.Name = "btn_vfolder2";
            this.btn_vfolder2.Size = new System.Drawing.Size(33, 23);
            this.btn_vfolder2.TabIndex = 5;
            this.btn_vfolder2.Text = "...";
            this.ttip.SetToolTip(this.btn_vfolder2, "选择目标文件夹");
            this.btn_vfolder2.UseVisualStyleBackColor = true;
            this.btn_vfolder2.Click += new System.EventHandler(this.btn_vfolder2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "大于日期";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(74, 87);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(131, 21);
            this.dtp_date.TabIndex = 7;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(211, 86);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(168, 23);
            this.btn_run.TabIndex = 10;
            this.btn_run.Text = "开始提取文件";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Conf);
            this.panel1.Controls.Add(this.btn_SetFilter);
            this.panel1.Controls.Add(this.cbbox_FilterFiles);
            this.panel1.Controls.Add(this.btn_Info);
            this.panel1.Controls.Add(this.cbbox_Dest);
            this.panel1.Controls.Add(this.cbbox_Source);
            this.panel1.Controls.Add(this.btn_Terminal);
            this.panel1.Controls.Add(this.tb_Filter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Help);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_run);
            this.panel1.Controls.Add(this.btn_vfolder1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_vfolder2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 117);
            this.panel1.TabIndex = 11;
            // 
            // btn_Conf
            // 
            this.btn_Conf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Conf.BackgroundImage")));
            this.btn_Conf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Conf.Location = new System.Drawing.Point(460, 56);
            this.btn_Conf.Name = "btn_Conf";
            this.btn_Conf.Size = new System.Drawing.Size(33, 27);
            this.btn_Conf.TabIndex = 20;
            this.btn_Conf.UseVisualStyleBackColor = true;
            this.btn_Conf.Click += new System.EventHandler(this.btn_Conf_Click);
            // 
            // btn_SetFilter
            // 
            this.btn_SetFilter.Location = new System.Drawing.Point(358, 60);
            this.btn_SetFilter.Name = "btn_SetFilter";
            this.btn_SetFilter.Size = new System.Drawing.Size(21, 21);
            this.btn_SetFilter.TabIndex = 19;
            this.btn_SetFilter.Text = "<";
            this.btn_SetFilter.UseVisualStyleBackColor = true;
            this.btn_SetFilter.Click += new System.EventHandler(this.btn_SetFilter_Click);
            // 
            // cbbox_FilterFiles
            // 
            this.cbbox_FilterFiles.FormattingEnabled = true;
            this.cbbox_FilterFiles.Location = new System.Drawing.Point(385, 60);
            this.cbbox_FilterFiles.Name = "cbbox_FilterFiles";
            this.cbbox_FilterFiles.Size = new System.Drawing.Size(69, 20);
            this.cbbox_FilterFiles.TabIndex = 18;
            // 
            // btn_Info
            // 
            this.btn_Info.Location = new System.Drawing.Point(469, 86);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(24, 23);
            this.btn_Info.TabIndex = 17;
            this.btn_Info.Text = "！";
            this.ttip.SetToolTip(this.btn_Info, "获得本软件的信息");
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // cbbox_Dest
            // 
            this.cbbox_Dest.FormattingEnabled = true;
            this.cbbox_Dest.Location = new System.Drawing.Point(74, 34);
            this.cbbox_Dest.Name = "cbbox_Dest";
            this.cbbox_Dest.Size = new System.Drawing.Size(380, 20);
            this.cbbox_Dest.TabIndex = 16;
            // 
            // cbbox_Source
            // 
            this.cbbox_Source.FormattingEnabled = true;
            this.cbbox_Source.Location = new System.Drawing.Point(74, 8);
            this.cbbox_Source.Name = "cbbox_Source";
            this.cbbox_Source.Size = new System.Drawing.Size(380, 20);
            this.cbbox_Source.TabIndex = 15;
            this.cbbox_Source.TextChanged += new System.EventHandler(this.cbbox_Source_TextChanged);
            // 
            // btn_Terminal
            // 
            this.btn_Terminal.Location = new System.Drawing.Point(385, 86);
            this.btn_Terminal.Name = "btn_Terminal";
            this.btn_Terminal.Size = new System.Drawing.Size(48, 23);
            this.btn_Terminal.TabIndex = 14;
            this.btn_Terminal.Text = "终端";
            this.ttip.SetToolTip(this.btn_Terminal, "打开一个终端用于自定义操作，请先阅读帮助");
            this.btn_Terminal.UseVisualStyleBackColor = true;
            this.btn_Terminal.Click += new System.EventHandler(this.btn_Terminal_Click);
            // 
            // tb_Filter
            // 
            this.tb_Filter.Location = new System.Drawing.Point(74, 60);
            this.tb_Filter.Name = "tb_Filter";
            this.tb_Filter.Size = new System.Drawing.Size(278, 21);
            this.tb_Filter.TabIndex = 13;
            this.tb_Filter.Text = "*.*";
            this.ttip.SetToolTip(this.tb_Filter, "支持通配符查找扩展名，如*.* *.swf *.asp\r\n支持多个文件精确提取，文件名之间请用空格分隔\r\n例如：1.swf index.asp 1.jpg");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "文件名过滤";
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(439, 86);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(24, 23);
            this.btn_Help.TabIndex = 11;
            this.btn_Help.Text = "？";
            this.ttip.SetToolTip(this.btn_Help, "获取Robocopy的帮助");
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // rtb_output
            // 
            this.rtb_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_output.Location = new System.Drawing.Point(0, 116);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(496, 332);
            this.rtb_output.TabIndex = 10;
            this.rtb_output.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_vfolder1;
        private System.Windows.Forms.FolderBrowserDialog fbd_Folder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_vfolder2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip ttip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Filter;
        private System.Windows.Forms.Button btn_Terminal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbox_Dest;
        private System.Windows.Forms.ComboBox cbbox_Source;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.ComboBox cbbox_FilterFiles;
        private System.Windows.Forms.Button btn_SetFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Button btn_Conf;
    }
}

