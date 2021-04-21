using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Environment;
using System.Data.SqlClient;
using System.Configuration;

namespace DoctorWorkStations
{
    public partial class DiseaseCourse : Form
    {
        public DiseaseCourse()
        {
            InitializeComponent();
        }
        public DiseaseCourse(string PatientInhosptialNo) : this()
        {
            string PatientName="";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
	                                        PA.Name
                                        FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No=P.PatientNo 
                                        WHERE P.No='{PatientInhosptialNo  }' and p.flag is null";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                PatientName = sqlDataReader["Name"].ToString();
            }
            sqlDataReader.Close();

            label1.Text =$"{PatientName}的病历";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
