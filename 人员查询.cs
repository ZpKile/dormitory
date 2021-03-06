﻿using System;
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
    public partial class 迁出查询 : Form
    {
        /**
         * 2008年4月9日中午
         * 苏飞
         * */

        public 迁出查询()
        {
            InitializeComponent();
        }
        SqlConnection objSqlConnection;
        DataSet objDataSet;
        SqlDataAdapter objSqlAdapter;
       private  void name()//执行按姓名查询的方法
        {
            try
            {
                objSqlConnection.Open();//打开连接
                string mysql = "select * from student where 姓名=" + "'" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                objDataSet = new DataSet();
                objSqlAdapter.Fill(objDataSet, "student");
                dgMyGrid.DataSource = objDataSet.Tables ["student"];//把得到的值给DataGrid
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
                objDataSet = new DataSet();
                objSqlAdapter.Fill(objDataSet, "student");
                dgMyGrid.DataSource = objDataSet.Tables["student"];//把得到的值给DataGrid
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
                objDataSet = new DataSet();
                objSqlAdapter.Fill(objDataSet, "student");
                dgMyGrid.DataSource = objDataSet.Tables["student"];//把得到的值给DataGrid
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
        private void roomnumber()//执行按入宿时间查询的方法
        {
            try
            {

                objSqlConnection.Open();//打开连接
                string mysql = "select * from student where 楼层号=" + "'" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                objDataSet = new DataSet();
                objSqlAdapter.Fill(objDataSet, "student");
                dgMyGrid.DataSource = objDataSet.Tables["student"];//把得到的值给DataGrid
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
        private void code() //执行按学号查询的方法
        {
            try
            {

                objSqlConnection.Open();//打开连接
                string mysql = "select * from student where 学号=" + "'" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                objDataSet = new DataSet();
                objSqlAdapter.Fill(objDataSet, "student");
                dgMyGrid.DataSource = objDataSet.Tables["student"];//把得到的值给DataGrid
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


        private void 姓名查询_Load(object sender, EventArgs e)
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
         
            this.listconbox .Items.Add ("按姓名");
            this.listconbox .Items.Add ("按入宿时间");
            this.listconbox .Items.Add ("按楼层");
            this.listconbox .Items.Add ("按宿舍号");
            this.listconbox.Items.Add("按学号");
            
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void btncaxun_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listconbox.SelectedIndex.Equals(0))
                {
                    this.name();//调用该方法查询数据按姓名
                }
                else  if (this.listconbox.SelectedIndex.Equals(3))
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
                    this.code();//调用该方法查询数据按楼层
                }
                        
            }catch (Exception)
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
                objDataSet = new DataSet();
                objSqlAdapter.Fill(objDataSet, "student");
                dgMyGrid.DataSource = objDataSet.Tables["student"];//把得到的值给DataGrid
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
                    this.cmbtime.Visible =false ;
                    this.txtName.Visible = true;
                    this.lblName.Text = "请输入要查询的学生姓名：";
                    //this.name();//调用该方法查询数据按姓名
                }
                else if (this.listconbox.SelectedIndex.Equals(3))
                {
                    this.cmbtime.Visible = false;
                    this.txtName.Visible  = true;
                    this.lblName.Text = "请输入要查询的学生宿舍号：";
                    //this.room();//调用该方法查询数据宿舍号
                }
                else if (this.listconbox.SelectedIndex.Equals(1))
                {
                    this.lblName.Text = "请输入要查询的学生入宿时间：";
                    this.txtName .Visible = false;
                    this.cmbtime.Visible = true;
                    //this.roomtime();//调用该方法查询数据按入宿时间
                }
                else if (this.listconbox.SelectedIndex.Equals(2))
                {
                    this.cmbtime.Visible = false;
                    this.txtName.Visible = true;
                    this.lblName.Text = "请输入要查询的学生所在楼层：";
                    //this.roomnumber();//调用该方法查询数据按楼层
                }
                else if (this.listconbox.SelectedIndex.Equals(4))
                {
                    this.cmbtime.Visible = false;
                    this.txtName.Visible = true;
                    this.lblName.Text = "请输入要查询的学生学号：";
                    //this.roomnumber();//调用该方法查询数据按楼层
                }



            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString ());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void dgMyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}