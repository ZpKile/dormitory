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
    public partial class 校内人员管理 : Form
    {
        SqlConnection objSqlConnection;
        SqlDataAdapter objSqlAdapter;
        sufeiDataSet4 sufeidataset1;
        public 校内人员管理()
        {
            InitializeComponent();
        }
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
        private void 校内人员管理_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sufeiDataSet4.Schoolin”中。您可以根据需要移动或移除它。
            //this.schoolinTableAdapter.Fill(this.sufeiDataSet4.Schoolin);
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

        private void cmbtime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.schoolinTableAdapter.Fill(this.sufeidataset1.Schoolin);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "！！！请先加载数据");
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
                    if (this.sufeidataset1 != null)
                    {

                        this.dgMyGrid.Rows.RemoveAt(dgMyGrid.CurrentRow.Index);
                        this.schoolinTableAdapter.Update(this.sufeidataset1.Schoolin);
                        MessageBox.Show("删除成功");
                        this.schoolinTableAdapter.Fill(this.sufeidataset1.Schoolin);
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

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.schoolinTableAdapter.Update(this.sufeidataset1.Schoolin);
                MessageBox.Show("更新成功");
                this.schoolinTableAdapter.Fill(this.sufeidataset1.Schoolin);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "类型不正确！！！");
            }
        }

        private void dgMyGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("类型不正确！！！");
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            校内人员登记 insch = new 校内人员登记();
            insch.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}