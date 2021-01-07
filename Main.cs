using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 宿舍管理系统
{
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
        }
           private void fdfToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void 人员查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                迁出查询 name = new 迁出查询();
                name.MdiParent = this;
                 name.Show();
        }

       

        private void 新增ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            校外人员登记表 xiao = new 校外人员登记表();
            xiao.MdiParent = this;
            xiao.Show();
        }

        private void 新增ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            校内人员登记 xiao = new 校内人员登记();
            xiao.MdiParent = this;
            xiao.Show();
        }

        private void 新增ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            studentnew student = new studentnew();
            student.MdiParent = this;
            student.Show();
        }

        private void 新增ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            水电收费登记 qian = new 水电收费登记();
            qian.MdiParent = this;
            qian.Show();
        }

        private void 新增ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            studentnew student = new studentnew();
            student.MdiParent = this;
            student.Show();
        }

        private void 管理ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            人员管理 renyuanguanli = new 人员管理();
            renyuanguanli.MdiParent = this;
            renyuanguanli.Show();
        }

        private void 管理ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            迁出人员管理 exit = new 迁出人员管理();
            exit.MdiParent = this;
            exit.Show();
        }

       

        private void 管理ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            校外人员管理 outschool = new 校外人员管理();
            outschool.MdiParent = this;
            outschool.Show();
        }

        private void 管理ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            校内人员管理 inschool = new 校内人员管理();
            inschool.MdiParent = this;
            inschool.Show();
        }

        private void 校内ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            校内人员来访查询 insc = new 校内人员来访查询();
            insc.MdiParent = this;
            insc.Show();
        }

        private void 校外ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            校外人员来访查询 outsc = new 校外人员来访查询();
            outsc.MdiParent = this;
            outsc.Show();
        }

        private void 迁出记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            水电收费信息查询 leve = new 水电收费信息查询();
            leve.MdiParent = this;
            leve.Show();
           
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            宿舍信息登记 room = new 宿舍信息登记();
            room.MdiParent = this;
            room.Show();
        }

        private void 管理ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            宿舍信息管理 r = new 宿舍信息管理();
            r.MdiParent = this;
            r.Show();
        }

        private void fdfdToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            宿舍信息查询 roo = new 宿舍信息查询();
            roo.MdiParent = this;
            roo.Show();
        }

        private void 添加查询记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            卫生检查登记 score = new 卫生检查登记();
            score.MdiParent = this;
            score.Show();
        }

        private void 管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            卫生检查管理 scoreguanli = new 卫生检查管理();
            scoreguanli.MdiParent = this;
            scoreguanli.Show();
        }

        private void 扣分查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            卫生检查查询 koufen = new 卫生检查查询();
            koufen.MdiParent = this;
            koufen.Show();
        }

        private void 每日一记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            房屋报修添加 zhiban = new 房屋报修添加();
            zhiban.MdiParent = this;
            zhiban.Show();
        }

        private void 管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            房屋报修管理 zhibanguanli = new 房屋报修管理();
            zhibanguanli.MdiParent = this;
            zhibanguanli.Show();
        }

        private void 值班记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            房屋报修查询 zhibanlike = new 房屋报修查询();
            zhibanlike.MdiParent = this;
            zhibanlike.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
            用户登录 user = new 用户登录();
            user.ShowDialog();
            if (user.F == true)
            {
                menuStrip1.Enabled = true;
            }
            else
            {
                menuStrip1.Enabled = false;
            }
        }

     private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改密码 password = new 修改密码();
            password.MdiParent = this;
            password.Show();
        }

        private void fdfdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新生入宿ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fdfdfToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}