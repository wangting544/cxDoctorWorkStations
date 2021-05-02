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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        string PatientInHospitalNo;
        public FirstPage(string InHospitalNo):this()
        {
            this.PatientInHospitalNo = InHospitalNo;
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
	                                        ,P.Outdate
	                                        ,P.PrincipalDiagnosis
	                                        ,P.Prepayment
	                                        ,P.TotalCost
                                            ,PA.Photo
                                            ,dt.name as dname
                                        FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No=P.PatientNo 
                                            JOIN tb_Doctor AS D ON D.No = P.DoctorNo 
                                            join tb_department as dt on dt.no=d.departmentno                                           
                                        WHERE P.No='{PatientInHospitalNo }' and p.flag is null";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_PatientNo.Text = sqlDataReader["PatientNo"].ToString();
                txt_inHosptial.Text = sqlDataReader["No"].ToString();
                txt_Name.Text = sqlDataReader["Name"].ToString();
                txt_Sex.Text = sqlDataReader["Sex"].ToString();
                txt_Department.Text = sqlDataReader["dname"].ToString();
                txt_work.Text = sqlDataReader["Work"].ToString();
                txt_Birthday.Text = sqlDataReader["Birthday"].ToString();
                txt_AdmWardDate.Text= sqlDataReader["AdmWardDate"].ToString();
                txt_OutDate .Text = sqlDataReader["Outdate"].ToString();
            }
            sqlDataReader.Close();
            Diagnosis();
        }
        private void Diagnosis()
        {
            this.dgv_Diagnosis .BackgroundColor = Color.White;
            dgv_Diagnosis .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ToString();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select *  from tb_Diagnosis where PatientNo ='{txt_PatientNo.Text }'";
            DataTable dataTable = new DataTable();
            DataTable TypeTable = new DataTable();
            DataTable doctorTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlCommand.CommandText = "select  * from tb_Doctor where Status='医生'";
            sqlDataAdapter.Fill(doctorTable);
            sqlCommand.CommandText = "select distinct * from tb_Diagnosis ";
            sqlDataAdapter.Fill(TypeTable);
            sqlConnection.Close();
            dgv_Diagnosis.DataSource = dataTable;
            this.dgv_Diagnosis.Columns["Description"].HeaderText = "诊断描述";
            this.dgv_Diagnosis.Columns["Result"].HeaderText = "结果";
            this.dgv_Diagnosis.Columns["Days"].HeaderText = "天数";
            this.dgv_Diagnosis.Columns["Operate"].HeaderText = "手术";
            this.dgv_Diagnosis.Columns["DiagnosisDate"].HeaderText = "确诊日期";
            this.dgv_Diagnosis.Columns["No"].Visible = false;
            this.dgv_Diagnosis.Columns["PatientNo"].Visible = false;
            this.dgv_Diagnosis.Columns["DoctorNo"].Visible = false;
            this.dgv_Diagnosis.Columns["type"].Visible = false;
            DataGridViewComboBoxColumn typeColumn = new DataGridViewComboBoxColumn();
            dgv_Diagnosis.Columns.Add(typeColumn);
            typeColumn.Name = "type";
            typeColumn.HeaderText = "   ";
            typeColumn.DataSource = TypeTable;
            typeColumn.DisplayMember = "type";
            typeColumn.ValueMember = "type";
            typeColumn.DataPropertyName = "type";
            typeColumn.DisplayIndex = 0;

            DataGridViewComboBoxColumn doctorColumn = new DataGridViewComboBoxColumn();
            dgv_Diagnosis.Columns.Add(doctorColumn);
            doctorColumn.Name = "doctors";
            doctorColumn.HeaderText = "医生";
            doctorColumn .DataSource = doctorTable;
            doctorColumn.DisplayMember = "Name";
            doctorColumn.ValueMember = "No";
            doctorColumn.DataPropertyName = "doctorNo";

            this.dgv_Diagnosis.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_Keep1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ToString();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"UPDATE tb_Diagnosis 
                                            SET
                                                Description =@Description
                                                ,Result =@Result
                                                , Days =@Days
                                                , Operate =@Operate
                                                , DiagnosisDate =@DiagnosisDate
                                                , DoctorNo =@DoctorNo
                                            WHERE
                                                Type =@Type and PatientNo =@PatientNo;";
            sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 0, "Description");
            sqlCommand.Parameters.Add("@Result", SqlDbType.VarChar, 0, "Result");
            sqlCommand.Parameters.Add("@Days", SqlDbType.Int, 0, "Days");
            sqlCommand.Parameters.Add("@Operate", SqlDbType.Bit, 0, "Operate");
            sqlCommand.Parameters.Add("@DiagnosisDate", SqlDbType.VarChar, 0, "DiagnosisDate");
            sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar, 0, "Type");
            sqlCommand.Parameters.Add("@DoctorNo", SqlDbType.VarChar, 0, "DoctorNo");
            sqlCommand.Parameters.AddWithValue("@PatientNo", txt_PatientNo.Text);

            SqlCommand insertCommand = sqlConnection.CreateCommand();
            insertCommand.CommandText = $@"insert tb_Diagnosis 
                                            (Type, Description, Result, Days, Operate, DiagnosisDate, DoctorNo, PatientNo)
                                        values
                                            (@Type, @Description, @Result, @Days, @Operate, @DiagnosisDate,@DoctorNo,'{txt_PatientNo.Text }')";
            insertCommand.Parameters.Add("@Description", SqlDbType.VarChar, 0, "Description");
            insertCommand.Parameters.Add("@Result", SqlDbType.VarChar, 0, "Result");
            insertCommand.Parameters.Add("@Days", SqlDbType.Int, 0, "Days");
            insertCommand.Parameters.Add("@Operate", SqlDbType.Bit, 0, "Operate");
            insertCommand.Parameters.Add("@DiagnosisDate", SqlDbType.VarChar, 0, "DiagnosisDate");
            insertCommand.Parameters.Add("@Type", SqlDbType.VarChar, 0, "Type");
            insertCommand.Parameters.Add("@DoctorNo", SqlDbType.VarChar, 0, "DoctorNo");

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.UpdateCommand = sqlCommand;
            sqlDataAdapter.InsertCommand = insertCommand;
            DataTable dateTable = (DataTable)this.dgv_Diagnosis .DataSource;
            sqlConnection.Open();
            int rowaffected = sqlDataAdapter.Update(dateTable );
            sqlConnection.Close();
            MessageBox.Show($"更新{rowaffected }行。");
        }

        private void FirstPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
