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
    public partial class Shiftin : Form
    {
        public Shiftin()
        {
            InitializeComponent();
            rbtn_Inhospital.Checked = true;
            search();
        }
        private void search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"SELECT
                                            P.PatientNo AS 病人ID
                                            ,P.No AS 住院号
	                                        ,PA.Name AS 姓名
	                                        ,PA.Sex AS 性别
                                       FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No = P.PatientNo
                                            JOIN tb_Doctor AS D ON D.No = P.DoctorNo 
                                       WHERE P.IsInHospital=0 ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Patient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Patient.DataSource = dataTable;
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand1.CommandText = @"SELECT
                                            count(P.No)
                                       FROM tb_PatientInHosptial AS P
                                       WHERE P.IsInHospital =0  and   flag is null";
            sqlConnection.Open();
            int count=(int)sqlCommand1.ExecuteScalar();
            sqlConnection.Close();
            if(count==0)
            {
                MessageBox.Show("当前没有病人可移入！");
                return;
            }
            string PatientNo = dgv_Patient.CurrentRow.Cells["病人ID"].Value.ToString();
            string No = dgv_Patient.CurrentRow.Cells["住院号"].Value.ToString();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            if(rbtn_Study.Checked)
            {
                sqlCommand.CommandText = $@"UPDATE tb_PatientInHosptial 
	                                  SET DoctorNo ='{Doctor.DoctorNo }'
                                            ,IsInHospital=1    
                                            ,Type='学习病历'
	                                  WHERE PatientNo ='{PatientNo}' AND No='{No}'";
            }
            if(rbtn_Inhospital.Checked )
            {
                sqlCommand.CommandText = $@"UPDATE tb_PatientInHosptial 
	                                  SET DoctorNo ='{Doctor.DoctorNo }'
                                          ,IsInHospital=1  
                                            ,Type='在院病历'
	                                  WHERE PatientNo ='{PatientNo}' AND No='{No}'";
            }
            sqlConnection.Open();
            int affected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(affected==1)
            {
                MessageBox.Show("移入成功！");
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void Shiftin_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage h = new HomePage();
            h.Show();
        }
    }
}
