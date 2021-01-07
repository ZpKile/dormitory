using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace 宿舍管理系统
{
     
    public partial class 修改密码 : Form
    {
        SqlConnection objsqlconnction;
        SqlDataAdapter objdataadapter;
        DataSet dataset;
        public 修改密码()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                objsqlconnction = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
                objsqlconnction.Open();
                string strsql = "select * from UserInfo where  UserName='" + this.cmbUser.Text.ToString() + "'";
                objdataadapter = new SqlDataAdapter(strsql, objsqlconnction);
                dataset = new DataSet();
                objdataadapter.Fill(dataset, "UserInfo");
                objsqlconnction.Close();
                if (dataset.Tables["UserInfo"].Rows[0][1].ToString () == this.txtoldpassword.Text.ToString())
                {
                    if (this.txtEnterpassword.Text.ToString() == this.txtPassword.Text.ToString())
                    {
                        objsqlconnction.Open();
                        string strsq = "UPDATE UserInfo SET  Passord = '"+this.txtPassword.Text .ToString ()+"'  where  UserName='"+this.cmbUser .Text .ToString ()+"'";
                        objdataadapter = new SqlDataAdapter(strsq, objsqlconnction);
                        dataset = new DataSet();
                        objdataadapter.Fill(dataset, "UserInfo");
                        objsqlconnction.Close();
                        MessageBox.Show("成功修改密码，请牢记你的新密码！！！");
                    }
                    else
                    {
                        MessageBox.Show("两次输入的密码不一致！！！");
                    }

                }
                else
                {
                    MessageBox.Show("旧密码不正确！！！");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
            finally
            {
                objsqlconnction.Close();
            }
        }

        private void 修改密码_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: 这行代码将数据加载到表“sufeiDataSet9.UserInfo”中。您可以根据需要移动或移除它。
                this.userInfoTableAdapter.Fill(this.sufeiDataSet9.UserInfo);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message .ToString ()+"没有可有的数据库或连接不成功，请自行检测！！！");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}