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
    public partial class 校外人员登记表 : Form
    {
        DataSet dataset = null;
        SqlConnection con = null;
        SqlDataAdapter objsqlDataAdapter;
        public 校外人员登记表()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndengji_Click(object sender, EventArgs e)//为外来人员来访登记
        {
            //验证学生是否存在
            try
            {
                con.Open();
                objsqlDataAdapter = new SqlDataAdapter("select * from student where 姓名='" + this.txtbname.Text.ToString() + "'", con);
                dataset = new DataSet();
                objsqlDataAdapter.Fill(dataset, "student");
                con.Close();
                if (dataset.Tables["student"].Rows[0][3].ToString() != "")
                {
                   
                    //登记学生    

                    try
                    {
                        con.Open();
                        string mysql = "INSERT INTO SchoolOutlogion(姓名, 性别, 被访学生姓名, 被访学生宿舍号, 来访时间,来访事由)VALUES ('" + this.txtbname.Text.ToString() + "', '" + this.txtsex.Text.ToString() + "', '" +
                        this.txtbname.Text.ToString() + "','" + this.txtbroomnumber.Text.ToString() + "', '" + this.dateTime.Text.ToString() + "','" + this.txtshiyou.Text.ToString() + "')";
                        objsqlDataAdapter = new SqlDataAdapter(mysql, con);
                        dataset = new DataSet();
                        objsqlDataAdapter.Fill(new DataSet(), "SchoolOutlogion");
                        con.Close();
                        MessageBox.Show("登记成功", "提示信息");
                        MessageBox.Show("存在学生" + dataset.Tables["student"].Rows[0][3].ToString() + "该生在" + dataset.Tables["student"].Rows[0][2].ToString() + "宿舍！！！", "提示信息");
                        return;
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                       
                    }
                    finally
                    {
                        con.Close();

                    }

                 
                }
                else
                {
                    MessageBox.Show("不存在学生" + this.txtbname.Text.ToString() + "无法登记", "提示信息");
                    
                }

                //DataView dataview = new DataView(dataset.Tables["student"]);
                //dataview.Sort = "学号 DESC";
                //dataview.RowFilter = "入宿时间='20060606'";
                //DataGrid1.DataSource = dataview;
                //DataGrid1.DataBind(); 
            }
            catch (Exception )
            {
                MessageBox.Show("不存在学生" + this.txtbname.Text.ToString() + "无法登记", "提示信息");
              
            }
            finally
            {
                con.Close();

            }



       
        }

        private void btnstudenthome_Click(object sender, EventArgs e)//验证学生是否存在
        {
            try
            {
                con.Open();
                objsqlDataAdapter = new SqlDataAdapter("select * from student where 姓名='" + this.txtbname.Text.ToString() + "'", con);
                dataset = new DataSet();
                objsqlDataAdapter.Fill(dataset, "student");
                con.Close();
                if (dataset.Tables["student"].Rows[0][3].ToString() != "")
                {
                    MessageBox.Show("存在学生" + dataset.Tables["student"].Rows[0][3].ToString() + "该生在" + dataset.Tables["student"].Rows[0][2].ToString() + "宿舍！！！", "提示信息");

                    return;
                }
                else
                {
                    MessageBox.Show("不存在学生" + this.txtbname.Text.ToString() + "无法登记", "提示信息");
                    return;
                }
             
                //DataView dataview = new DataView(dataset.Tables["student"]);
                //dataview.Sort = "学号 DESC";
                //dataview.RowFilter = "入宿时间='20060606'";
                //DataGrid1.DataSource = dataview;
                //DataGrid1.DataBind(); 
            }
            catch (Exception )
            {
                MessageBox.Show( "不存在学生" + this.txtbname.Text.ToString()+"无法登记", "提示信息");
                return;
            }
            finally
            {
                con.Close();

            }
          
        }

        private void lblsex_Click(object sender, EventArgs e)
        {

        }

        private void 校外人员登记表_Load(object sender, EventArgs e)
        {
            try
            {
               con = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "没有可有的数据库或连接不成功，请自行检测！！！");
            }
        }
    }
}