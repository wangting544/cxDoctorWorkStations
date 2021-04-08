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
    public partial class WaitBedPatient : Form
    {
        public WaitBedPatient()
        {
            InitializeComponent();
            this.dgv_WaitBedPatient .AllowUserToAddRows = false;
            this.dgv_WaitBedPatient .RowHeadersVisible = false;
            this.dgv_WaitBedPatient .BackgroundColor = Color.White;
            dgv_WaitBedPatient .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Search();
        }
        private void Search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"SELECT
                                            P.PatientNo AS 病人ID
	                                        ,P.No AS 住院号
	                                        ,PA.Name AS 姓名
	                                        ,PA.Sex AS 性别
	                                        ,P.BedNo AS 床号
	                                        ,P.PrincipalDiagnosis AS 主要诊断
	                                        ,D.Name AS 经治医生
                                       FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No = P.PatientNo
                                            JOIN tb_Doctor AS D ON D.No = P.DoctorNo 
                                       WHERE P.BedNo is null";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            this.dgv_WaitBedPatient .DataSource = dataTable;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void WaitBedPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
