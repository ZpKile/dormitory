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
    public partial class 房屋报修查询 : Form
    {
        public 房屋报修查询()
        {
            InitializeComponent();
        }
        SqlConnection objSqlConnection;
        SqlDataAdapter objSqlAdapter;
        DataSet sufeidataset1;

        private void roomfool()//执行按学号查询的方法
        {
            try
            {
                objSqlConnection.Open();//打开连接
                string mysql = "select * from onduty where 所在楼层=" + "'" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new DataSet();
                objSqlAdapter.Fill(sufeidataset1, "onduty");
                dgMyGrid.DataSource = sufeidataset1.Tables["onduty"];//把得到的值给DataGrid
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
        private void roomtime()//执行按学号查询的方法
        {
            try
            {
                objSqlConnection.Open();//打开连接
                string mysql = "select * from onduty where 值班时间=" + "'" + this.cmbtime.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new DataSet();
                objSqlAdapter.Fill(sufeidataset1, "onduty");
                dgMyGrid.DataSource = sufeidataset1.Tables["onduty"];//把得到的值给DataGrid
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
        private void roompeople()//执行按学号查询的方法
        {
            try
            {
                objSqlConnection.Open();//打开连接
                string mysql = "select * from onduty where 值班人=" + "'" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new DataSet();
                objSqlAdapter.Fill(sufeidataset1, "onduty");
                dgMyGrid.DataSource = sufeidataset1.Tables["onduty"];//把得到的值给DataGrid
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

        private void 值班记录查询_Load(object sender, EventArgs e)
        {
            try
            {
                objSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "没有可有的数据库或连接不成功，请自行检测！！！");
            }
            this.listconbox.Items.Add("楼层号");
            this.listconbox.Items.Add("值班时间");
            this.listconbox.Items.Add("值班人");
        }

        private void btncaxun_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listconbox.SelectedIndex.Equals(0))
                {
                    this.roomfool();
                }
                else if (this.listconbox.SelectedIndex.Equals(1))
                {
                    this.roomtime();
                }
                else if (this.listconbox.SelectedIndex.Equals(2))
                {
                    this.roompeople();
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
                string mysql = "select * from onduty";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new DataSet();
                objSqlAdapter.Fill(sufeidataset1, "onduty");
                dgMyGrid.DataSource = sufeidataset1.Tables["onduty"];//把得到的值给DataGrid
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
                    this.lblName.Text = "楼层号：";

                }

                else if (this.listconbox.SelectedIndex.Equals(1))
                {
                    this.lblName.Text = "值班时间时间：";
                    this.txtName.Visible = false;
                    this.cmbtime.Visible = true;

                }
                else if (this.listconbox.SelectedIndex.Equals(2))
                {
                    this.cmbtime.Visible = false;
                    this.txtName.Visible = true;
                    this.lblName.Text = "值班人：";

                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}