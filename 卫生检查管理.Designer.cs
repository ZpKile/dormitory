namespace 宿舍管理系统
{
    partial class 卫生检查管理
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgMyGrid = new System.Windows.Forms.DataGridView();
            this.listconbox = new System.Windows.Forms.ComboBox();
            this.refsh = new System.Windows.Forms.Button();
            this.btnfull = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncaxun = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbtime = new System.Windows.Forms.DateTimePicker();
            this.sufeiDataSet7 = new 宿舍管理系统.sufeiDataSet7();
            this.centtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centtableTableAdapter = new 宿舍管理系统.sufeiDataSet7TableAdapters.centtableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centtableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(611, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(96, 21);
            this.txtName.TabIndex = 60;
            // 
            // dgMyGrid
            // 
            this.dgMyGrid.AllowUserToAddRows = false;
            this.dgMyGrid.AllowUserToOrderColumns = true;
            this.dgMyGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgMyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgMyGrid.Location = new System.Drawing.Point(0, 0);
            this.dgMyGrid.Name = "dgMyGrid";
            this.dgMyGrid.RowTemplate.Height = 23;
            this.dgMyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMyGrid.Size = new System.Drawing.Size(605, 459);
            this.dgMyGrid.TabIndex = 59;
            // 
            // listconbox
            // 
            this.listconbox.FormattingEnabled = true;
            this.listconbox.Location = new System.Drawing.Point(611, 49);
            this.listconbox.Name = "listconbox";
            this.listconbox.Size = new System.Drawing.Size(96, 20);
            this.listconbox.TabIndex = 58;
            this.listconbox.SelectedIndexChanged += new System.EventHandler(this.listconbox_SelectedIndexChanged);
            // 
            // refsh
            // 
            this.refsh.Location = new System.Drawing.Point(613, 240);
            this.refsh.Name = "refsh";
            this.refsh.Size = new System.Drawing.Size(94, 47);
            this.refsh.TabIndex = 57;
            this.refsh.Text = "刷新";
            this.refsh.UseVisualStyleBackColor = true;
            this.refsh.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnfull
            // 
            this.btnfull.Location = new System.Drawing.Point(613, 190);
            this.btnfull.Name = "btnfull";
            this.btnfull.Size = new System.Drawing.Size(94, 44);
            this.btnfull.TabIndex = 56;
            this.btnfull.Text = "查询看所有";
            this.btnfull.UseVisualStyleBackColor = true;
            this.btnfull.Click += new System.EventHandler(this.btnfull_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(613, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 55;
            this.label1.Text = "查询方式：";
            // 
            // btncaxun
            // 
            this.btncaxun.Location = new System.Drawing.Point(613, 132);
            this.btncaxun.Name = "btncaxun";
            this.btncaxun.Size = new System.Drawing.Size(94, 52);
            this.btncaxun.TabIndex = 54;
            this.btncaxun.Text = "查询";
            this.btncaxun.UseVisualStyleBackColor = true;
            this.btncaxun.Click += new System.EventHandler(this.btncaxun_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(613, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "学生姓名：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(605, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(108, 25);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.更新ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.管理ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.管理ToolStripMenuItem.Text = "扣分管理";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.更新ToolStripMenuItem.Text = "更新";
            this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // cmbtime
            // 
            this.cmbtime.Location = new System.Drawing.Point(611, 106);
            this.cmbtime.Name = "cmbtime";
            this.cmbtime.Size = new System.Drawing.Size(96, 21);
            this.cmbtime.TabIndex = 64;
            this.cmbtime.Visible = false;
            // 
            // sufeiDataSet7
            // 
            this.sufeiDataSet7.DataSetName = "sufeiDataSet7";
            this.sufeiDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // centtableBindingSource
            // 
            this.centtableBindingSource.DataMember = "centtable";
            this.centtableBindingSource.DataSource = this.sufeiDataSet7;
            // 
            // centtableTableAdapter
            // 
            this.centtableTableAdapter.ClearBeforeFill = true;
            // 
            // 扣分记录管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(713, 459);
            this.Controls.Add(this.cmbtime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgMyGrid);
            this.Controls.Add(this.listconbox);
            this.Controls.Add(this.refsh);
            this.Controls.Add(this.btnfull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncaxun);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "扣分记录管理";
            this.Text = "扣分记录管理";
            this.Load += new System.EventHandler(this.扣分记录管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centtableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgMyGrid;
        private System.Windows.Forms.ComboBox listconbox;
        private System.Windows.Forms.Button refsh;
        private System.Windows.Forms.Button btnfull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncaxun;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker cmbtime;
        private sufeiDataSet7 sufeiDataSet7;
        private System.Windows.Forms.BindingSource centtableBindingSource;
        private 宿舍管理系统.sufeiDataSet7TableAdapters.centtableTableAdapter centtableTableAdapter;
    }
}