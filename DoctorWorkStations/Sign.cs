using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DoctorWorkStations
{
    public partial class Sign : Form
    {
        string PatientNo;
        public Sign()
        {
            InitializeComponent();
        }
        public Sign(string PatientNo):this()
        {
            this.PatientNo = PatientNo;
            txt_No.Text = Doctor.DoctorNo;
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"SELECT 
	                                        COUNT(1)
	                                        FROM tb_Doctor AS D
	                                        WHERE
		                                    D.No=@No AND D.Password=@Password;";
            sqlCommand.Parameters.AddWithValue("@No", this.txt_No.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Password", this.txt_Password.Text.Trim());
            int count = 0;
            sqlConnection.Open();
            count = int.Parse(sqlCommand.ExecuteScalar().ToString());
            sqlConnection.Close();
            if(count==0)
            {
                MessageBox.Show("口令错误！");
                txt_Password.Text = null;
                return;
            }
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            sqlCommand2.CommandText = $@"UPDATE tb_PatientInHosptial 
	                                  SET 
                                         IsInHospital=0
	                                  WHERE No ='{PatientNo}'";
            sqlConnection.Open();
            int rowAffected = sqlCommand2.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("移出成功！");
            this.Close();
            HomePage homePage = new HomePage();
            homePage.Show();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void Sign_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage h = new HomePage();
            h.Show();
        }
    }
}
