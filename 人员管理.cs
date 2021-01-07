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
    public partial class 人员管理 : Form
    {
        public 人员管理()
        {
            InitializeComponent();
        }


        
         SqlConnection objSqlConnection;
        //sufeiDataSet sufeiDataSet = new sufeiDataSet();
        SqlDataAdapter objSqlAdapter;
      
        private void studentcode()//执行按学号查询的方法
        {
            try
            {
                objSqlConnection.Open();//打开连接
                string mysql = "select * from student where 学号=" + "'" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeiDataSet = new sufeiDataSet();
                objSqlAdapter.Fill(sufeiDataSet, "student");
                dgMyGrid.DataSource = sufeiDataSet.Tables["student"];//把得到的值给DataGrid
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
       private  void name()//执行按姓名查询的方法
        {
            try
            {
                objSqlConnection.Open();//打开连接
                string mysql = "select * from student where 姓名=" + "'" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeiDataSet = new sufeiDataSet();
                objSqlAdapter.Fill(sufeiDataSet, "student");
                dgMyGrid.DataSource = sufeiDataSet.Tables["student"];//把得到的值给DataGrid
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

        private  void room()//执行按宿舍号查询的方法
        {
            try
            {
               
                objSqlConnection.Open();//打开连接
                string mysql = "select * from student where 宿舍号=" + "'" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeiDataSet = new sufeiDataSet();
                objSqlAdapter.Fill(sufeiDataSet, "student");
                dgMyGrid.DataSource = sufeiDataSet.Tables["student"];//把得到的值给DataGrid
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
        private void roomtime()//执行按入宿时间查询的方法
        {
            try
            {

                objSqlConnection.Open();//打开连接
                string mysql = "select * from student where 入宿时间=" + "'" + this.cmbtime.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeiDataSet = new sufeiDataSet();
                objSqlAdapter.Fill(sufeiDataSet, "student");
                dgMyGrid.DataSource = sufeiDataSet.Tables["student"];//把得到的值给DataGrid
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
        private void roomnumber()//执行按楼层号查询的方法
        {
            try
            {

                objSqlConnection.Open();//打开连接
                string mysql = "select * from student where 楼层号=" + "'" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeiDataSet = new sufeiDataSet();
                objSqlAdapter.Fill(sufeiDataSet, "student");
                dgMyGrid.DataSource = sufeiDataSet.Tables["student"];//把得到的值给DataGrid
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


        private void btncaxun_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listconbox.SelectedIndex.Equals(0))
                {
                    this.name();//调用该方法查询数据按姓名
                }
                else if (this.listconbox.SelectedIndex.Equals(3))
                {
                    this.room();//调用该方法查询数据宿舍号
                }
                else if (this.listconbox.SelectedIndex.Equals(1))
                {
                    this.roomtime();//调用该方法查询数据按入宿时间
                }
                else if (this.listconbox.SelectedIndex.Equals(2))
                {
                    this.roomnumber();//调用该方法查询数据按楼层
                }
                else if (this.listconbox.SelectedIndex.Equals(4))
                {
                    this.studentcode();//调用该方法查询数据按学号
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
                string mysql = "select * from student";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeiDataSet = new sufeiDataSet();
                objSqlAdapter.Fill(sufeiDataSet, "student");
                dgMyGrid.DataSource = sufeiDataSet.Tables["student"];//把得到的值给DataGri               
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
                    this.lblName.Text = "学生姓名：";
                    //this.name();//调用该方法查询数据按姓名
                }
                else if (this.listconbox.SelectedIndex.Equals(3))
                {
                    this.cmbtime.Visible = false;
                    this.txtName.Visible = true;
                    this.lblName.Text = "学生宿舍号：";
                    //this.room();//调用该方法查询数据宿舍号
                }
                else if (this.listconbox.SelectedIndex.Equals(1))
                {
                    this.lblName.Text = "学生入宿时间：";
                    this.txtName.Visible = false;
                    this.cmbtime.Visible = true;
                    //this.roomtime();//调用该方法查询数据按入宿时间
                }
                else if (this.listconbox.SelectedIndex.Equals(2))
                {
                    this.cmbtime.Visible = false;
                    this.txtName.Visible = true;
                    this.lblName.Text = "学生所在楼层：";
                    //this.roomnumber();//调用该方法查询数据按楼层
                }
                else if (this.listconbox.SelectedIndex.Equals(4))
                {
                    this.cmbtime.Visible = false;
                    this.txtName.Visible = true;
                    this.lblName.Text = "学生的学号：";
                    //this.roomnumber();//调用该方法查询数据按学号
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void 人员管理_Load_1(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sufeiDataSet.student”中。您可以根据需要移动或移除它。
            //this.studentTableAdapter.Fill(this.sufeiDataSet.student);


            try
            {
                objSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "没有可用的数据库或连接不成功，请自行检测！！！");
            }
            //给listcombox值           
            this.listconbox.Items.Add("按姓名");
            this.listconbox.Items.Add("按入宿时间");
            this.listconbox.Items.Add("按楼层");
            this.listconbox.Items.Add("按宿舍号");
            this.listconbox.Items.Add("按学生学号");
        }

      
        private void dgMyGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("类型不正确！！！");
        }

        private void dgMyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        private void cmbtime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.Update(this.sufeiDataSet.student);
                MessageBox.Show("更新成功");

                this.studentTableAdapter.Fill(this.sufeiDataSet.student);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "类型不正确！！！"+"请验证是否存在这个宿舍信息");
            }
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlResult = MessageBox.Show(this, "要删除当前的记录吗？", "请确认",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.RightAlign);
                if (dlResult == DialogResult.Yes)
                {
                    if (this.sufeiDataSet != null)
                    {
                        this.dgMyGrid.Rows.RemoveAt(dgMyGrid.CurrentRow.Index);
                        this.studentTableAdapter.Update(this.sufeiDataSet.student);
                        MessageBox.Show("删除成功");
                        this.studentTableAdapter.Fill(this.sufeiDataSet.student);
                    }
                    else
                    {
                        MessageBox.Show("表中没有数据");
                    }
                }
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentnew newstudent = new studentnew();
            newstudent .Show ();         
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.Fill(this.sufeiDataSet.student);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "！！！！请先加载数据");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}