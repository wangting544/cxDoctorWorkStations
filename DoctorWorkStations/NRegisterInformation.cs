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
    public partial class NRegisterInformation : Form
    {
        public NRegisterInformation()
        {
            InitializeComponent();
            Department();
            SearchSignRecord();
            Diagnosis();
        }

        private void SearchSignRecord()
        {                                                      //数据网格视图的行标题不可见；
            this.dgv_SignRecord.BackgroundColor = Color.White;                                                  //数据网格视图的背景色设为白色；
            this.dgv_SignRecord.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select * from tb_SignRecord where patientNo='{txt_PatientNo.Text }' and RecordDate='{dtp_Time.Value }'";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_SignRecord.DataSource = dataTable;
            dgv_SignRecord.Columns["RecordDate"].HeaderText = "登记日期";
            dgv_SignRecord.Columns["RecordTime"].HeaderText = "登记时间";
            dgv_SignRecord.Columns["Temperature"].HeaderText = "体温（℃）";
            dgv_SignRecord.Columns["Pluse"].HeaderText = "脉搏（次/分）";
            dgv_SignRecord.Columns["Breathe"].HeaderText = "呼吸（次/分）";
            dgv_SignRecord.Columns["No"].Visible = false;
            dgv_SignRecord.Columns["PatientNo"].Visible = false;
            dgv_SignRecord.Columns["NurseNo"].Visible = false;
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
            BedNo();
        }
        private void Doctors()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select * from tb_doctor where departmentno='{cb_Department.SelectedValue }' and status=''";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            cb_doctor .DataSource = dataTable;
            cb_doctor .DisplayMember = "Name";
            cb_doctor .ValueMember = "No";
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
            cb_Bed .DataSource = dataTable;
            cb_Bed .DisplayMember = "Name";
            cb_Bed .ValueMember = "Name";
            sqlConnection.Close();
        }
        private void BedNo1()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select *
                                            from tb_Bed as b
                                            join tb_Department as d on d.Name=b.department 
                                       ";
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
            string sex;
            if(rbtn_Female.Checked )
            {
                sex = "女";
            }
            else
            {
                sex = "男";
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sql = sqlConnection.CreateCommand();
            sql.CommandText = $"select 1 from tb_PatientInHosptial  where No='{txt_InHosptial.Text}'";
            string c = "0";
            sqlConnection.Open();
            c = sql.ExecuteScalar().ToString();
            sqlConnection.Close();
            if(c=="1")
            {
                sql.CommandText = $"update tb_Patient" +
                    $"Name='{txt_Name.Text}'" +
                    $"Sex='{sex}'" +
                    $"Birthday='{dtp_Birthday.Value }'" +
                    $"Work='{txt_Work.Text }'" +
                    $"NurseNo='{Doctor.DoctorNo }'" +
                    $"where no={txt_PatientNo }";
                SqlCommand sql1 = sqlConnection.CreateCommand();
                sql1.CommandText = $@"update tb_PatientInHosptial 
                                    SET No='{txt_InHosptial.Text }'
	                                    ,BedNo ='{cb_Bed.SelectedValue }'
	                                    ,AdmissionDate='{dtp_AdmWard.Value }'
	                                    ,PrincipalDiagnosis='{txt_Dialogue.Text }'
	                                    ,DoctorNo='{cb_doctor.SelectedValue }'
	                                    ,Prepayment='{txt_Prepayment.Text }'
                                    WHERE
	                                    PatientNo='{txt_PatientNo.Text }'";
                int f=0;
                sqlConnection.Open();
                f=sql.ExecuteNonQuery() + sql1.ExecuteNonQuery(); ;
                sqlConnection.Close();
                if(f!=0)
                {
                    MessageBox.Show("保存成功");
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
                return;
            }
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"
                                        INSERT tb_Patient
                                        (No, Name, Sex, Birthday, Work )
                                        VALUES
                                        ('{txt_PatientNo.Text  }', '{txt_Name.Text  }', '{sex }', '{dtp_Birthday.Value }', '{txt_Work.Text }')";
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand1.CommandText = $@"INSERT tb_PatientInHosptial 
                                            (No,PatientNo ,BedNo ,AdmissionDate ,PrincipalDiagnosis,DoctorNo,prepayment,NurseNo )
                                        VALUES
                                            ('{txt_InHosptial.Text }','{txt_PatientNo.Text }','{cb_Bed.SelectedValue }','{dtp_AdmWard.Value}','{txt_Dialogue.Text }','{cb_doctor.SelectedValue }','{txt_Prepayment.Text }','{Doctor.DoctorNo }')";
            int count = 0;
            sqlConnection.Open();
            count =sqlCommand.ExecuteNonQuery() + sqlCommand1.ExecuteNonQuery();
            sqlConnection.Close();
            if(count !=0)
            {
                MessageBox.Show("保存成功！");
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            txt_Dialogue.Text = "";
            txt_InHosptial.Text = "";
            txt_Name.Text = "";
            txt_Prepayment.Text = "";
            txt_Work.Text = "";
            BedNo1();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select count(1) from tb_Patient where No='{txt_PatientNo.Text }'";
            int count = 0;
            sqlConnection.Open();
            count = int.Parse(sqlCommand.ExecuteScalar().ToString());
            sqlConnection.Close();
            if(count==0)
            {
                MessageBox.Show("该病人不存在！");
                return;
            }
            SearchSignRecord();
            Department();
            Doctors();
            sqlCommand.CommandText = $@"SELECT
	                                        PA.No as PatientNo
	                                        ,PA.Name 
	                                        ,PA.Sex
	                                        ,PA.Birthday
	                                        ,PA.Work 
	                                        ,P.No
	                                        ,P.AdmissionDate
	                                        ,P.BedNo as bed
	                                        ,P.PrincipalDiagnosis
	                                        ,P.Prepayment
	                                        ,d.departmentno
                                            ,PA.Photo
                                            ,p.Doctorno
                                        FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No=P.PatientNo 
                                            join tb_doctor as d on d.no=p.doctorno
                                        WHERE Pa.No='{ txt_PatientNo .Text}' and p.flag is null";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txt_PatientNo.Text = sqlDataReader["PatientNo"].ToString();
                txt_Name.Text = sqlDataReader["Name"].ToString();
                string sex = sqlDataReader["Sex"].ToString();
                if (sex == "男")
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
                dtp_AdmWard .Value = (DateTime)sqlDataReader["AdmissionDate"];
                cb_Bed.SelectedValue = sqlDataReader["bed"].ToString();
                txt_Dialogue.Text = sqlDataReader["PrincipalDiagnosis"].ToString();
                txt_Prepayment.Text = sqlDataReader["Prepayment"].ToString();
                cb_doctor.SelectedValue = sqlDataReader["doctorno"].ToString();
                cb_Department.SelectedValue = sqlDataReader["departmentno"].ToString();
            }
            sqlDataReader.Close();
            SearchSignRecord();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand insertCommand = sqlConnection.CreateCommand();
            insertCommand.CommandText = $@"insert tb_SignRecord 
                                            (RecordDate ,RecordTime,Temperature,Pluse,Breathe,PatientNo,NurseNo )
                                        values
                                            (@RecordDate ,@RecordTime,@Temperature,@Pluse,@Breathe,'{txt_PatientNo.Text }','{Doctor.DoctorNo }' )";
            insertCommand.Parameters.Add("@RecordDate", SqlDbType.Date, 0, "RecordDate");
            insertCommand.Parameters.Add("@RecordTime", SqlDbType.VarChar, 0, "RecordTime");
            insertCommand.Parameters.Add("@Temperature", SqlDbType.Int, 0, "Temperature");
            insertCommand.Parameters.Add("@Pluse", SqlDbType.Int, 0, "Pluse");
            insertCommand.Parameters.Add("@Breathe", SqlDbType.Int, 0, "Breathe");

            SqlCommand updateCommand = sqlConnection.CreateCommand();
            updateCommand.CommandText = $@"update tb_SignRecord 
                                            set RecordDate= @RecordDate ,RecordTime= @RecordTime,Temperature= @Temperature,Pluse= @Pluse,Breathe = @Breathe,PatientNo= '{txt_PatientNo.Text }',NurseNo= '{Doctor.DoctorNo }'
                                         where RecordDate=@Date  and RecordTime= @Time and PatientNo='{txt_PatientNo.Text }' and NurseNo='{Doctor.DoctorNo }'";
            updateCommand .Parameters.Add("@RecordDate", SqlDbType.Date, 0, "RecordDate");
            updateCommand.Parameters.Add("@RecordTime", SqlDbType.VarChar, 0, "RecordTime");
            updateCommand.Parameters.Add("@Temperature", SqlDbType.Int, 0, "Temperature");
            updateCommand.Parameters.Add("@Pluse", SqlDbType.Int, 0, "Pluse");
            updateCommand.Parameters.Add("@Breathe", SqlDbType.Int, 0, "Breathe");
            updateCommand.Parameters.Add("@Date", SqlDbType.Date , 0, "RecordDate");
            updateCommand.Parameters["@Date"].SourceVersion = DataRowVersion.Original;
            updateCommand.Parameters.Add("@Time", SqlDbType.VarChar, 0, "RecordTime");
            updateCommand.Parameters["@Time"].SourceVersion = DataRowVersion.Original;

           
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.UpdateCommand = updateCommand;
            
            DataTable dataTable = (DataTable)this.dgv_SignRecord.DataSource;
            sqlConnection.Open();
            int r = sqlDataAdapter.Update(dataTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{r}行");
            SearchSignRecord();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.dgv_SignRecord .CurrentCell == null)
            {
                MessageBox.Show("你未选中！");
                return;
            }
            string RecordDate = dgv_SignRecord .CurrentRow.Cells["RecordDate"].Value.ToString();
            string RecordTime = dgv_SignRecord.CurrentRow.Cells["RecordTime"].Value.ToString();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand deleteCommand = sqlConnection.CreateCommand();
            deleteCommand.CommandText = $@"delete tb_signRecord where  RecordDate='{RecordDate }'  and RecordTime= '{RecordTime}' and PatientNo='{txt_PatientNo.Text }' and NurseNo='{Doctor.DoctorNo }' ";
            sqlConnection.Open();
            int r=deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show($"删除{r}行");
            SearchSignRecord();
        }

        private void btn_Search1_Click(object sender, EventArgs e)
        {
            this.dgv_Search .AllowUserToAddRows = false;
            this.dgv_Search .RowHeadersVisible = false;
            this.dgv_Search .BackgroundColor = Color.White;                                                  //数据网格视图的背景色设为白色；
            this.dgv_Search .AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select * from tb_SignRecord where patientNo='{txt_PatientNo.Text }' and  RecordDate='{dtp_SearchTime .Value }'";
            if(txt_SearchTime.Text.Trim() !="" )
            {
                sqlCommand.CommandText += $" and recordTime='{txt_SearchTime.Text }'";
            }
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Search .DataSource = dataTable;
            dgv_Search .Columns["RecordDate"].HeaderText = "登记日期";
            dgv_Search .Columns["RecordTime"].HeaderText = "登记时间";
            dgv_Search .Columns["Temperature"].HeaderText = "体温（℃）";
            dgv_Search .Columns["Pluse"].HeaderText = "脉搏（次/分）";
            dgv_Search .Columns["Breathe"].HeaderText = "呼吸（次/分）";
            dgv_Search .Columns["No"].Visible = false;
            dgv_Search .Columns["PatientNo"].Visible = false;
            dgv_Search .Columns["NurseNo"].Visible = false;
        }
        //诊断记录
        private void Diagnosis()
        {
            this.dgv_Diagnosis.AllowUserToAddRows = false;
            this.dgv_Diagnosis.RowHeadersVisible = false;
            this.dgv_Diagnosis.BackgroundColor = Color.White;
            dgv_Diagnosis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ToString();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select *  from tb_Diagnosis where PatientNo ='{txt_PatientNo.Text }'";
            DataTable dataTable = new DataTable();
            DataTable doctorTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Diagnosis.DataSource = dataTable;
            this.dgv_Diagnosis.Columns["Type"].HeaderText = "  ";
            this.dgv_Diagnosis.Columns["Description"].HeaderText = "诊断描述";
            this.dgv_Diagnosis.Columns["Result"].HeaderText = "结果";
            this.dgv_Diagnosis.Columns["Days"].HeaderText = "天数";
            this.dgv_Diagnosis.Columns["Operate"].HeaderText = "手术";
            this.dgv_Diagnosis.Columns["DiagnosisDate"].HeaderText = "确诊日期";
            this.dgv_Diagnosis.Columns["No"].Visible = false;
            this.dgv_Diagnosis.Columns["PatientNo"].Visible = false;
            this.dgv_Diagnosis.Columns["DoctorNo"].Visible = false;
            this.dgv_Diagnosis .Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void NRegisterInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            NurseHomepage nurseHomepage = new NurseHomepage();
            this.Close();
        }
    }
}
