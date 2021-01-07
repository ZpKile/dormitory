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
    public partial class 卫生检查登记 : Form
    {
        public 卫生检查登记()
        {
            InitializeComponent();
        }

        private void 扣分登记_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sufeiDataSet5.roomdorm”中。您可以根据需要移动或移除它。
            try
            {
                this.roomdormTableAdapter.Fill(this.sufeiDataSet5.roomdorm);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "没有可有的数据库或连接不成功，请自行检测！！！");
            }
            this.cmbScore.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                this.cmbScore.Items.Add(i);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
                objSqlConnection.Open();
                string mysql = "INSERT INTO centtable(楼层号, 宿舍号, 扣分值, 检查人, 扣分时间, 扣分项)VALUES ('" + this.cmbFlor.Text.ToString() + "', '" +
                this.roomcode.Text.ToString() + "'," + this.cmbScore.Text.ToString() + ", '" + this.txtCheck.Text.ToString() + "', '" + this.dateTimePicker1.Text.ToString() + "', '" + this.txtBecause.Text.ToString() + "') ";
                DataSet dataset = new DataSet();
                SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                objSqlDataAdapter.Fill(dataset, "centtable");
                MessageBox.Show("登记成功");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message .ToString ());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}