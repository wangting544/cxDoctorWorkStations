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
    public partial class leaveHosptial : Form
    {
        public leaveHosptial()
        {
            InitializeComponent();
            this.dgv_leaveHosptial .AllowUserToAddRows = false;
            this.dgv_leaveHosptial .RowHeadersVisible = false;
            this.dgv_leaveHosptial .BackgroundColor = Color.White;
            dgv_leaveHosptial .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_leaveHosptial .BackgroundColor = Color.White;
            dgv_leaveHosptial .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            search();
        }
        public void search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
                                        PA.No as 病人号
	                                    ,p.no as 住院标识号
                                        ,pa.name as 姓名
										,P.BedNo as 床号
										,P.PrincipalDiagnosis as 主要诊断
										,P.AdmWardDate as 入科日期
										,IIF(flag is null,'否','是') AS 是否通知出院
                                        FROM tb_PatientInHosptial AS P
                                        JOIN tb_Patient AS PA ON PA.No = P.PatientNo
                                        JOIN tb_Doctor AS D ON D.No = P.DoctorNo AND P.BedNo IS NOT NULL
                                        WHERE D.No = '{Doctor.DoctorNo }' and P.IsInHospital=1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_leaveHosptial.DataSource = dataTable;

        }

        private void dgv_leaveHosptial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            //if (this.dgv_leaveHosptial .CurrentCell == null)
            //{
            //    MessageBox.Show("你未选中病人！");
            //    return;
            //}
            DateTime dateTime = DateTime.Now;
            string PatientNo = dgv_leaveHosptial .CurrentRow.Cells["病人号"].Value.ToString();
            string No = dgv_leaveHosptial .CurrentRow.Cells["住院标识号"].Value.ToString();
            string Name = dgv_leaveHosptial.CurrentRow.Cells["姓名"].Value.ToString();
            DialogResult dr = MessageBox.Show($"确定让{Name}病人出院？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                sqlCommand1.CommandText = $@"update tb_PatientInHosptial 
                                            set flag = 0
                                        where No ={No } ";
                sqlConnection.Open();
                int r = int.Parse(sqlCommand1.ExecuteNonQuery().ToString());
                sqlConnection.Close();
                MessageBox.Show("已通知病人出院！");
                search();
            }
            if(dr==DialogResult.Cancel )
            {
                MessageBox.Show("取消成功！");
            }
        }

        private void leaveHosptial_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
