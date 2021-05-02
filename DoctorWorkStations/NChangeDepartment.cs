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
    public partial class NChangeDepartment : Form
    {
        public NChangeDepartment()
        {
            InitializeComponent();
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
	                                        ,PA.Name AS 姓名
	                                        ,PA.Sex AS 性别
	                                        ,P.BedNo AS 床号
	                                        ,P.PrincipalDiagnosis AS 主要诊断
	                                        ,D.Name AS 经治医生
                                            ,d.DEPARTMENTNO
                                       FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No = P.PatientNo
                                            JOIN tb_Doctor AS D ON D.No = P.DoctorNo 
                                            join tb_department as dt on dt.no=d.departmentno
                                       WHERE P.IsInHospital ='1' and  flag is null and P.BedNo is not null ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            this.dgv_Patient.DataSource = dataTable;
        }

        private void btn_ChangeDepartment_Click(object sender, EventArgs e)
        {
            if (this.dgv_Patient.CurrentCell == null)
            {
                MessageBox.Show("你未选中病人！");
                return;
            }
            string PatientNo = this.dgv_Patient.CurrentRow.Cells["病人ID"].Value.ToString();
            string DepartmentNo = this.dgv_Patient.CurrentRow.Cells["DEPARTMENTNO"].Value.ToString();
            DateTime time = DateTime.Now;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"UPDATE tb_PatientInHosptial
                                      SET
                                         IsInHospital = 0
                                         , BedNo = 'NULL'
                                      WHERE pATIENTnO = '{PatientNo}'";
            int count = 0;
            sqlConnection.Open();
            count= sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = $@"INSERT tb_ChangeDepartmentRecord 
                                            (PatientNo,WritePerson,OldDepartmentNo,SubmitDate )
                                        VALUES
                                            ('{PatientNo }','{Doctor.DoctorNo }','{DepartmentNo }','{time }')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(count!=0)
            {
                MessageBox.Show("转科成功！");
            }
            else
            {
                MessageBox.Show($"转科失败！");
            }
            Search();
        }

        private void NChangeDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            NurseHomepage nurseHomepage = new NurseHomepage();
            nurseHomepage.Show();
        }
    }
}
