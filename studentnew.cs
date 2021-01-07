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
    public partial class studentnew : Form
    {

        DataSet dataset = null;
        SqlConnection con = null;
        SqlDataAdapter objsqlDataAdapter;
        SqlCommand com;
        SqlTransaction transaction;
        string strsex="";
        public studentnew()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//向学生表中插入记录
        {

            try
            {
                con.Open();
                string mysql = "select * from roomdorm where 宿舍号='"+this.roomcode .Text .ToString ()+"'";
                objsqlDataAdapter = new SqlDataAdapter(mysql, con);
                dataset = new DataSet();
                objsqlDataAdapter.Fill(dataset, "roomdorm");
                con.Close();
                if (this.cmbsex.Text.ToString() == "男")
                {
                    strsex = "男生宿舍";
                }
                else
                {
                    strsex = "女生宿舍";
                }
               if (dataset .Tables["roomdorm"].Rows [0][7].ToString ()=="否")
               {
                   if (dataset.Tables["roomdorm"].Rows[0][3].ToString () != strsex)
                   {
                       MessageBox.Show(this.txtname .Text .ToString ()+"本宿舍和你的性别不合，不好意思你不能住在这里，请选择别的宿舍！！！");
                       return;
                   }
                   try
                   {
                       con.Open();
                       transaction = con.BeginTransaction();
                       com = new SqlCommand();
                       com.Connection = con;
                       com.Transaction = transaction;

                       com.CommandText = "INSERT INTO student(学号, 楼层号, 宿舍号, 姓名, 性别, 年龄, 系别, 班级, 年级, 辅导员, 年制, 联系电话, 入宿时间, 家庭详细信息)VALUES ('"
                           + this.IDtxt.Text.ToString() + "', '" + this.cmblouceng.Text.ToString() + "', '" + this.roomcode.Text.ToString() + "', '" + this.txtname.Text.ToString() + "', '" + this.cmbsex.Text.ToString() + "'," + this.cmbage.Text.ToString() + ", '" +
                                                                  this.cmbxibie.Text.ToString() + "', '" + this.cmbclass.Text.ToString() + "', '" + this.txtyeargrid.Text.ToString() + "', '" + this.txtteacher.Text.ToString() + "'," + this.cmbgriad.Text.ToString() + ", '" +
                                                                  this.txttell.Text.ToString() + "', '" + this.dateTimeinroomtime.Text.ToString() + "', '" + this.txtText.Text.ToString() + "') ";
                       com.ExecuteNonQuery();
                       
                       MessageBox.Show("注册成功", "提示信息");
                       //向宿舍表中添加记录

                       com.CommandText = "update roomdorm set 已住人数=已住人数+1, 空位=空位-1 where 宿舍号='" + this.roomcode.Text.ToString() + "'";
                       com.ExecuteNonQuery();
                      
                       //w修改roomdorm表
                       com.CommandText = "update roomdorm set 是否住满='是'  where 空位=0 and 宿舍号='" + this.roomcode.Text.ToString() + "'";
                       com.ExecuteNonQuery();
                       transaction.Commit();
                       con.Close();
                       com.Dispose();
                       MessageBox.Show("宿舍信息以更新!!!"+this.txtname .Text .ToString ()+"以在"+this.roomcode .Text .ToString ()+"入住", "提示信息");
                   }
                   catch (Exception ee)
                   {
                       MessageBox.Show(ee.Message);
                       transaction.Rollback();
                   }
                   finally
                   {
                       con.Close();
                       com.Dispose();
                   }
                   

               }else 
               {
                   MessageBox.Show (this.txtname .Text .ToString ()+"本宿舍人数已满或不能再住人请您选择别的宿舍，谢谢合作！！！");
               }

            }
            catch (Exception ee)
            {
                MessageBox.Show("宿舍信息不存在，请确认你选择的宿舍是现有的宿舍，可到宿舍信息表中去查找已有的宿舍！！");
            }
            finally
            {
                con.Close();
            }
        }

        private void studentnew_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "没有可有的数据库或连接不成功，请自行检测！！！");
            }
            this.cmbage.Items.Clear();
            for (int i = 1; i <= 100; i++)//年龄
            {
                this.cmbage.Items.Add(i);
            }
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}