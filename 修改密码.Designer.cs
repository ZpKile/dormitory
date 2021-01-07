namespace 宿舍管理系统
{
    partial class 修改密码
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sufeiDataSet9 = new 宿舍管理系统.sufeiDataSet9();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lbloldPassword = new System.Windows.Forms.Label();
            this.lblEnterpassword = new System.Windows.Forms.Label();
            this.txtEnterpassword = new System.Windows.Forms.TextBox();
            this.userInfoTableAdapter = new 宿舍管理系统.sufeiDataSet9TableAdapters.UserInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(30, 148);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "修改";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(131, 148);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "取消";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cmbUser
            // 
            this.cmbUser.DataSource = this.userInfoBindingSource;
            this.cmbUser.DisplayMember = "UserName";
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(85, 18);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 20);
            this.cmbUser.TabIndex = 2;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataMember = "UserInfo";
            this.userInfoBindingSource.DataSource = this.sufeiDataSet9;
            // 
            // sufeiDataSet9
            // 
            this.sufeiDataSet9.DataSetName = "sufeiDataSet9";
            this.sufeiDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Location = new System.Drawing.Point(85, 53);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(121, 21);
            this.txtoldpassword.TabIndex = 4;
            this.txtoldpassword.UseSystemPasswordChar = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(28, 21);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 12);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "用户名：";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(26, 86);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 12);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "新密码：";
            // 
            // lbloldPassword
            // 
            this.lbloldPassword.AutoSize = true;
            this.lbloldPassword.Location = new System.Drawing.Point(28, 56);
            this.lbloldPassword.Name = "lbloldPassword";
            this.lbloldPassword.Size = new System.Drawing.Size(53, 12);
            this.lbloldPassword.TabIndex = 7;
            this.lbloldPassword.Text = "旧密码：";
            // 
            // lblEnterpassword
            // 
            this.lblEnterpassword.AutoSize = true;
            this.lblEnterpassword.Location = new System.Drawing.Point(2, 119);
            this.lblEnterpassword.Name = "lblEnterpassword";
            this.lblEnterpassword.Size = new System.Drawing.Size(77, 12);
            this.lblEnterpassword.TabIndex = 9;
            this.lblEnterpassword.Text = "确认新密码：";
            // 
            // txtEnterpassword
            // 
            this.txtEnterpassword.Location = new System.Drawing.Point(85, 110);
            this.txtEnterpassword.Name = "txtEnterpassword";
            this.txtEnterpassword.Size = new System.Drawing.Size(121, 21);
            this.txtEnterpassword.TabIndex = 8;
            this.txtEnterpassword.UseSystemPasswordChar = true;
            // 
            // userInfoTableAdapter
            // 
            this.userInfoTableAdapter.ClearBeforeFill = true;
            // 
            // 修改密码
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(219, 186);
            this.Controls.Add(this.lblEnterpassword);
            this.Controls.Add(this.txtEnterpassword);
            this.Controls.Add(this.lbloldPassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtoldpassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnEnter);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "修改密码";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.修改密码_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lbloldPassword;
        private System.Windows.Forms.Label lblEnterpassword;
        private System.Windows.Forms.TextBox txtEnterpassword;
        private sufeiDataSet9 sufeiDataSet9;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private 宿舍管理系统.sufeiDataSet9TableAdapters.UserInfoTableAdapter userInfoTableAdapter;
    }
}