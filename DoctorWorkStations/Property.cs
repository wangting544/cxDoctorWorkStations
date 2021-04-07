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
    public partial class Property : Form
    {
        string PatientInHospitalNo;
        public Property()
        {
            InitializeComponent();
        }
        public Property(string PatientInHospitalNo):this()
        {
            this.PatientInHospitalNo = PatientInHospitalNo;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
	                                        PA.No as PatientNo
	                                        ,PA.Name 
	                                        ,PA.Sex
	                                        ,PA.Birthday
	                                        ,PA.Work 
	                                        ,P.No
	                                        ,P.AdmWardDate
	                                        ,P.BedNo
	                                        ,P.PrincipalDiagnosis
	                                        ,P.Prepayment
	                                        ,P.TotalCost 
                                        FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No=P.PatientNo 
                                        WHERE P.No='{PatientInHospitalNo }' and p.flag is null";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if(sqlDataReader.Read())
            {
                txt_PatientNo.Text = sqlDataReader["PatientNo"].ToString();
                txt_Name.Text= sqlDataReader["Name"].ToString();
                string sex= sqlDataReader["Sex"].ToString();
                if(sex=="男")
                {
                    rbtn_Male.Checked = true;
                }
                if (sex == "女")
                {
                    rbtn_Female.Checked = true;
                }
                dtp_Birthday.Value = (DateTime)sqlDataReader["Birthday"];
                txt_Work.Text = sqlDataReader["Work"].ToString();
                txt_InHosptial.Text = sqlDataReader["No"].ToString();
                dtp_AdmWard.Value = (DateTime)sqlDataReader["AdmWardDate"];
                txt_bedNo.Text = sqlDataReader["BedNo"].ToString();
                txt_Dialogue.Text  = sqlDataReader["PrincipalDiagnosis"].ToString();
                txt_Prepayment .Text = sqlDataReader["Prepayment"].ToString();
                txt_TotalCost.Text = sqlDataReader["TotalCost"].ToString();
            }
        }

        private void Property_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage h = new HomePage();
            h.Show();
        }

        private void Property_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
