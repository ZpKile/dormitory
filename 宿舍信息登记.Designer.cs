namespace 宿舍管理系统
{
    partial class 宿舍信息登记
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(宿舍信息登记));
            this.txtzhang = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndengji = new System.Windows.Forms.Button();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.cmbempity = new System.Windows.Forms.ComboBox();
            this.cmbinroom = new System.Windows.Forms.ComboBox();
            this.cmbkind = new System.Windows.Forms.ComboBox();
            this.cmbfloor = new System.Windows.Forms.ComboBox();
            this.lblempty = new System.Windows.Forms.Label();
            this.lblinroom = new System.Windows.Forms.Label();
            this.lblAssitant = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.lblkind = new System.Windows.Forms.Label();
            this.lblfloor = new System.Windows.Forms.Label();
            this.cmbisfull = new System.Windows.Forms.ComboBox();
            this.lblisfull = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtzhang
            // 
            this.txtzhang.Location = new System.Drawing.Point(173, 209);
            this.txtzhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtzhang.Name = "txtzhang";
            this.txtzhang.Size = new System.Drawing.Size(139, 25);
            this.txtzhang.TabIndex = 35;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltitle.Location = new System.Drawing.Point(152, 26);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(106, 24);
            this.lbltitle.TabIndex = 33;
            this.lbltitle.Text = "宿舍信息";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(208, 380);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 29);
            this.btnexit.TabIndex = 32;
            this.btnexit.Text = "取消";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndengji
            // 
            this.btndengji.Location = new System.Drawing.Point(79, 380);
            this.btndengji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndengji.Name = "btndengji";
            this.btndengji.Size = new System.Drawing.Size(100, 29);
            this.btndengji.TabIndex = 31;
            this.btndengji.Text = "登记";
            this.btndengji.UseVisualStyleBackColor = true;
            this.btndengji.Click += new System.EventHandler(this.btndengji_Click);
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(175, 139);
            this.cmbtype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(137, 23);
            this.cmbtype.TabIndex = 30;
            // 
            // cmbempity
            // 
            this.cmbempity.FormattingEnabled = true;
            this.cmbempity.Location = new System.Drawing.Point(173, 276);
            this.cmbempity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbempity.Name = "cmbempity";
            this.cmbempity.Size = new System.Drawing.Size(137, 23);
            this.cmbempity.TabIndex = 29;
            // 
            // cmbinroom
            // 
            this.cmbinroom.FormattingEnabled = true;
            this.cmbinroom.Location = new System.Drawing.Point(173, 244);
            this.cmbinroom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbinroom.Name = "cmbinroom";
            this.cmbinroom.Size = new System.Drawing.Size(137, 23);
            this.cmbinroom.TabIndex = 28;
            // 
            // cmbkind
            // 
            this.cmbkind.FormattingEnabled = true;
            this.cmbkind.Location = new System.Drawing.Point(172, 176);
            this.cmbkind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbkind.Name = "cmbkind";
            this.cmbkind.Size = new System.Drawing.Size(137, 23);
            this.cmbkind.TabIndex = 27;
            // 
            // cmbfloor
            // 
            this.cmbfloor.FormattingEnabled = true;
            this.cmbfloor.Location = new System.Drawing.Point(176, 72);
            this.cmbfloor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbfloor.Name = "cmbfloor";
            this.cmbfloor.Size = new System.Drawing.Size(137, 23);
            this.cmbfloor.TabIndex = 26;
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Location = new System.Drawing.Point(55, 286);
            this.lblempty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(52, 15);
            this.lblempty.TabIndex = 25;
            this.lblempty.Text = "空位：";
            // 
            // lblinroom
            // 
            this.lblinroom.AutoSize = true;
            this.lblinroom.Location = new System.Drawing.Point(55, 255);
            this.lblinroom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinroom.Name = "lblinroom";
            this.lblinroom.Size = new System.Drawing.Size(82, 15);
            this.lblinroom.TabIndex = 24;
            this.lblinroom.Text = "已住人数：";
            // 
            // lblAssitant
            // 
            this.lblAssitant.AutoSize = true;
            this.lblAssitant.Location = new System.Drawing.Point(55, 212);
            this.lblAssitant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssitant.Name = "lblAssitant";
            this.lblAssitant.Size = new System.Drawing.Size(67, 15);
            this.lblAssitant.TabIndex = 23;
            this.lblAssitant.Text = "宿舍长：";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(56, 109);
            this.lbltype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(67, 15);
            this.lbltype.TabIndex = 22;
            this.lbltype.Text = "宿舍号：";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Location = new System.Drawing.Point(49, 142);
            this.lblcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(82, 15);
            this.lblcode.TabIndex = 21;
            this.lblcode.Text = "宿舍类型：";
            // 
            // lblkind
            // 
            this.lblkind.AutoSize = true;
            this.lblkind.Location = new System.Drawing.Point(53, 176);
            this.lblkind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkind.Name = "lblkind";
            this.lblkind.Size = new System.Drawing.Size(82, 15);
            this.lblkind.TabIndex = 20;
            this.lblkind.Text = "楼层类别：";
            // 
            // lblfloor
            // 
            this.lblfloor.AutoSize = true;
            this.lblfloor.Location = new System.Drawing.Point(57, 72);
            this.lblfloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfloor.Name = "lblfloor";
            this.lblfloor.Size = new System.Drawing.Size(67, 15);
            this.lblfloor.TabIndex = 19;
            this.lblfloor.Text = "楼层号：";
            // 
            // cmbisfull
            // 
            this.cmbisfull.FormattingEnabled = true;
            this.cmbisfull.Location = new System.Drawing.Point(172, 318);
            this.cmbisfull.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbisfull.Name = "cmbisfull";
            this.cmbisfull.Size = new System.Drawing.Size(139, 23);
            this.cmbisfull.TabIndex = 36;
            // 
            // lblisfull
            // 
            this.lblisfull.AutoSize = true;
            this.lblisfull.Location = new System.Drawing.Point(55, 318);
            this.lblisfull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisfull.Name = "lblisfull";
            this.lblisfull.Size = new System.Drawing.Size(82, 15);
            this.lblisfull.TabIndex = 37;
            this.lblisfull.Text = "是否住满：";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(175, 105);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(132, 25);
            this.txtcode.TabIndex = 38;
            // 
            // 宿舍信息登记
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(405, 436);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.lblisfull);
            this.Controls.Add(this.cmbisfull);
            this.Controls.Add(this.txtzhang);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndengji);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.cmbempity);
            this.Controls.Add(this.cmbinroom);
            this.Controls.Add(this.cmbkind);
            this.Controls.Add(this.cmbfloor);
            this.Controls.Add(this.lblempty);
            this.Controls.Add(this.lblinroom);
            this.Controls.Add(this.lblAssitant);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblcode);
            this.Controls.Add(this.lblkind);
            this.Controls.Add(this.lblfloor);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "宿舍信息登记";
            this.Text = "宿舍信息登记";
            this.Load += new System.EventHandler(this.宿舍信息登记_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtzhang;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndengji;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.ComboBox cmbempity;
        private System.Windows.Forms.ComboBox cmbinroom;
        private System.Windows.Forms.ComboBox cmbkind;
        private System.Windows.Forms.ComboBox cmbfloor;
        private System.Windows.Forms.Label lblempty;
        private System.Windows.Forms.Label lblinroom;
        private System.Windows.Forms.Label lblAssitant;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label lblkind;
        private System.Windows.Forms.Label lblfloor;
        private System.Windows.Forms.ComboBox cmbisfull;
        private System.Windows.Forms.Label lblisfull;
        private System.Windows.Forms.TextBox txtcode;
    }
}