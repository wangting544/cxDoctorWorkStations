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
    public partial class SearchAdvice : Form
    {
        public SearchAdvice()
        {
            InitializeComponent();
        }
        public SearchAdvice(string PatientInHospitalNo):this()
        {
            double money = 0;
            this.dgv_Execute.AllowUserToAddRows = false;
            this.dgv_Execute.RowHeadersVisible = false;
            this.dgv_Execute.BackgroundColor = Color.White;
            dgv_Execute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                                            ,PA.Photo
                                            ,p.Prepayment
                                        FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No=P.PatientNo 
                                        WHERE P.No='{PatientInHospitalNo }' and p.flag is null";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                lbl_BedNo.Text = sqlDataReader["BedNo"].ToString();
                lbl_Name.Text = sqlDataReader["Name"].ToString();
                lbl_Sex.Text = sqlDataReader["Sex"].ToString();
                lbl_Age.Text = (DateTime.Now.Year - (Convert.ToDateTime(sqlDataReader["Birthday"].ToString()).Year)).ToString();
                lbl_InHosptial.Text = sqlDataReader["PatientNo"].ToString();
                money = Convert.ToDouble(sqlDataReader["Prepayment"].ToString());
            }
            sqlConnection.Close();
            Search();
            rbtn_Allexecute.Checked = true;
        }
        private void Search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select 
		                                    t.Name  as 长期
		                                    ,s.Name as 类别
		                                    ,pa.givetime as 开始时间
		                                    ,pa.AdviceContent as 医嘱内容
		                                    ,pa.Dose as 剂量
		                                    ,pa.Unit as 单位
		                                    ,pa.Way as 途径
		                                    ,pa.Frequency as 频次
		                                    ,pa.ExecuteTime as 执行时间
		                                    ,pa.LastTime as 持续时间
		                                    ,pa.IsFinish as 是否执行完
	                                   from tb_PatientAdvice as pa
	                                        join tb_Patient as p on p.No=pa.PatientNo 
	                                        join tb_Type as t on t.No=pa.AdviceTypeNo 
	                                        join tb_Sort as s on s.No=pa.SortNo 
                                            where PatientNo='{lbl_InHosptial.Text }' and pa.StartTime is not null ";
            if(rbtn_Stop.Checked )
            {
                sqlCommand.CommandText += "    and  pa.isexecute=0";
            }
            if (!rbtn_Stop.Checked)
            {
                sqlCommand.CommandText += "    and  pa.isexecute=1";
            }
            if (rbtn_Long.Checked)
            {
                sqlCommand.CommandText += "  and t.No=1";
            }
            if (rbtn_temporary.Checked)
            {
                sqlCommand.CommandText += "  and t.No=2";
            }
            if (rbtn_execute.Checked)
            {
                sqlCommand.CommandText += "  AND pa.IsFinish='是'";
            }
            if (rbtn_Executing.Checked)
            {
                sqlCommand.CommandText += "  AND pa.IsFinish='否'";
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Execute.DataSource = dataTable;
            this.dgv_Execute .Columns["持续时间"].HeaderText = "持续时间（天）";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void SearchAdvice_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
