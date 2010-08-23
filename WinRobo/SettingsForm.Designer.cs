namespace WinRobo
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pathnum = new System.Windows.Forms.TextBox();
            this.btn_clearSource = new System.Windows.Forms.Button();
            this.btn_clearDest = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_Filter = new System.Windows.Forms.ListBox();
            this.tb_newFilter = new System.Windows.Forms.TextBox();
            this.btn_addFilter = new System.Windows.Forms.Button();
            this.btn_delFilter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clearDest);
            this.groupBox1.Controls.Add(this.btn_clearSource);
            this.groupBox1.Controls.Add(this.tb_pathnum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路径设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "显示最近路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "条。";
            // 
            // tb_pathnum
            // 
            this.tb_pathnum.Location = new System.Drawing.Point(89, 13);
            this.tb_pathnum.Name = "tb_pathnum";
            this.tb_pathnum.Size = new System.Drawing.Size(36, 21);
            this.tb_pathnum.TabIndex = 2;
            this.tb_pathnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_clearSource
            // 
            this.btn_clearSource.Location = new System.Drawing.Point(6, 40);
            this.btn_clearSource.Name = "btn_clearSource";
            this.btn_clearSource.Size = new System.Drawing.Size(115, 24);
            this.btn_clearSource.TabIndex = 3;
            this.btn_clearSource.Text = "清除来源路径";
            this.btn_clearSource.UseVisualStyleBackColor = true;
            this.btn_clearSource.Click += new System.EventHandler(this.btn_clearSource_Click);
            // 
            // btn_clearDest
            // 
            this.btn_clearDest.Location = new System.Drawing.Point(133, 40);
            this.btn_clearDest.Name = "btn_clearDest";
            this.btn_clearDest.Size = new System.Drawing.Size(115, 24);
            this.btn_clearDest.TabIndex = 4;
            this.btn_clearDest.Text = "清除目标路径";
            this.btn_clearDest.UseVisualStyleBackColor = true;
            this.btn_clearDest.Click += new System.EventHandler(this.btn_clearDest_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 247);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(60, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(77, 247);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delFilter);
            this.groupBox2.Controls.Add(this.btn_addFilter);
            this.groupBox2.Controls.Add(this.tb_newFilter);
            this.groupBox2.Controls.Add(this.list_Filter);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件过滤设置";
            // 
            // list_Filter
            // 
            this.list_Filter.FormattingEnabled = true;
            this.list_Filter.ItemHeight = 12;
            this.list_Filter.Location = new System.Drawing.Point(6, 20);
            this.list_Filter.Name = "list_Filter";
            this.list_Filter.Size = new System.Drawing.Size(115, 124);
            this.list_Filter.TabIndex = 0;
            this.list_Filter.DoubleClick += new System.EventHandler(this.list_Filter_DoubleClick);
            // 
            // tb_newFilter
            // 
            this.tb_newFilter.Location = new System.Drawing.Point(156, 20);
            this.tb_newFilter.Name = "tb_newFilter";
            this.tb_newFilter.Size = new System.Drawing.Size(92, 21);
            this.tb_newFilter.TabIndex = 1;
            // 
            // btn_addFilter
            // 
            this.btn_addFilter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addFilter.Location = new System.Drawing.Point(127, 20);
            this.btn_addFilter.Name = "btn_addFilter";
            this.btn_addFilter.Size = new System.Drawing.Size(23, 23);
            this.btn_addFilter.TabIndex = 2;
            this.btn_addFilter.Text = "<";
            this.btn_addFilter.UseVisualStyleBackColor = true;
            this.btn_addFilter.Click += new System.EventHandler(this.btn_addFilter_Click);
            // 
            // btn_delFilter
            // 
            this.btn_delFilter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delFilter.Location = new System.Drawing.Point(127, 49);
            this.btn_delFilter.Name = "btn_delFilter";
            this.btn_delFilter.Size = new System.Drawing.Size(23, 23);
            this.btn_delFilter.TabIndex = 3;
            this.btn_delFilter.Text = ">";
            this.btn_delFilter.UseVisualStyleBackColor = true;
            this.btn_delFilter.Click += new System.EventHandler(this.btn_delFilter_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 282);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pathnum;
        private System.Windows.Forms.Button btn_clearSource;
        private System.Windows.Forms.Button btn_clearDest;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_Filter;
        private System.Windows.Forms.Button btn_delFilter;
        private System.Windows.Forms.Button btn_addFilter;
        private System.Windows.Forms.TextBox tb_newFilter;
    }
}