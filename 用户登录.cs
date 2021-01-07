using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace 宿舍管理系统
{
    public partial class 用户登录 : Form
    {
        public 用户登录()
        {
            InitializeComponent();
        }
        public Boolean F = false;
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 用户登录_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sufeiDataSet6.UserInfo”中。您可以根据需要移动或移除它。
            try
            {
                this.userInfoTableAdapter.Fill(this.sufeiDataSet6.UserInfo);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "没有可有的数据库或连接不成功，请自行检测！！！");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
                con.Open();
                sufeiDataSet6 dataset = new sufeiDataSet6();
                string strsql = "select * from UserInfo where UserName='" + this.comname.Text.ToString() + "'";
                SqlDataAdapter objdataadpater = new SqlDataAdapter(strsql, con);
                objdataadpater.Fill(dataset, "UserInfo");
                if (dataset.Tables["UserInfo"].Rows[0][1].ToString() == this.txtPassword.Text.ToString())
                {
                    F = true;
                    this.Close();
                }
                else
                {
                    F = false;
                    MessageBox.Show("用户名和密码不正确！！！");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message .ToString ());
                F = false;
            }
        }

      
    }
}