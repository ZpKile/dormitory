namespace 宿舍管理系统
{
    partial class 卫生检查登记
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(卫生检查登记));
            this.cmbScore = new System.Windows.Forms.ComboBox();
            this.roomcode = new System.Windows.Forms.ComboBox();
            this.roomdormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sufeiDataSet5 = new 宿舍管理系统.sufeiDataSet5();
            this.lbltime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.txtBecause = new System.Windows.Forms.TextBox();
            this.cmbFlor = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblBecause = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.roomdormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomdormTableAdapter = new 宿舍管理系统.sufeiDataSet5TableAdapters.roomdormTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomdormBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomdormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbScore
            // 
            this.cmbScore.FormattingEnabled = true;
            this.cmbScore.Location = new System.Drawing.Point(117, 145);
            this.cmbScore.Margin = new System.Windows.Forms.Padding(4);
            this.cmbScore.Name = "cmbScore";
            this.cmbScore.Size = new System.Drawing.Size(132, 23);
            this.cmbScore.TabIndex = 46;
            // 
            // roomcode
            // 
            this.roomcode.DataSource = this.roomdormBindingSource1;
            this.roomcode.DisplayMember = "宿舍号";
            this.roomcode.FormattingEnabled = true;
            this.roomcode.Location = new System.Drawing.Point(117, 104);
            this.roomcode.Margin = new System.Windows.Forms.Padding(4);
            this.roomcode.Name = "roomcode";
            this.roomcode.Size = new System.Drawing.Size(132, 23);
            this.roomcode.TabIndex = 45;
            // 
            // roomdormBindingSource1
            // 
            this.roomdormBindingSource1.DataMember = "roomdorm";
            this.roomdormBindingSource1.DataSource = this.sufeiDataSet5;
            // 
            // sufeiDataSet5
            // 
            this.sufeiDataSet5.DataSetName = "sufeiDataSet5";
            this.sufeiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(23, 248);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(82, 15);
            this.lbltime.TabIndex = 44;
            this.lbltime.Text = "扣分时间：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 236);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 25);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(117, 196);
            this.txtCheck.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(132, 25);
            this.txtCheck.TabIndex = 42;
            // 
            // txtBecause
            // 
            this.txtBecause.Location = new System.Drawing.Point(87, 290);
            this.txtBecause.Margin = new System.Windows.Forms.Padding(4);
            this.txtBecause.Multiline = true;
            this.txtBecause.Name = "txtBecause";
            this.txtBecause.Size = new System.Drawing.Size(240, 62);
            this.txtBecause.TabIndex = 41;
            // 
            // cmbFlor
            // 
            this.cmbFlor.FormattingEnabled = true;
            this.cmbFlor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbFlor.Location = new System.Drawing.Point(117, 55);
            this.cmbFlor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFlor.Name = "cmbFlor";
            this.cmbFlor.Size = new System.Drawing.Size(132, 23);
            this.cmbFlor.TabIndex = 40;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(163, 382);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 29);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "取消(&E)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(25, 382);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 29);
            this.btnEnter.TabIndex = 38;
            this.btnEnter.Text = "登记(&I)";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(39, 200);
            this.lblCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(67, 15);
            this.lblCheck.TabIndex = 37;
            this.lblCheck.Text = "检查人：";
            // 
            // lblBecause
            // 
            this.lblBecause.AutoSize = true;
            this.lblBecause.Location = new System.Drawing.Point(8, 290);
            this.lblBecause.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBecause.Name = "lblBecause";
            this.lblBecause.Size = new System.Drawing.Size(67, 15);
            this.lblBecause.TabIndex = 36;
            this.lblBecause.Text = "扣分项：";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(39, 155);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(67, 15);
            this.lblScore.TabIndex = 35;
            this.lblScore.Text = "扣分值：";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(39, 108);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(67, 15);
            this.lblCode.TabIndex = 34;
            this.lblCode.Text = "宿舍号：";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(39, 59);
            this.lblFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(67, 15);
            this.lblFloor.TabIndex = 33;
            this.lblFloor.Text = "楼层号：";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(160, 22);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(67, 15);
            this.lblRecord.TabIndex = 32;
            this.lblRecord.Text = "扣分记录";
            // 
            // roomdormBindingSource
            // 
            this.roomdormBindingSource.DataMember = "roomdorm";
            this.roomdormBindingSource.DataSource = this.sufeiDataSet5;
            // 
            // roomdormTableAdapter
            // 
            this.roomdormTableAdapter.ClearBeforeFill = true;
            // 
            // 卫生检查登记
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(336, 424);
            this.Controls.Add(this.cmbScore);
            this.Controls.Add(this.roomcode);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.txtBecause);
            this.Controls.Add(this.cmbFlor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblBecause);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblRecord);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "卫生检查登记";
            this.Text = "卫生检查登记";
            this.Load += new System.EventHandler(this.扣分登记_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomdormBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sufeiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomdormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbScore;
        private System.Windows.Forms.ComboBox roomcode;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.TextBox txtBecause;
        private System.Windows.Forms.ComboBox cmbFlor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblBecause;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblRecord;
        private sufeiDataSet5 sufeiDataSet5;
        private System.Windows.Forms.BindingSource roomdormBindingSource;
        private 宿舍管理系统.sufeiDataSet5TableAdapters.roomdormTableAdapter roomdormTableAdapter;
        private System.Windows.Forms.BindingSource roomdormBindingSource1;
    }
}