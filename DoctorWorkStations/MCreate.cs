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
    public partial class MCreate : Form
    {
        public MCreate()
        {
            InitializeComponent();
            this.dgv_Patient.AllowUserToAddRows = false;
            this.dgv_Patient.RowHeadersVisible = false;
            this.dgv_Patient.BackgroundColor = Color.White;
            dgv_Patient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Search();
        }

        private void btn_Ensure_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            if (this.dgv_Patient .CurrentCell == null)
            {
                MessageBox.Show("你未选中病人！");
                return;
            }
            DateTime dateTime = DateTime.Now;
            string PatientNo = dgv_Patient.CurrentRow.Cells["病人ID"].Value.ToString();
            string No = dgv_Patient.CurrentRow.Cells["住院号"].Value.ToString();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"UPDATE tb_PatientInHosptial 
	                                  SET DoctorNo ='{Doctor.DoctorNo }'
                                          ,AdmWardDate='{dateTime}'
                                          ,IsInHospital=1
	                                  WHERE PatientNo ='{PatientNo}' AND No='{No}'";
            sqlConnection.Open();
            int rowAffected=sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(rowAffected==1)
            {
                MessageBox.Show("新建成功");
                Search();
            }
            else
            {
                MessageBox.Show("新建失败");
            }
        }
        private  void Search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
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
                                       WHERE P.IsInHospital IS NULL and  flag is null and P.BedNo is not null";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            this.dgv_Patient.DataSource = dataTable;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void MCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage h = new HomePage();
            h.Show();
        }
    }
}
