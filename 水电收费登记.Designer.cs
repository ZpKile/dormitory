namespace 宿舍管理系统
{
    partial class 水电收费登记
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(水电收费登记));
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtshiyou = new System.Windows.Forms.TextBox();
            this.lblshiyou = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.txtbroomnumber = new System.Windows.Forms.TextBox();
            this.lblbroomnumber = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.btnnexit = new System.Windows.Forms.Button();
            this.btndengji = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtsex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(136, 184);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(199, 25);
            this.dateTime.TabIndex = 28;
            // 
            // txtshiyou
            // 
            this.txtshiyou.Location = new System.Drawing.Point(136, 245);
            this.txtshiyou.Margin = new System.Windows.Forms.Padding(4);
            this.txtshiyou.Multiline = true;
            this.txtshiyou.Name = "txtshiyou";
            this.txtshiyou.Size = new System.Drawing.Size(436, 70);
            this.txtshiyou.TabIndex = 27;
            this.txtshiyou.TextChanged += new System.EventHandler(this.txtshiyou_TextChanged);
            // 
            // lblshiyou
            // 
            this.lblshiyou.AutoSize = true;
            this.lblshiyou.Location = new System.Drawing.Point(36, 249);
            this.lblshiyou.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshiyou.Name = "lblshiyou";
            this.lblshiyou.Size = new System.Drawing.Size(37, 15);
            this.lblshiyou.TabIndex = 26;
            this.lblshiyou.Text = "备注";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(36, 189);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(37, 15);
            this.lbltime.TabIndex = 25;
            this.lbltime.Text = "时间";
            // 
            // txtbroomnumber
            // 
            this.txtbroomnumber.Location = new System.Drawing.Point(417, 54);
            this.txtbroomnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtbroomnumber.Name = "txtbroomnumber";
            this.txtbroomnumber.Size = new System.Drawing.Size(132, 25);
            this.txtbroomnumber.TabIndex = 24;
            // 
            // lblbroomnumber
            // 
            this.lblbroomnumber.AutoSize = true;
            this.lblbroomnumber.Location = new System.Drawing.Point(291, 58);
            this.lblbroomnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbroomnumber.Name = "lblbroomnumber";
            this.lblbroomnumber.Size = new System.Drawing.Size(52, 15);
            this.lblbroomnumber.TabIndex = 23;
            this.lblbroomnumber.Text = "宿舍号";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(136, 109);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 25);
            this.txtname.TabIndex = 19;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(16, 109);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(82, 15);
            this.lblname.TabIndex = 18;
            this.lblname.Text = "登记人姓名";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(307, 112);
            this.lblsex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(82, 15);
            this.lblsex.TabIndex = 17;
            this.lblsex.Text = "登记人性别";
            // 
            // btnnexit
            // 
            this.btnnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnnexit.Location = new System.Drawing.Point(599, 212);
            this.btnnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnnexit.Name = "btnnexit";
            this.btnnexit.Size = new System.Drawing.Size(100, 29);
            this.btnnexit.TabIndex = 16;
            this.btnnexit.Text = "取消";
            this.btnnexit.UseVisualStyleBackColor = true;
            this.btnnexit.Click += new System.EventHandler(this.btnnexit_Click);
            // 
            // btndengji
            // 
            this.btndengji.Location = new System.Drawing.Point(599, 146);
            this.btndengji.Margin = new System.Windows.Forms.Padding(4);
            this.btndengji.Name = "btndengji";
            this.btndengji.Size = new System.Drawing.Size(100, 29);
            this.btndengji.TabIndex = 15;
            this.btndengji.Text = "登记";
            this.btndengji.UseVisualStyleBackColor = true;
            this.btndengji.Click += new System.EventHandler(this.btndengji_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 52);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 25);
            this.txtID.TabIndex = 29;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(4, 58);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 15);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "学生学号";
            // 
            // txtsex
            // 
            this.txtsex.FormattingEnabled = true;
            this.txtsex.Location = new System.Drawing.Point(417, 105);
            this.txtsex.Margin = new System.Windows.Forms.Padding(4);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(132, 23);
            this.txtsex.TabIndex = 31;
            // 
            // 水电收费登记
            // 
            this.AcceptButton = this.btndengji;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnnexit;
            this.ClientSize = new System.Drawing.Size(776, 369);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtshiyou);
            this.Controls.Add(this.lblshiyou);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.txtbroomnumber);
            this.Controls.Add(this.lblbroomnumber);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.btnnexit);
            this.Controls.Add(this.btndengji);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "水电收费登记";
            this.Text = "水电收费登记";
            this.Load += new System.EventHandler(this.迁出登记_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txtshiyou;
        private System.Windows.Forms.Label lblshiyou;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.TextBox txtbroomnumber;
        private System.Windows.Forms.Label lblbroomnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Button btnnexit;
        private System.Windows.Forms.Button btndengji;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox txtsex;
    }
}