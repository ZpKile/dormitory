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
    public partial class 房屋报修添加 : Form
    {
        public 房屋报修添加()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["宿舍管理系统.Properties.Settings.sufeiConnectionString"].ConnectionString);
                objSqlConnection.Open();
                string mysql = "INSERT INTO onduty(值班时间,所在楼层, 值班人, 备注)VALUES ('"+this.ondutydateTime .Text .ToString ()+"', '"+this.txtfool.Text .ToString ()+"','"+this.txtName .Text .ToString ()
                    + "', '" + this.txtText.Text.ToString() +"')";
                DataSet dataset = new DataSet();
                SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(mysql, objSqlConnection);
                objSqlDataAdapter.Fill(dataset, "onduty");
                MessageBox.Show("登记成功");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 值班记录添加_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                this.txtfool.Items.Add(i);
            }
        }
    }
}