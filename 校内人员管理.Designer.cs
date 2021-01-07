namespace 宿舍管理系统
{
    partial class 校内人员管理
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
            this.cmbtime = new System.Windows.Forms.DateTimePicker();
            this.refresh = new System.Windows.Forms.Button();
            this.btnfull = new System.Windows.Forms.Button();
            this.listconbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncaxun = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.dgMyGrid = new System.Windows.Forms.DataGridView();
            this.来访序号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.被访学生姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.被访学生宿舍号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.来访时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.在校职位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.来访事由DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sufeiDataSet4 = new 宿舍管理系统.sufeiDataSet4();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolinTableAdapter = new 宿舍管理系统.sufeiDataSet4TableAdapters.SchoolinTableAdapter();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbtime
            // 
            this.cmbtime.Location = new System.Drawing.Point(724, 100);
            this.cmbtime.Name = "cmbtime";
            this.cmbtime.Size = new System.Drawing.Size(94, 21);
            this.cmbtime.TabIndex = 51;
            this.cmbtime.Visible = false;
            this.cmbtime.ValueChanged += new System.EventHandler(this.cmbtime_ValueChanged);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(720, 235);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(94, 47);
            this.refresh.TabIndex = 50;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // btnfull
            // 
            this.btnfull.Location = new System.Drawing.Point(720, 185);
            this.btnfull.Name = "btnfull";
            this.btnfull.Size = new System.Drawing.Size(94, 44);
            this.btnfull.TabIndex = 49;
            this.btnfull.Text = "查询看所有";
            this.btnfull.UseVisualStyleBackColor = true;
            this.btnfull.Click += new System.EventHandler(this.btnfull_Click);
            // 
            // listconbox
            // 
            this.listconbox.FormattingEnabled = true;
            this.listconbox.Location = new System.Drawing.Point(722, 44);
            this.listconbox.Name = "listconbox";
            this.listconbox.Size = new System.Drawing.Size(96, 20);
            this.listconbox.TabIndex = 48;
            this.listconbox.SelectedIndexChanged += new System.EventHandler(this.listconbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(726, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "查询方式：";
            // 
            // btncaxun
            // 
            this.btncaxun.Location = new System.Drawing.Point(720, 127);
            this.btncaxun.Name = "btncaxun";
            this.btncaxun.Size = new System.Drawing.Size(94, 52);
            this.btncaxun.TabIndex = 46;
            this.btncaxun.Text = "查询";
            this.btncaxun.UseVisualStyleBackColor = true;
            this.btncaxun.Click += new System.EventHandler(this.btncaxun_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(724, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "学生姓名：";
            // 
            // dgMyGrid
            // 
            this.dgMyGrid.AllowUserToAddRows = false;
            this.dgMyGrid.AllowUserToOrderColumns = true;
            this.dgMyGrid.AutoGenerateColumns = false;
            this.dgMyGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgMyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.来访序号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.被访学生姓名DataGridViewTextBoxColumn,
            this.被访学生宿舍号DataGridViewTextBoxColumn,
            this.来访时间DataGridViewTextBoxColumn,
            this.在校职位DataGridViewTextBoxColumn,
            this.来访事由DataGridViewTextBoxColumn});
            this.dgMyGrid.DataSource = this.schoolinBindingSource;
            this.dgMyGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgMyGrid.Location = new System.Drawing.Point(0, 0);
            this.dgMyGrid.Name = "dgMyGrid";
            this.dgMyGrid.RowTemplate.Height = 23;
            this.dgMyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMyGrid.Size = new System.Drawing.Size(714, 402);
            this.dgMyGrid.TabIndex = 52;
            this.dgMyGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgMyGrid_DataError);
            // 
            // 来访序号DataGridViewTextBoxColumn
            // 
            this.来访序号DataGridViewTextBoxColumn.DataPropertyName = "来访序号";
            this.来访序号DataGridViewTextBoxColumn.HeaderText = "来访序号";
            this.来访序号DataGridViewTextBoxColumn.Name = "来访序号DataGridViewTextBoxColumn";
            this.来访序号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 被访学生姓名DataGridViewTextBoxColumn
            // 
            this.被访学生姓名DataGridViewTextBoxColumn.DataPropertyName = "被访学生姓名";
            this.被访学生姓名DataGridViewTextBoxColumn.HeaderText = "被访学生姓名";
            this.被访学生姓名DataGridViewTextBoxColumn.Name = "被访学生姓名DataGridViewTextBoxColumn";
            // 
            // 被访学生宿舍号DataGridViewTextBoxColumn
            // 
            this.被访学生宿舍号DataGridViewTextBoxColumn.DataPropertyName = "被访学生宿舍号";
            this.被访学生宿舍号DataGridViewTextBoxColumn.HeaderText = "被访学生宿舍号";
            this.被访学生宿舍号DataGridViewTextBoxColumn.Name = "被访学生宿舍号DataGridViewTextBoxColumn";
            // 
            // 来访时间DataGridViewTextBoxColumn
            // 
            this.来访时间DataGridViewTextBoxColumn.DataPropertyName = "来访时间";
            this.来访时间DataGridViewTextBoxColumn.HeaderText = "来访时间";
            this.来访时间DataGridViewTextBoxColumn.Name = "来访时间DataGridViewTextBoxColumn";
            // 
            // 在校职位DataGridViewTextBoxColumn
            // 
            this.在校职位DataGridViewTextBoxColumn.DataPropertyName = "在校职位";
            this.在校职位DataGridViewTextBoxColumn.HeaderText = "在校职位";
            this.在校职位DataGridViewTextBoxColumn.Name = "在校职位DataGridViewTextBoxColumn";
            // 
            // 来访事由DataGridViewTextBoxColumn
            // 
            this.来访事由DataGridViewTextBoxColumn.DataPropertyName = "来访事由";
            this.来访事由DataGridViewTextBoxColumn.HeaderText = "来访事由";
            this.来访事由DataGridViewTextBoxColumn.Name = "来访事由DataGridViewTextBoxColumn";
            // 
            // schoolinBindingSource
            // 
            this.schoolinBindingSource.DataMember = "Schoolin";
            this.schoolinBindingSource.DataSource = this.sufeiDataSet4;
            // 
            // sufeiDataSet4
            // 
            this.sufeiDataSet4.DataSetName = "sufeiDataSet4";
            this.sufeiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(714, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(104, 25);
            this.menuStrip1.TabIndex = 53;
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
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.管理ToolStripMenuItem.Text = "校内来访人员管理";
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
            // schoolinTableAdapter
            // 
            this.schoolinTableAdapter.ClearBeforeFill = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(722, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(96, 21);
            this.txtName.TabIndex = 54;
            // 
            // 校内人员管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(818, 402);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgMyGrid);
            this.Controls.Add(this.cmbtime);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.btnfull);
            this.Controls.Add(this.listconbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncaxun);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "校内人员管理";
            this.Text = "校内人员管理";
            this.Load += new System.EventHandler(this.校内人员管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cmbtime;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button btnfull;
        private System.Windows.Forms.ComboBox listconbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncaxun;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgMyGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private sufeiDataSet4 sufeiDataSet4;
        private System.Windows.Forms.BindingSource schoolinBindingSource;
        private 宿舍管理系统.sufeiDataSet4TableAdapters.SchoolinTableAdapter schoolinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 来访序号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 被访学生姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 被访学生宿舍号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 来访时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 在校职位DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 来访事由DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtName;
    }
}