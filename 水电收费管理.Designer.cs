namespace 宿舍管理系统
{
    partial class 迁出人员管理
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
            this.refresh = new System.Windows.Forms.Button();
            this.dgMyGrid = new System.Windows.Forms.DataGridView();
            this.levelogionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sufeiDataSet11 = new 宿舍管理系统.sufeiDataSet1();
            this.cmbtime = new System.Windows.Forms.DateTimePicker();
            this.btnfull = new System.Windows.Forms.Button();
            this.listconbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncaxun = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelogionTableAdapter = new 宿舍管理系统.sufeiDataSet1TableAdapters.levelogionTableAdapter();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宿舍号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.迁出事由DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelogionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet11)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(835, 288);
            this.refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(125, 59);
            this.refresh.TabIndex = 33;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dgMyGrid
            // 
            this.dgMyGrid.AllowUserToAddRows = false;
            this.dgMyGrid.AllowUserToOrderColumns = true;
            this.dgMyGrid.AutoGenerateColumns = false;
            this.dgMyGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgMyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.宿舍号DataGridViewTextBoxColumn,
            this.时间DataGridViewTextBoxColumn,
            this.迁出事由DataGridViewTextBoxColumn});
            this.dgMyGrid.DataSource = this.levelogionBindingSource;
            this.dgMyGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgMyGrid.Location = new System.Drawing.Point(0, 0);
            this.dgMyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgMyGrid.Name = "dgMyGrid";
            this.dgMyGrid.RowTemplate.Height = 23;
            this.dgMyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMyGrid.Size = new System.Drawing.Size(829, 534);
            this.dgMyGrid.TabIndex = 32;
            this.dgMyGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMyGrid_CellContentClick);
            this.dgMyGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgMyGrid_DataError);
            // 
            // levelogionBindingSource
            // 
            this.levelogionBindingSource.DataMember = "levelogion";
            this.levelogionBindingSource.DataSource = this.sufeiDataSet11;
            // 
            // sufeiDataSet11
            // 
            this.sufeiDataSet11.DataSetName = "sufeiDataSet1";
            this.sufeiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbtime
            // 
            this.cmbtime.Location = new System.Drawing.Point(832, 119);
            this.cmbtime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbtime.Name = "cmbtime";
            this.cmbtime.Size = new System.Drawing.Size(117, 25);
            this.cmbtime.TabIndex = 31;
            this.cmbtime.Visible = false;
            // 
            // btnfull
            // 
            this.btnfull.Location = new System.Drawing.Point(835, 225);
            this.btnfull.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfull.Name = "btnfull";
            this.btnfull.Size = new System.Drawing.Size(125, 55);
            this.btnfull.TabIndex = 30;
            this.btnfull.Text = "查询看所有";
            this.btnfull.UseVisualStyleBackColor = true;
            this.btnfull.Click += new System.EventHandler(this.btnfull_Click);
            // 
            // listconbox
            // 
            this.listconbox.FormattingEnabled = true;
            this.listconbox.Location = new System.Drawing.Point(832, 49);
            this.listconbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listconbox.Name = "listconbox";
            this.listconbox.Size = new System.Drawing.Size(127, 23);
            this.listconbox.TabIndex = 29;
            this.listconbox.SelectedIndexChanged += new System.EventHandler(this.listconbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(832, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "查询方式：";
            // 
            // btncaxun
            // 
            this.btncaxun.Location = new System.Drawing.Point(835, 152);
            this.btncaxun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncaxun.Name = "btncaxun";
            this.btncaxun.Size = new System.Drawing.Size(125, 65);
            this.btncaxun.TabIndex = 27;
            this.btncaxun.Text = "查询";
            this.btncaxun.UseVisualStyleBackColor = true;
            this.btncaxun.Click += new System.EventHandler(this.btncaxun_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(835, 89);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "学生姓名：";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(833, 119);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 25);
            this.txtName.TabIndex = 34;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(829, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(132, 28);
            this.menuStrip1.TabIndex = 35;
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
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.管理ToolStripMenuItem.Text = "水电收费管理";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.更新ToolStripMenuItem.Text = "更新";
            this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // levelogionTableAdapter
            // 
            this.levelogionTableAdapter.ClearBeforeFill = true;
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
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
            // 宿舍号DataGridViewTextBoxColumn
            // 
            this.宿舍号DataGridViewTextBoxColumn.DataPropertyName = "宿舍号";
            this.宿舍号DataGridViewTextBoxColumn.HeaderText = "宿舍号";
            this.宿舍号DataGridViewTextBoxColumn.Name = "宿舍号DataGridViewTextBoxColumn";
            // 
            // 时间DataGridViewTextBoxColumn
            // 
            this.时间DataGridViewTextBoxColumn.DataPropertyName = "时间";
            this.时间DataGridViewTextBoxColumn.HeaderText = "时间";
            this.时间DataGridViewTextBoxColumn.Name = "时间DataGridViewTextBoxColumn";
            // 
            // 迁出事由DataGridViewTextBoxColumn
            // 
            this.迁出事由DataGridViewTextBoxColumn.DataPropertyName = "备注";
            this.迁出事由DataGridViewTextBoxColumn.HeaderText = "备注";
            this.迁出事由DataGridViewTextBoxColumn.Name = "迁出事由DataGridViewTextBoxColumn";
            // 
            // 迁出人员管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(961, 534);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dgMyGrid);
            this.Controls.Add(this.cmbtime);
            this.Controls.Add(this.btnfull);
            this.Controls.Add(this.listconbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncaxun);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "迁出人员管理";
            this.Text = "水电收费管理";
            this.Load += new System.EventHandler(this.迁出管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelogionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet11)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView dgMyGrid;
        private System.Windows.Forms.DateTimePicker cmbtime;
        private System.Windows.Forms.Button btnfull;
        private System.Windows.Forms.ComboBox listconbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncaxun;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private sufeiDataSet1 sufeiDataSet11;
        private System.Windows.Forms.BindingSource levelogionBindingSource;
        private 宿舍管理系统.sufeiDataSet1TableAdapters.levelogionTableAdapter levelogionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿舍号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 迁出事由DataGridViewTextBoxColumn;
    }
}