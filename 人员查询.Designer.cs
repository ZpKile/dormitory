namespace 宿舍管理系统
{
    partial class 迁出查询
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
            this.btncaxun = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listconbox = new System.Windows.Forms.ComboBox();
            this.btnfull = new System.Windows.Forms.Button();
            this.cmbtime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dgMyGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btncaxun
            // 
            this.btncaxun.Location = new System.Drawing.Point(581, 6);
            this.btncaxun.Name = "btncaxun";
            this.btncaxun.Size = new System.Drawing.Size(75, 23);
            this.btncaxun.TabIndex = 5;
            this.btncaxun.Text = "查询";
            this.btncaxun.UseVisualStyleBackColor = true;
            this.btncaxun.Click += new System.EventHandler(this.btncaxun_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(407, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 21);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(225, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "请输入要查询的学生姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "查询方式：";
            // 
            // listconbox
            // 
            this.listconbox.FormattingEnabled = true;
            this.listconbox.Location = new System.Drawing.Point(83, 7);
            this.listconbox.Name = "listconbox";
            this.listconbox.Size = new System.Drawing.Size(121, 20);
            this.listconbox.TabIndex = 7;
            this.listconbox.SelectedIndexChanged += new System.EventHandler(this.listconbox_SelectedIndexChanged);
            // 
            // btnfull
            // 
            this.btnfull.Location = new System.Drawing.Point(675, 6);
            this.btnfull.Name = "btnfull";
            this.btnfull.Size = new System.Drawing.Size(75, 23);
            this.btnfull.TabIndex = 8;
            this.btnfull.Text = "查询看所有";
            this.btnfull.UseVisualStyleBackColor = true;
            this.btnfull.Click += new System.EventHandler(this.btnfull_Click);
            // 
            // cmbtime
            // 
            this.cmbtime.Location = new System.Drawing.Point(407, 6);
            this.cmbtime.Name = "cmbtime";
            this.cmbtime.Size = new System.Drawing.Size(145, 21);
            this.cmbtime.TabIndex = 9;
            this.cmbtime.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgMyGrid
            // 
            this.dgMyGrid.AllowUserToAddRows = false;
            this.dgMyGrid.AllowUserToDeleteRows = false;
            this.dgMyGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgMyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgMyGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgMyGrid.Location = new System.Drawing.Point(0, 35);
            this.dgMyGrid.Name = "dgMyGrid";
            this.dgMyGrid.ReadOnly = true;
            this.dgMyGrid.RowTemplate.Height = 23;
            this.dgMyGrid.Size = new System.Drawing.Size(860, 472);
            this.dgMyGrid.TabIndex = 11;
            this.dgMyGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMyGrid_CellContentClick);
            // 
            // 迁出查询
            // 
            this.AcceptButton = this.btncaxun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(860, 507);
            this.Controls.Add(this.dgMyGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbtime);
            this.Controls.Add(this.btnfull);
            this.Controls.Add(this.listconbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncaxun);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "迁出查询";
            this.Text = "宿舍人员查询";
            this.Load += new System.EventHandler(this.姓名查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncaxun;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listconbox;
        private System.Windows.Forms.Button btnfull;
        private System.Windows.Forms.DateTimePicker cmbtime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgMyGrid;
    }
}