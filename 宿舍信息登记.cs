using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
// Downloads By http://www.veryhuo.com
namespace 宿舍管理系统
{
    public partial class 宿舍信息登记 : Form
    {
        DataSet dataset = null;
        SqlConnection con = null;
        SqlDataAdapter objsqlDataAdapter = null;
        public 宿舍信息登记()
        {
            InitializeComponent();
        }

        private void btndengji_Click(object sender, EventArgs e)
        {
            //宿舍登记
            try
            {      
                con.Open();
                string mysql = "INSERT INTO roomdorm(楼层号, 宿舍号, 楼层类型, 楼层类别, 宿舍长, 已住人数, 空位, 是否住满)VALUES ('"+this.cmbfloor .Text .ToString ()+"', '"+
                    this.txtcode .Text .ToString ()+"', '"+this.cmbkind .Text.ToString ()+"', '"+this.cmbtype.Text .ToString ()+"', '"+this.txtzhang.Text .ToString ()
                    +"', "+this.cmbinroom .Text .ToString ()+", "+this.cmbempity.Text .ToString ()+", '"+this.cmbisfull .Text .ToString ()+"') ";   
                objsqlDataAdapter = new SqlDataAdapter(mysql, con);
                dataset = new DataSet();
                objsqlDataAdapter.Fill(dataset, "roomdorm");
                con.Close();
                MessageBox.Show("登记成功", "提示信息");
              
            }
            catch (Exception ee)
            {
                MessageBox.Show("请先查看是否有重复：失败原因是："+ee.Message);
              
            }
            finally
            {
                con.Close();
            }      
        }

        private void 宿舍信息登记_Load(object sender, EventArgs e)
        {
            try
            {
               con = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "没有可有的数据库或连接不成功，请自行检测！！！");
            }
            for (int i = 1; i <= 10; i++)
            {
                this.cmbfloor.Items.Add(i);
            }
            this.cmbkind.Items.Add("男生宿舍");
            this.cmbkind.Items.Add("女生宿舍");
            this.cmbtype.Items.Add("四人间");
            this.cmbtype.Items.Add("六人间");
            this.cmbtype.Items.Add("八人间");
            for (int i = 1; i <= 8; i++)
            {
                this.cmbinroom.Items.Add(i);
                this.cmbempity.Items.Add(i);
            }
            this.cmbisfull.Items.Add("是");
            this.cmbisfull.Items.Add("否");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}