namespace 宿舍管理系统
{
    partial class 校外人员登记表
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(校外人员登记表));
            this.btnstudenthome = new System.Windows.Forms.Button();
            this.txtsex = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtshiyou = new System.Windows.Forms.TextBox();
            this.lblshiyou = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.txtbroomnumber = new System.Windows.Forms.TextBox();
            this.lblbroomnumber = new System.Windows.Forms.Label();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.lblbname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.btnnexit = new System.Windows.Forms.Button();
            this.btndengji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstudenthome
            // 
            this.btnstudenthome.Location = new System.Drawing.Point(529, 15);
            this.btnstudenthome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnstudenthome.Name = "btnstudenthome";
            this.btnstudenthome.Size = new System.Drawing.Size(100, 29);
            this.btnstudenthome.TabIndex = 49;
            this.btnstudenthome.Text = "查看是否存在";
            this.btnstudenthome.UseVisualStyleBackColor = true;
            this.btnstudenthome.Click += new System.EventHandler(this.btnstudenthome_Click);
            // 
            // txtsex
            // 
            this.txtsex.FormattingEnabled = true;
            this.txtsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.txtsex.Location = new System.Drawing.Point(149, 72);
            this.txtsex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(160, 23);
            this.txtsex.TabIndex = 48;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(447, 122);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(199, 25);
            this.dateTime.TabIndex = 45;
            // 
            // txtshiyou
            // 
            this.txtshiyou.Location = new System.Drawing.Point(119, 190);
            this.txtshiyou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtshiyou.Multiline = true;
            this.txtshiyou.Name = "txtshiyou";
            this.txtshiyou.Size = new System.Drawing.Size(615, 59);
            this.txtshiyou.TabIndex = 44;
            // 
            // lblshiyou
            // 
            this.lblshiyou.AutoSize = true;
            this.lblshiyou.Location = new System.Drawing.Point(40, 190);
            this.lblshiyou.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshiyou.Name = "lblshiyou";
            this.lblshiyou.Size = new System.Drawing.Size(67, 15);
            this.lblshiyou.TabIndex = 43;
            this.lblshiyou.Text = "来访事由";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(335, 134);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(67, 15);
            this.lbltime.TabIndex = 42;
            this.lbltime.Text = "来访时间";
            // 
            // txtbroomnumber
            // 
            this.txtbroomnumber.Location = new System.Drawing.Point(149, 130);
            this.txtbroomnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbroomnumber.Name = "txtbroomnumber";
            this.txtbroomnumber.Size = new System.Drawing.Size(145, 25);
            this.txtbroomnumber.TabIndex = 41;
            // 
            // lblbroomnumber
            // 
            this.lblbroomnumber.AutoSize = true;
            this.lblbroomnumber.Location = new System.Drawing.Point(3, 134);
            this.lblbroomnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbroomnumber.Name = "lblbroomnumber";
            this.lblbroomnumber.Size = new System.Drawing.Size(112, 15);
            this.lblbroomnumber.TabIndex = 40;
            this.lblbroomnumber.Text = "被访学生宿舍号";
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(304, 15);
            this.txtbname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(132, 25);
            this.txtbname.TabIndex = 39;
            // 
            // lblbname
            // 
            this.lblbname.AutoSize = true;
            this.lblbname.Location = new System.Drawing.Point(177, 21);
            this.lblbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbname.Name = "lblbname";
            this.lblbname.Size = new System.Drawing.Size(97, 15);
            this.lblbname.TabIndex = 38;
            this.lblbname.Text = "被访学生姓名";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(447, 69);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 25);
            this.txtname.TabIndex = 37;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(335, 72);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(67, 15);
            this.lblname.TabIndex = 36;
            this.lblname.Text = "您的姓名";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(83, 76);
            this.lblsex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(37, 15);
            this.lblsex.TabIndex = 35;
            this.lblsex.Text = "性别";
            this.lblsex.Click += new System.EventHandler(this.lblsex_Click);
            // 
            // btnnexit
            // 
            this.btnnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnnexit.Location = new System.Drawing.Point(337, 288);
            this.btnnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnexit.Name = "btnnexit";
            this.btnnexit.Size = new System.Drawing.Size(100, 29);
            this.btnnexit.TabIndex = 34;
            this.btnnexit.Text = "取消";
            this.btnnexit.UseVisualStyleBackColor = true;
            this.btnnexit.Click += new System.EventHandler(this.btnnexit_Click);
            // 
            // btndengji
            // 
            this.btndengji.Location = new System.Drawing.Point(175, 288);
            this.btndengji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndengji.Name = "btndengji";
            this.btndengji.Size = new System.Drawing.Size(100, 29);
            this.btndengji.TabIndex = 33;
            this.btndengji.Text = "登记";
            this.btndengji.UseVisualStyleBackColor = true;
            this.btndengji.Click += new System.EventHandler(this.btndengji_Click);
            // 
            // 校外人员登记表
            // 
            this.AcceptButton = this.btndengji;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnnexit;
            this.ClientSize = new System.Drawing.Size(775, 341);
            this.Controls.Add(this.btnstudenthome);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtshiyou);
            this.Controls.Add(this.lblshiyou);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.txtbroomnumber);
            this.Controls.Add(this.lblbroomnumber);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.lblbname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.btnnexit);
            this.Controls.Add(this.btndengji);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "校外人员登记表";
            this.Text = "校外人员登记表";
            this.Load += new System.EventHandler(this.校外人员登记表_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstudenthome;
        private System.Windows.Forms.ComboBox txtsex;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txtshiyou;
        private System.Windows.Forms.Label lblshiyou;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.TextBox txtbroomnumber;
        private System.Windows.Forms.Label lblbroomnumber;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.Label lblbname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Button btnnexit;
        private System.Windows.Forms.Button btndengji;

    }
}