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
    public partial class NLeaveHospital : Form
    {
        public NLeaveHospital()
        {
            InitializeComponent();
            this.dgv_LeaveHosptial .AllowUserToAddRows = false;
            this.dgv_LeaveHosptial .RowHeadersVisible = false;
            this.dgv_LeaveHosptial .BackgroundColor = Color.White;
            dgv_LeaveHosptial .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
										,D.name as 主治医生
                                        FROM tb_PatientInHosptial AS P
                                        JOIN tb_Patient AS PA ON PA.No = P.PatientNo
                                        JOIN tb_Doctor AS D ON D.No = P.DoctorNo AND P.BedNo IS NOT NULL
                                        WHERE P.flag=0";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_LeaveHosptial .DataSource = dataTable;

        }

        private void btn_Leave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            if (this.dgv_LeaveHosptial  .CurrentCell == null)
            {
                MessageBox.Show("你未选中病人！");
                return;
            }
            DateTime dateTime = DateTime.Now;
            string PatientNo = dgv_LeaveHosptial .CurrentRow.Cells["病人号"].Value.ToString();
            string No = dgv_LeaveHosptial .CurrentRow.Cells["住院标识号"].Value.ToString();
            string Name = dgv_LeaveHosptial .CurrentRow.Cells["姓名"].Value.ToString();
            DialogResult dr = MessageBox.Show($"确定让{Name}病人出院？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                sqlCommand1.CommandText = $@"update tb_PatientInHosptial 
                                            set flag = 1
                                                ,OUTDATE='{dateTime }'
                                                ,No='{No }' +'{dateTime.ToShortTimeString() }'
                                                ,BEDNO=NULL
                                        where No ='{No }' ";
                sqlConnection.Open();
                int r = int.Parse(sqlCommand1.ExecuteNonQuery().ToString());
                sqlConnection.Close();
                MessageBox.Show("病人出院成功！");
                search();
            }
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("取消成功！");
            }
        }

        private void NLeaveHospital_FormClosed(object sender, FormClosedEventArgs e)
        {
            NurseHomepage nurseHomepage = new NurseHomepage();
            nurseHomepage.Show();
        }
    }
}
