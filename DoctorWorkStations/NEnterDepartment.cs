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
    public partial class NEnterDepartment : Form
    {
        public NEnterDepartment()
        {
            InitializeComponent();
            this.dgv_Patient.AllowUserToAddRows = false;
            this.dgv_Patient.RowHeadersVisible = false;
            this.dgv_Patient.BackgroundColor = Color.White;
            dgv_Patient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void rbtn_New_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_New.Checked)
            {
                SearchNew();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                SearchChange();
            }
        }

        private void rbtn_ALL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_ALL.Checked)
            {
                SearchAll();
            }
        }

        private void dgv_Patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Department();
            Doctors();
            BedNo();
            Nurse();
            DisplayInformation();
        }
        private void SearchNew()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
                                            P.PatientNo AS 病人ID
	                                        ,P.No AS 住院号
	                                        ,PA.Name AS 姓名
	                                        ,PA.Sex AS 性别
	                                        ,P.PrincipalDiagnosis AS 主要诊断                                       
                                       FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No = P.PatientNo
                                            JOIN tb_Doctor AS D ON D.No = P.DoctorNo 
                                            join tb_department as dt on dt.no=d.departmentno
                                       WHERE P.IsInHospital IS NULL and  flag is null ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            this.dgv_Patient.DataSource = dataTable;
        }
        private void SearchChange()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
                                            P.PatientNo AS 病人ID
	                                        ,P.No AS 住院号
	                                        ,PA.Name AS 姓名
	                                        ,PA.Sex AS 性别
	                                        ,P.PrincipalDiagnosis AS 主要诊断                                       
                                       FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No = P.PatientNo
                                            JOIN tb_Doctor AS D ON D.No = P.DoctorNo 
                                            join tb_department as dt on dt.no=d.departmentno
                                       WHERE P.IsInHospital ='0' and  flag is null ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            this.dgv_Patient.DataSource = dataTable;
        }
        private int maxPageNo;
        private int pageSize;
        private int currentPageNo;
        DataView currentPageView;
        private void SearchAll()
        {
            pageSize = 5;
            currentPageNo = 1;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
	                                        P.Name AS 姓名
	                                        ,P.Sex AS 性别
	                                        ,p.BIRTHDAY AS 出生日期                                   
                                       FROM 
                                            tb_Patient AS P
 ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Patient";

            DataColumn rowIdColumn = new DataColumn();
            rowIdColumn.ColumnName = "RowId";
            rowIdColumn.DataType = typeof(int);
            rowIdColumn.AutoIncrement = true;
            rowIdColumn.AutoIncrementSeed = 1;
            rowIdColumn.AutoIncrementStep = 1;
            dataTable.Columns.Add(rowIdColumn);
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            this.maxPageNo = (int)Math.Ceiling((double)dataTable.Rows.Count / (double)pageSize);

            currentPageView = new DataView();
            currentPageView.Table = dataTable;
            currentPageView.Sort = "RowId ASC";
            this.RefreshRowFilter();
            this.dgv_Patient.DataSource = currentPageView;
            this.dgv_Patient.Columns["RowId"].Visible = false;
        }
        private void RefreshRowFilter()
        =>
            this.currentPageView.RowFilter = $"RowId>{(currentPageNo - 1) * pageSize }"
                                            + $"and RowId<={currentPageNo * pageSize }";
        
        private void DisplayInformation()
        {
            txt_PatientNo.Text = dgv_Patient.CurrentRow.Cells["病人ID"].Value.ToString();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
	                                        PA.No as PatientNo
	                                        ,PA.Name 
	                                        ,PA.Sex
	                                        ,PA.Birthday
	                                        ,PA.Work 
	                                        ,P.No
	                                        ,P.AdmissionDate
                                            ,P.AdmWardDate
	                                        ,P.BedNo as bed
	                                        ,P.PrincipalDiagnosis
	                                        ,P.Prepayment
	                                        ,d.departmentno
                                            ,PA.Photo
                                            ,p.Doctorno
                                            ,P.NURSENO
                                        FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No=P.PatientNo 
                                            join tb_doctor as d on d.no=p.doctorno
                                        WHERE Pa.No='{ txt_PatientNo.Text}' and p.flag is null";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_Age.Text = ((DateTime.Now.Year) - ((DateTime)sqlDataReader["Birthday"]).Year).ToString();
                cb_Bed.SelectedValue = sqlDataReader["bed"].ToString();
                txt_Dialogue.Text = sqlDataReader["PrincipalDiagnosis"].ToString();
                txt_InHosptial.Text = sqlDataReader["No"].ToString();
                txt_Name.Text = sqlDataReader["name"].ToString();
                cb_nurse.SelectedValue  = sqlDataReader["nurseNO"].ToString();
                txt_PatientNo.Text = sqlDataReader["PatientNo"].ToString();
                txt_Prepayment.Text = sqlDataReader["Prepayment"].ToString();
                cb_Department.SelectedValue = sqlDataReader["departmentno"].ToString();
                cb_doctor.SelectedValue = sqlDataReader["doctorno"].ToString();
                txt_Date.Text = sqlDataReader["AdmissionDate"].ToString();
                txt_Adwarddate.Text = sqlDataReader["AdmWardDate"].ToString();
                //if(sqlDataReader["AdmWardDate"].ToString()!="")
                //{
                //    dateTimePicker1.Value = (DateTime)sqlDataReader["AdmWardDate"];
                //}
                
            }
            sqlDataReader.Close();
        }
        private void Department()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from tb_department";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            cb_Department.DataSource = dataTable;
            cb_Department.DisplayMember = "Name";
            cb_Department.ValueMember = "No";
            sqlConnection.Close();
        }
        private void Doctors()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select * from tb_doctor where departmentno='{cb_Department.SelectedValue }' and status='医生'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            cb_doctor.DataSource = dataTable;
            cb_doctor.DisplayMember = "Name";
            cb_doctor.ValueMember = "No";
            sqlConnection.Close();
        }
        private void Nurse()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select * from tb_doctor where status='护士'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            cb_nurse .DataSource = dataTable;
            cb_nurse .DisplayMember = "Name";
            cb_nurse .ValueMember = "No";
            sqlConnection.Close();
        }
        private void BedNo()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select *
                                            from tb_Bed as b
                                            join tb_Department as d on d.Name=b.department 
                                        where
	                                        d.no='{cb_Department.SelectedValue}' and b.name not in (SELECT BedNo  FROM tb_PatientInHosptial WHERE BedNo IS NOT NULL )";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            cb_Bed.DataSource = dataTable;
            cb_Bed.DisplayMember = "Name";
            cb_Bed.ValueMember = "Name";
            sqlConnection.Close();
        }

        private void cb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctors();
            BedNo();
        }

        private void btn_Keep_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sql = sqlConnection.CreateCommand();
            sql.CommandText = $"select 1 from tb_PatientInHosptial  where No='{txt_InHosptial.Text}'";
            string c = "0";
            sqlConnection.Open();
            c = sql.ExecuteScalar().ToString();
            sqlConnection.Close();
            if (c == "1")
            {
                SqlCommand sql1 = sqlConnection.CreateCommand();
                sql1.CommandText = $@"update tb_PatientInHosptial 
                                    SET 
	                                    BedNo ='{cb_Bed.SelectedValue }'
	                                    ,PrincipalDiagnosis='{txt_Dialogue.Text }'
	                                    ,DoctorNo='{cb_doctor.SelectedValue }'
	                                    ,nurseNo='{cb_nurse.SelectedValue }'
                                    WHERE
	                                    PatientNo='{txt_PatientNo.Text }'";
                int f = 0;
                sqlConnection.Open();
                f =  sql1.ExecuteNonQuery(); ;
                sqlConnection.Close();
                if (f != 0)
                {
                    MessageBox.Show("保存成功");
                    sql1.CommandText = $"SELECT COUNT(1) FROM tb_ChangeDepartmentRecord WHERE PatientNo='{txt_PatientNo.Text}' AND NewDepartmentNo IS NULL";
                    sqlConnection.Open();
                    int  count1=int.Parse( sql1.ExecuteScalar().ToString());
                    if(count1 !=0)
                    {
                        sql1.CommandText = $@"update tb_ChangeDepartmentRecord
                                            set NewDepartmentNo='{cb_Department.SelectedValue }'
                                            where PatientNo='{txt_PatientNo.Text }'";
                        sql1.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
                return;
            }
        }

        private void btn_PreviousPage_Click(object sender, EventArgs e)
        {
            if (this.currentPageNo  > 1)                                                                     //若当前页号大于1；
                this.currentPageNo --;                                                                       //则当前页号递减；
            this.RefreshRowFilter();
        }

        private void btn_NextPage_Click(object sender, EventArgs e)
        {
            if (this.currentPageNo  < this.maxPageNo )                                                        //若当前页号尚未超出最大页号；
                this.currentPageNo ++;                                                                       //则当前页号递增；
            this.RefreshRowFilter();
        }

        private void NEnterDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            NurseHomepage nurseHomepage = new NurseHomepage();
            nurseHomepage.Show();
        }
    }
}
