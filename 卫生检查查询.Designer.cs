﻿namespace 宿舍管理系统
{
    partial class 卫生检查查询
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
            this.dgMyGrid = new System.Windows.Forms.DataGridView();
            this.cmbtime = new System.Windows.Forms.DateTimePicker();
            this.listconbox = new System.Windows.Forms.ComboBox();
            this.exit = new System.Windows.Forms.Button();
            this.btnfull = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncaxun = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMyGrid
            // 
            this.dgMyGrid.AllowUserToAddRows = false;
            this.dgMyGrid.AllowUserToDeleteRows = false;
            this.dgMyGrid.AllowUserToOrderColumns = true;
            this.dgMyGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgMyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgMyGrid.Location = new System.Drawing.Point(0, 0);
            this.dgMyGrid.Name = "dgMyGrid";
            this.dgMyGrid.ReadOnly = true;
            this.dgMyGrid.RowTemplate.Height = 23;
            this.dgMyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMyGrid.Size = new System.Drawing.Size(605, 423);
            this.dgMyGrid.TabIndex = 51;
            // 
            // cmbtime
            // 
            this.cmbtime.Location = new System.Drawing.Point(611, 76);
            this.cmbtime.Name = "cmbtime";
            this.cmbtime.Size = new System.Drawing.Size(89, 21);
            this.cmbtime.TabIndex = 50;
            this.cmbtime.Visible = false;
            // 
            // listconbox
            // 
            this.listconbox.FormattingEnabled = true;
            this.listconbox.Location = new System.Drawing.Point(609, 20);
            this.listconbox.Name = "listconbox";
            this.listconbox.Size = new System.Drawing.Size(96, 20);
            this.listconbox.TabIndex = 49;
            this.listconbox.SelectedIndexChanged += new System.EventHandler(this.listconbox_SelectedIndexChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(611, 211);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 47);
            this.exit.TabIndex = 48;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnfull
            // 
            this.btnfull.Location = new System.Drawing.Point(611, 161);
            this.btnfull.Name = "btnfull";
            this.btnfull.Size = new System.Drawing.Size(94, 44);
            this.btnfull.TabIndex = 47;
            this.btnfull.Text = "查询看所有";
            this.btnfull.UseVisualStyleBackColor = true;
            this.btnfull.Click += new System.EventHandler(this.btnfull_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(611, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 46;
            this.label1.Text = "查询方式：";
            // 
            // btncaxun
            // 
            this.btncaxun.Location = new System.Drawing.Point(611, 103);
            this.btncaxun.Name = "btncaxun";
            this.btncaxun.Size = new System.Drawing.Size(94, 52);
            this.btncaxun.TabIndex = 45;
            this.btncaxun.Text = "查询";
            this.btncaxun.UseVisualStyleBackColor = true;
            this.btncaxun.Click += new System.EventHandler(this.btncaxun_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(611, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "学生姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(609, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(96, 21);
            this.txtName.TabIndex = 52;
            // 
            // 扣分查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(712, 423);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgMyGrid);
            this.Controls.Add(this.cmbtime);
            this.Controls.Add(this.listconbox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnfull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncaxun);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "扣分查询";
            this.Text = "扣分查询";
            this.Load += new System.EventHandler(this.扣分查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMyGrid;
        private System.Windows.Forms.DateTimePicker cmbtime;
        private System.Windows.Forms.ComboBox listconbox;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btnfull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncaxun;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}