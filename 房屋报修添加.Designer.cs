namespace 宿舍管理系统
{
    partial class 房屋报修添加
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(房屋报修添加));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.ondutydateTime = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblfool = new System.Windows.Forms.Label();
            this.txtfool = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(292, 368);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(136, 368);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 29);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "报修";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 175);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "报修人：";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(8, 74);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(82, 15);
            this.lbltime.TabIndex = 3;
            this.lbltime.Text = "报修时间：";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(31, 228);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(52, 15);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "备注：";
            // 
            // ondutydateTime
            // 
            this.ondutydateTime.Location = new System.Drawing.Point(103, 70);
            this.ondutydateTime.Margin = new System.Windows.Forms.Padding(4);
            this.ondutydateTime.Name = "ondutydateTime";
            this.ondutydateTime.Size = new System.Drawing.Size(140, 25);
            this.ondutydateTime.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 171);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(99, 225);
            this.txtText.Margin = new System.Windows.Forms.Padding(4);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(468, 122);
            this.txtText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(212, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "报修登记";
            // 
            // lblfool
            // 
            this.lblfool.AutoSize = true;
            this.lblfool.Location = new System.Drawing.Point(8, 121);
            this.lblfool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfool.Name = "lblfool";
            this.lblfool.Size = new System.Drawing.Size(82, 15);
            this.lblfool.TabIndex = 10;
            this.lblfool.Text = "所在楼层：";
            // 
            // txtfool
            // 
            this.txtfool.FormattingEnabled = true;
            this.txtfool.Location = new System.Drawing.Point(99, 121);
            this.txtfool.Margin = new System.Windows.Forms.Padding(4);
            this.txtfool.Name = "txtfool";
            this.txtfool.Size = new System.Drawing.Size(144, 23);
            this.txtfool.TabIndex = 11;
            // 
            // 房屋报修添加
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(588, 429);
            this.Controls.Add(this.txtfool);
            this.Controls.Add(this.lblfool);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ondutydateTime);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "房屋报修添加";
            this.Text = "房屋报修添加";
            this.Load += new System.EventHandler(this.值班记录添加_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.DateTimePicker ondutydateTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblfool;
        private System.Windows.Forms.ComboBox txtfool;

    }
}