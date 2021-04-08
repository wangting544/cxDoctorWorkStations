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
    public partial class StudyCase : Form
    {
        public StudyCase()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgvStudyCase .BackgroundColor = Color.White;
            this.dgvStudyCase .AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            Search();
        }
        private void Search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
                                            P.PatientNo AS 病人ID
                                            ,P.No AS 住院号
                                            ,P.BedNo AS 床号
	                                        ,P.PrincipalDiagnosis AS 主要诊断
	                                        ,D.Name AS 经治医生
                                       FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No = P.PatientNo
                                            JOIN tb_Doctor AS D ON D.No = P.DoctorNo 
                                       WHERE P.Type='学习病历'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            this.dgvStudyCase.DataSource = dataTable;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            //SqlCommand insertCommand = sqlConnection.CreateCommand();
            //insertCommand.CommandText = $@"INSERT tb_PatientInHosptial 
            //                                    (No,PatientNo ,BedNo,PrincipalDiagnosis,DoctorNo )
            //                                VALUES
            //                                    (@No,@PatientNo,@BedNo,@PrincipalDiagnosis,@DoctorNo)";
            //insertCommand.Parameters.Add("@No", SqlDbType.Int, 0, "AdviceTypeNo");
            //insertCommand.Parameters.Add("@PatientNo", SqlDbType.Int, 0, "SortNo");
            //insertCommand.Parameters.Add("@BedNo", SqlDbType.VarChar, 0, "AdviceContent");
            //insertCommand.Parameters.Add("@AdmissionDate", SqlDbType.VarChar, 0, "Dose");
            //insertCommand.Parameters.Add("@Unit", SqlDbType.VarChar, 0, "Unit");
            //insertCommand.Parameters.Add("@Way", SqlDbType.VarChar, 0, "Way");
            //insertCommand.Parameters.Add("@Frequency", SqlDbType.VarChar, 0, "Frequency");
            //insertCommand.Parameters.Add("@Count", SqlDbType.Int, 0, "Count");
            //insertCommand.Parameters.Add("@xie", SqlDbType.Int, 0, "Xie");
            //insertCommand.Parameters.Add("@Day", SqlDbType.VarChar, 0, "Day");
            //insertCommand.Parameters.AddWithValue("@PackageNo", txt_Name.Text.Trim());

            //SqlCommand updateCommand = sqlConnection.CreateCommand();
            //updateCommand.CommandText = $@"UPDATE tb_DoctorAdvice
            //                                SET
            //                                    AdviceTypeNo=@AdviceTypeNo,SortNo=@SortNo,AdviceContent=@AdviceContent,Dose=@Dose,Unit=@Unit,Way=@Way,Frequency=@Frequency,Count=@Count,xie=@xie,Day=@Day,DoctorNo='{Doctor.DoctorNo }'
            //                            where AdviceContent=@OldAdviceContent and PackageNo=@PackageNo";
            //updateCommand.Parameters.Add("@AdviceTypeNo", SqlDbType.Int, 0, "AdviceTypeNo");
            //updateCommand.Parameters.Add("@SortNo", SqlDbType.Int, 0, "SortNo");
            //updateCommand.Parameters.Add("@AdviceContent", SqlDbType.VarChar, 0, "AdviceContent");
            //updateCommand.Parameters.Add("@Dose", SqlDbType.VarChar, 0, "Dose");
            //updateCommand.Parameters.Add("@Unit", SqlDbType.VarChar, 0, "Unit");
            //updateCommand.Parameters.Add("@Way", SqlDbType.VarChar, 0, "Way");
            //updateCommand.Parameters.Add("@Frequency", SqlDbType.VarChar, 0, "Frequency");
            //updateCommand.Parameters.Add("@Count", SqlDbType.Int, 0, "Count");
            //updateCommand.Parameters.Add("@xie", SqlDbType.Int, 0, "Xie");
            //updateCommand.Parameters.Add("@Day", SqlDbType.VarChar, 0, "Day");
            //updateCommand.Parameters.AddWithValue("@PackageNo", txt_Name.Text.Trim());
            //updateCommand.Parameters.Add("@OldAdviceContent", SqlDbType.VarChar, 0, "AdviceContent");
            //updateCommand.Parameters["@OldAdviceContent"].SourceVersion = DataRowVersion.Original;

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.InsertCommand = insertCommand;
            //sqlDataAdapter.UpdateCommand = updateCommand;
            //DataTable adviceTable = (DataTable)this.dgv_DoctorAdvice.DataSource;
            //sqlConnection.Open();
            //int rowaffected = sqlDataAdapter.Update(adviceTable);
            //sqlConnection.Close();
            //MessageBox.Show($"更新{rowaffected }行。");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void StudyCase_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
