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
            this.dgv_WaitBedPatient.AllowUserToAddRows = false;
            this.dgv_WaitBedPatient.RowHeadersVisible = false;
            this.dgv_WaitBedPatient.BackgroundColor = Color.White;
            dgv_WaitBedPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Search();
        }
        private void Search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
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
                                            join tb_department as dt on dt.no=d.departmentno
                                       WHERE P.BedNo is null and dt.name='{Doctor.Department }'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            DataTable BedNoTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlCommand.CommandText = $@"SELECT 
                                                *
                                         FROM tb_Bed AS B
                                         WHERE  department='{Doctor.Department }' and B.Name NOT IN
                                                    (SELECT BedNo  FROM tb_PatientInHosptial WHERE BedNo IS NOT NULL )";
            sqlDataAdapter.Fill(BedNoTable);
            sqlConnection.Close();
            this.dgv_WaitBedPatient.DataSource = dataTable;
            this.dgv_WaitBedPatient.Columns["床号"].Visible = false;
            DataGridViewComboBoxColumn bedColumns = new DataGridViewComboBoxColumn();
            this.dgv_WaitBedPatient.Columns.Add(bedColumns);
            bedColumns.Name = "BedNo";
            bedColumns.HeaderText = "床号";
            bedColumns.DataSource = BedNoTable;
            bedColumns.DisplayMember = "Name";
            bedColumns.ValueMember = "Name";
            bedColumns.DataPropertyName = "床号";
            bedColumns.DisplayIndex = 6;
            bedColumns.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_WaitBedPatient.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sqlConnection.Open();

            
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"update tb_PatientInHosptial
                                         set BedNo = @BedNo
                                             ,DoctorNo='{Doctor.DoctorNo }'
                                            ,AdmWardDate={DateTime.Now}
                                            ,IsInHospital=1
                                         WHERE No = @No";
            sqlCommand.Parameters.Add("@BedNo", SqlDbType.VarChar, 0, "床号");
            sqlCommand.Parameters.Add("@No", SqlDbType.VarChar, 0, "住院号");
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.UpdateCommand = sqlCommand;
            DataTable dataTable = (DataTable)this.dgv_WaitBedPatient.DataSource;
            sqlConnection.Close ();
            int rowaddected = sqlDataAdapter.Update(dataTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowaddected }行");
            Search();
        }
    }
}
