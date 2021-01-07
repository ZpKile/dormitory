﻿using System;
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
    public partial class 宿舍信息查询 : Form
    {
        SqlConnection objSqlConnection;
        SqlDataAdapter objSqlAdapter;
       DataSet  sufeidataset1;
       
        public 宿舍信息查询()
        {
            InitializeComponent();
        }
        private void fool()
        {
            try
            {

                objSqlConnection.Open();//打开连接
                string mysql = "select * from roomdorm where 楼层号='" + this.txtName.Text.ToString() + "'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new DataSet();
                objSqlAdapter.Fill(sufeidataset1, "roomdorm");
                dgMyGrid.DataSource = sufeidataset1.Tables["roomdorm"];//把得到的值给DataGrid
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message );
            }
            finally
            {
                objSqlConnection.Close();

            }
        }
        private void roomcode()
        {
            try
            {

                objSqlConnection.Open();//打开连接
                string mysql = "select * from roomdorm where 宿舍号='" + this.txtName.Text.ToString()+"'";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new DataSet();
                objSqlAdapter.Fill(sufeidataset1, "roomdorm");
                dgMyGrid.DataSource = sufeidataset1.Tables["roomdorm"];//把得到的值给DataGrid
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message );
            }
            finally
            {
                objSqlConnection.Close();

            }
        }
        //private void roomtype()
        //{
        //    try
        //    {

        //        objSqlConnection.Open();//打开连接
        //        string mysql = "select * from roomdorm where 楼层类型='" + this.comblist.Text.ToString() + "'";
        //        objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
        //        sufeidataset1 = new DataSet();
        //        objSqlAdapter.Fill(sufeidataset1, "roomdorm");
        //        dgMyGrid.DataSource = sufeidataset1.Tables["roomdorm"];//把得到的值给DataGrid
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show(ee.Message);
        //    }
        //    finally
        //    {
        //        objSqlConnection.Close();

        //    }
        //}
        //private void roomkind()
        //{
        //    try
        //    {

        //        objSqlConnection.Open();//打开连接
        //        string mysql = "select * from roomdorm where 楼层类别='"+this.comblist .Text .ToString()+ "'";
        //        objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
        //        sufeidataset1 = new DataSet();
        //        objSqlAdapter.Fill(sufeidataset1, "roomdorm");
        //        dgMyGrid.DataSource = sufeidataset1.Tables["roomdorm"];//把得到的值给DataGrid
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show(ee.Message );
        //    }
        //    finally
        //    {
        //        objSqlConnection.Close();

        //    }
        //}
        private void btncaxun_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listconbox.SelectedIndex.Equals(0))
                {
                    this.fool();//调用该方法查询数据按楼层号
                }
                else if (this.listconbox.SelectedIndex.Equals(1))
                {
                    this.roomcode();//调用该方法查询数据宿舍号
                }
                //else if (this.listconbox.SelectedIndex.Equals(2))
                //{
                //    this.roomtype();//调用该方法查询数据按类型
                //}
                //else if (this.listconbox.SelectedIndex.Equals(3))
                //{
                //    this.roomkind();//调用该方法查询数据按类别
                //}



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
                    this.comblist.Visible = false;
                    this.txtName.Visible = true;
                   
                    this.lblName.Text = "楼层号：";
                   
                }
                else if (this.listconbox.SelectedIndex.Equals(1))
                {
                    this.comblist.Visible = false;
                    this.txtName.Visible = true;
                    this.lblName.Text = "宿舍号：";
                   
                }
                //else if (this.listconbox.SelectedIndex.Equals(2))
                //{
                //    this.comblist.Visible = true;
                //    this.txtName.Visible = false;
                //    this.lblName.Text = "楼层类型：";
                //    this.comblist.Items.Clear();
                //    this.comblist.Items.Add("四人间");
                //    this.comblist.Items.Add("六人间");
                //    this.comblist.Items.Add("八人间");
                   
                   
                //}
                //else if (this.listconbox.SelectedIndex.Equals(3))
                //{
                //    this.comblist.Visible = true;
                //    this.txtName.Visible = false;
                //    this.comblist.Items.Clear();
                //    this.lblName.Text = "楼层类别：";
                //    this.comblist.Items.Add("男生宿舍");
                //    this.comblist.Items.Add("女生宿舍");
                   
                   
                   
                //}


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void 宿舍信息查询_Load(object sender, EventArgs e)
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
            this.listconbox.Items.Add("宿舍号");
            //this.listconbox.Items.Add("楼层类型");
            //this.listconbox.Items.Add("楼层类别");
            
        }

        private void btnfull_Click(object sender, EventArgs e)
        {
            try
            {

                objSqlConnection.Open();//打开连接
                string mysql = "select * from roomdorm ";
                objSqlAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                sufeidataset1 = new DataSet();
                objSqlAdapter.Fill(sufeidataset1, "roomdorm");
                dgMyGrid.DataSource = sufeidataset1.Tables["roomdorm"];//把得到的值给DataGrid
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}