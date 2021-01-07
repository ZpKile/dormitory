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
    public partial class 校内人员来访查询 : Form
    {
        public 校内人员来访查询()
        {
            InitializeComponent();
        }
        SqlConnection objSqlConnection;
        SqlDataAdapter objSqlAdapter;
        sufeiDataSet4 sufeidataset1;
       
        private void name()//执行按姓名查询的方法
        {
            try
            {
                objSqlConnection.Open();//打开连接
                string mysql = "select * from Schoolin where 姓名='" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new sufeiDataSet4 ();
                objSqlAdapter.Fill(sufeidataset1, "Schoolin");
                dgMyGrid.DataSource = sufeidataset1.Tables["Schoolin"];//把得到的值给DataGrid
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void room()//执行按宿舍号查询的方法
        {
            try
            {

                objSqlConnection.Open();//打开连接
                string mysql = "select * from Schoolin where 被访学生宿舍号='" + this.txtName.Text.ToString()+"'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new sufeiDataSet4 ();
                objSqlAdapter.Fill(sufeidataset1, "Schoolin");
                dgMyGrid.DataSource = sufeidataset1.Tables["Schoolin"];//把得到的值给DataGrid
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message+"只能是整数");
            }
            finally
            {
                objSqlConnection.Close();

            }
        }
        private void roomtime()//执行按入宿时间查询的方法
        {
            try
            {

                objSqlConnection.Open();//打开连接
                string mysql = "select * from Schoolin where 来访时间='" + this.cmbtime.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new sufeiDataSet4();
                objSqlAdapter.Fill(sufeidataset1, "Schoolin");
                dgMyGrid.DataSource = sufeidataset1.Tables["Schoolin"];//把得到的值给DataGrid
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                objSqlConnection.Close();

            }
        }
        private void listconbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.listconbox.SelectedIndex.Equals(0))
                {
                    this.cmbtime.Visible = false;
                    this.txtName.Visible = true;
                    this.lblName.Text = "被访人姓名：";
                    //this.name();//调用该方法查询数据按姓名
                }
                else if (this.listconbox.SelectedIndex.Equals(2))
                {
                    this.cmbtime.Visible = false;
                    this.txtName.Visible = true;
                    this.lblName.Text = "学生宿舍号：";
                    //this.room();//调用该方法查询数据宿舍号
                }
                else if (this.listconbox.SelectedIndex.Equals(1))
                {
                    this.lblName.Text = "来访时间：";
                    this.txtName.Visible = false;
                    this.cmbtime.Visible = true;
                    //this.roomtime();//调用该方法查询数据按时间
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void btncaxun_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listconbox.SelectedIndex.Equals(0))
                {
                    this.name();//调用该方法查询数据按登记人姓名
                }
                else if (this.listconbox.SelectedIndex.Equals(2))
                {
                    this.room();//调用该方法查询数据宿舍号
                }
                else if (this.listconbox.SelectedIndex.Equals(1))
                {
                    this.roomtime();//调用该方法查询数据按迁出时间
                }



            }
            catch (Exception)
            {
                MessageBox.Show("请选择查询的方式");
            }
        }

        private void btnfull_Click(object sender, EventArgs e)
        {
            try
            {
                objSqlConnection.Open();//打开连接
                string mysql = "select * from Schoolin";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new sufeiDataSet4();
                objSqlAdapter.Fill(sufeidataset1, "Schoolin");
                dgMyGrid.DataSource = sufeidataset1.Tables["Schoolin"];//把得到的值给DataGrid        
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void 校内人员来访查询_Load(object sender, EventArgs e)
        {
            try
            {
                objSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "没有可有的数据库或连接不成功，请自行检测！！！");
            }
            //给listcombox值           
            this.listconbox.Items.Add("按登记人姓名");
            this.listconbox.Items.Add("按迁出时间");
            this.listconbox.Items.Add("按宿舍号");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}