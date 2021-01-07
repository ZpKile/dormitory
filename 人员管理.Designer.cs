namespace 宿舍管理系统
{
    partial class 人员管理
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
            this.btnfull = new System.Windows.Forms.Button();
            this.listconbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncaxun = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgMyGrid = new System.Windows.Forms.DataGridView();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼层号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宿舍号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年龄DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.系别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.辅导员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年制DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入宿时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.家庭详细信息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sufeiDataSet = new 宿舍管理系统.sufeiDataSet();
            this.studentTableAdapter = new 宿舍管理系统.sufeiDataSetTableAdapters.studentTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbtime
            // 
            this.cmbtime.Location = new System.Drawing.Point(771, 95);
            this.cmbtime.Name = "cmbtime";
            this.cmbtime.Size = new System.Drawing.Size(89, 21);
            this.cmbtime.TabIndex = 18;
            this.cmbtime.Visible = false;
            this.cmbtime.ValueChanged += new System.EventHandler(this.cmbtime_ValueChanged);
            // 
            // btnfull
            // 
            this.btnfull.Location = new System.Drawing.Point(773, 181);
            this.btnfull.Name = "btnfull";
            this.btnfull.Size = new System.Drawing.Size(85, 44);
            this.btnfull.TabIndex = 17;
            this.btnfull.Text = "查询看所有";
            this.btnfull.UseVisualStyleBackColor = true;
            this.btnfull.Click += new System.EventHandler(this.btnfull_Click);
            // 
            // listconbox
            // 
            this.listconbox.FormattingEnabled = true;
            this.listconbox.Location = new System.Drawing.Point(773, 49);
            this.listconbox.Name = "listconbox";
            this.listconbox.Size = new System.Drawing.Size(87, 20);
            this.listconbox.TabIndex = 16;
            this.listconbox.SelectedIndexChanged += new System.EventHandler(this.listconbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(773, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "查询方式：";
            // 
            // btncaxun
            // 
            this.btncaxun.Location = new System.Drawing.Point(773, 123);
            this.btncaxun.Name = "btncaxun";
            this.btncaxun.Size = new System.Drawing.Size(85, 52);
            this.btncaxun.TabIndex = 14;
            this.btncaxun.Text = "查询";
            this.btncaxun.UseVisualStyleBackColor = true;
            this.btncaxun.Click += new System.EventHandler(this.btncaxun_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(773, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(87, 21);
            this.txtName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(773, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "学生姓名：";
            // 
            // dgMyGrid
            // 
            this.dgMyGrid.AllowUserToAddRows = false;
            this.dgMyGrid.AllowUserToOrderColumns = true;
            this.dgMyGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgMyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.楼层号DataGridViewTextBoxColumn,
            this.宿舍号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.年龄DataGridViewTextBoxColumn,
            this.系别DataGridViewTextBoxColumn,
            this.班级DataGridViewTextBoxColumn,
            this.年级DataGridViewTextBoxColumn,
            this.辅导员DataGridViewTextBoxColumn,
            this.年制DataGridViewTextBoxColumn,
            this.联系电话DataGridViewTextBoxColumn,
            this.入宿时间DataGridViewTextBoxColumn,
            this.家庭详细信息DataGridViewTextBoxColumn});
            this.dgMyGrid.Location = new System.Drawing.Point(0, 0);
            this.dgMyGrid.Name = "dgMyGrid";
            this.dgMyGrid.RowTemplate.Height = 23;
            this.dgMyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMyGrid.Size = new System.Drawing.Size(769, 438);
            this.dgMyGrid.TabIndex = 20;
            this.dgMyGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMyGrid_CellContentClick);
            this.dgMyGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgMyGrid_DataError);
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            // 
            // 楼层号DataGridViewTextBoxColumn
            // 
            this.楼层号DataGridViewTextBoxColumn.DataPropertyName = "楼层号";
            this.楼层号DataGridViewTextBoxColumn.HeaderText = "楼层号";
            this.楼层号DataGridViewTextBoxColumn.Name = "楼层号DataGridViewTextBoxColumn";
            // 
            // 宿舍号DataGridViewTextBoxColumn
            // 
            this.宿舍号DataGridViewTextBoxColumn.DataPropertyName = "宿舍号";
            this.宿舍号DataGridViewTextBoxColumn.HeaderText = "宿舍号";
            this.宿舍号DataGridViewTextBoxColumn.Name = "宿舍号DataGridViewTextBoxColumn";
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
            // 年龄DataGridViewTextBoxColumn
            // 
            this.年龄DataGridViewTextBoxColumn.DataPropertyName = "年龄";
            this.年龄DataGridViewTextBoxColumn.HeaderText = "年龄";
            this.年龄DataGridViewTextBoxColumn.Name = "年龄DataGridViewTextBoxColumn";
            // 
            // 系别DataGridViewTextBoxColumn
            // 
            this.系别DataGridViewTextBoxColumn.DataPropertyName = "系别";
            this.系别DataGridViewTextBoxColumn.HeaderText = "系别";
            this.系别DataGridViewTextBoxColumn.Name = "系别DataGridViewTextBoxColumn";
            // 
            // 班级DataGridViewTextBoxColumn
            // 
            this.班级DataGridViewTextBoxColumn.DataPropertyName = "班级";
            this.班级DataGridViewTextBoxColumn.HeaderText = "班级";
            this.班级DataGridViewTextBoxColumn.Name = "班级DataGridViewTextBoxColumn";
            // 
            // 年级DataGridViewTextBoxColumn
            // 
            this.年级DataGridViewTextBoxColumn.DataPropertyName = "年级";
            this.年级DataGridViewTextBoxColumn.HeaderText = "年级";
            this.年级DataGridViewTextBoxColumn.Name = "年级DataGridViewTextBoxColumn";
            // 
            // 辅导员DataGridViewTextBoxColumn
            // 
            this.辅导员DataGridViewTextBoxColumn.DataPropertyName = "辅导员";
            this.辅导员DataGridViewTextBoxColumn.HeaderText = "辅导员";
            this.辅导员DataGridViewTextBoxColumn.Name = "辅导员DataGridViewTextBoxColumn";
            // 
            // 年制DataGridViewTextBoxColumn
            // 
            this.年制DataGridViewTextBoxColumn.DataPropertyName = "年制";
            this.年制DataGridViewTextBoxColumn.HeaderText = "年制";
            this.年制DataGridViewTextBoxColumn.Name = "年制DataGridViewTextBoxColumn";
            // 
            // 联系电话DataGridViewTextBoxColumn
            // 
            this.联系电话DataGridViewTextBoxColumn.DataPropertyName = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.Name = "联系电话DataGridViewTextBoxColumn";
            // 
            // 入宿时间DataGridViewTextBoxColumn
            // 
            this.入宿时间DataGridViewTextBoxColumn.DataPropertyName = "入宿时间";
            this.入宿时间DataGridViewTextBoxColumn.HeaderText = "入宿时间";
            this.入宿时间DataGridViewTextBoxColumn.Name = "入宿时间DataGridViewTextBoxColumn";
            // 
            // 家庭详细信息DataGridViewTextBoxColumn
            // 
            this.家庭详细信息DataGridViewTextBoxColumn.DataPropertyName = "家庭详细信息";
            this.家庭详细信息DataGridViewTextBoxColumn.HeaderText = "家庭详细信息";
            this.家庭详细信息DataGridViewTextBoxColumn.Name = "家庭详细信息DataGridViewTextBoxColumn";
            // 
            // sufeiDataSet
            // 
            this.sufeiDataSet.DataSetName = "sufeiDataSet";
            this.sufeiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 25);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.更新ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.管理ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.管理ToolStripMenuItem.Text = "人员管理";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.更新ToolStripMenuItem.Text = "更新";
            this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(775, 231);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 47);
            this.refresh.TabIndex = 25;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.sufeiDataSet;
            // 
            // 人员管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(863, 442);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dgMyGrid);
            this.Controls.Add(this.cmbtime);
            this.Controls.Add(this.btnfull);
            this.Controls.Add(this.listconbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncaxun);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "人员管理";
            this.Text = "人员管理";
            this.Load += new System.EventHandler(this.人员管理_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cmbtime;
        private System.Windows.Forms.Button btnfull;
        private System.Windows.Forms.ComboBox listconbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncaxun;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgMyGrid;
        private sufeiDataSet sufeiDataSet;
        private 宿舍管理系统.sufeiDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼层号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿舍号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年龄DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 系别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 辅导员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年制DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入宿时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家庭详细信息DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}