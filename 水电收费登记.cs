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
    public partial class 水电收费登记 : Form
    {
        DataSet dataset = null;
        SqlConnection con = null;
        SqlDataAdapter objsqlDataAdapter;
        SqlCommand com;
        SqlTransaction transaction;
        public 水电收费登记()
        {
            InitializeComponent();
        }

        private void txtshiyou_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndengji_Click(object sender, EventArgs e)
        {

          
            try
            {
                con.Open();
                objsqlDataAdapter = new SqlDataAdapter("select * from student where 学号='" + this.txtID.Text.ToString() + "'", con);
                dataset = new DataSet();
                objsqlDataAdapter.Fill(dataset, "student");
                con.Close();
                if (dataset.Tables["student"].Rows[0][0].ToString() != "")//根据学号来判断该生是否存在
                {
                    if (dataset.Tables["student"].Rows[0][2].ToString() ==this.txtbroomnumber.Text.ToString())
                    {



                        // MessageBox.Show("存在学生" + dataset.Tables["student"].Rows[0][3].ToString() + "该生在" + dataset.Tables["student"].Rows[0][2].ToString() + "宿舍！！！", "提示信息");
                        //当存在这个学生时才能迁出，否则没有意义。
                        try
                        {
                            //插入到levelogion表中
                            try
                            {

                               
                                con.Open();
                                 transaction = con.BeginTransaction();
                                com = new SqlCommand();
                                com.Connection = con;
                                com.Transaction = transaction;
                                com.CommandText = "INSERT INTO levelogion(学号, 姓名, 性别, 宿舍号, 迁出时间, 迁出事由)VALUES ('" + this.txtID.Text.ToString() + "', '" + this.txtname.Text.ToString() + "', '" + this.txtsex.Text.ToString() + "','" +
                                this.txtbroomnumber.Text.ToString() + "', '" + this.dateTime.Text.ToString() + "', '" + this.txtshiyou.Text.ToString() + "')";
                                com.ExecuteNonQuery();

                                //将student表中关于本学生的信息删除

                                com.CommandText = "DELETE FROM student WHERE (学号 = '" + this.txtID.Text.ToString() + "')";
                                
                                com.ExecuteNonQuery();


                               
                                //向宿舍表中添加记录

                                com.CommandText = "update roomdorm set 已住人数=已住人数-1, 空位=空位+1 where 宿舍号='" + this.txtbroomnumber.Text.ToString() + "'";
                                
                                com.ExecuteNonQuery();


                                //w修改roomdorm表

                                com.CommandText = "update roomdorm set 是否住满='否'  where 空位!=0 and 宿舍号='" + this.txtbroomnumber.Text.ToString() + "'";
                                
                                com.ExecuteNonQuery();

                                transaction.Commit();
                                com.Dispose();
                                con.Close();
                                MessageBox.Show("登记成功 \n \t\t该生的信息以从student表中移除不在是本宿舍楼的一员！！！", "提示信息");
                            }
                            catch (SqlException ee)
                            {
                                MessageBox.Show("插入到levelogion表中时出错\n原因是：" + ee.Message.ToString());
                                transaction.Rollback();

                            }
                            finally
                            {
                                con.Close();
                                com.Dispose();
                            }
                           
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
                        MessageBox.Show("宿舍号不对");
                    }

                }
                else
                {
                    MessageBox.Show("学生不存在", "提示信息");
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("学生不存在", "提示信息");
            }
            finally
            {
                con.Close();
                
            }



          
        }

        private void btnnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 迁出登记_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "没有可有的数据库或连接不成功，请自行检测！！！");
            }
            this.txtsex.Items.Add("男");
            this.txtsex.Items.Add("女");
        }
    }
}