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
    public partial class Advice : Form
    {
        public Advice()
        {
            InitializeComponent();
        }
        private DataTable AdviceTable;
        private string patientInHospitalNo;
        public Advice(string PatientInHospitalNo) : this()
        {
            this.patientInHospitalNo = PatientInHospitalNo;
            double money = 0;
            this.dgv_NotExecute.BackgroundColor = Color.White;
            dgv_NotExecute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Package.AllowUserToAddRows = false;
            this.dgv_Package.RowHeadersVisible = false;
            this.dgv_Package.BackgroundColor = Color.White;
            dgv_Package.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                lbl_PatientNo.Text = sqlDataReader["PatientNo"].ToString();
                money = Convert.ToDouble(sqlDataReader["Prepayment"].ToString());
            }
            sqlConnection.Close();
            if (money < 200)
            {
                MessageBox.Show($"{lbl_Name.Text}病人预交金不足！");
            }
            search1();
            searchPackage();
        }


        private void search1()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_Type";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable TypeTable = new DataTable();
            DataTable SortTable = new DataTable();
            this.AdviceTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(TypeTable);
            sqlCommand.CommandText = $@"select * from tb_Sort";
            sqlDataAdapter.Fill(SortTable);
            sqlCommand.CommandText = $@"select * from tb_PatientAdvice where PatientNo='{lbl_PatientNo.Text  }' and DoctorNo ='{Doctor.DoctorNo }' and isexecute is null";
            sqlDataAdapter.Fill(AdviceTable);
            sqlConnection.Close();
            this.dgv_NotExecute.Columns.Clear();
            this.dgv_NotExecute.DataSource = AdviceTable;
            this.dgv_NotExecute.Columns["GiveTime"].HeaderText = "下达时间";
            this.dgv_NotExecute.Columns["AdviceContent"].HeaderText = "医嘱内容";
            this.dgv_NotExecute.Columns["Dose"].HeaderText = "剂量";
            this.dgv_NotExecute.Columns["Unit"].HeaderText = "单位";
            this.dgv_NotExecute.Columns["Way"].HeaderText = "途径";
            this.dgv_NotExecute.Columns["Frequency"].HeaderText = "频次";
            this.dgv_NotExecute.Columns["Count"].HeaderText = "次";
            this.dgv_NotExecute.Columns["xie"].HeaderText = "/";
            this.dgv_NotExecute.Columns["Day"].HeaderText = "日";
            this.dgv_NotExecute.Columns["lastTime"].HeaderText = "持续时间（天）";
            this.dgv_NotExecute.Columns["ExecuteTime"].HeaderText = "执行时间";
            this.dgv_NotExecute.Columns["AdviceTypeNo"].Visible = false;
            this.dgv_NotExecute.Columns["SortNo"].Visible = false;
            this.dgv_NotExecute.Columns["DoctorNo"].Visible = false;
            this.dgv_NotExecute.Columns["No"].Visible = false;
            this.dgv_NotExecute.Columns["IsFinish"].Visible = false;
            this.dgv_NotExecute.Columns["PatientNo"].Visible = false;
            this.dgv_NotExecute.Columns["StartTime"].Visible = false;
            this.dgv_NotExecute.Columns["isexecute"].Visible = false;
            DataGridViewComboBoxColumn typeColumn = new DataGridViewComboBoxColumn();
            this.dgv_NotExecute.Columns.Add(typeColumn);
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "长/临";
            typeColumn.DataSource = TypeTable;
            typeColumn.DisplayMember = "Name";
            typeColumn.ValueMember = "No";
            typeColumn.DataPropertyName = "AdviceTypeNo";
            typeColumn.DisplayIndex = 0;
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_NotExecute.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewComboBoxColumn sortColumn = new DataGridViewComboBoxColumn();
            this.dgv_NotExecute.Columns.Add(sortColumn);
            sortColumn.Name = "Sort";
            sortColumn.HeaderText = "类别";
            sortColumn.DataSource = SortTable;
            sortColumn.DisplayMember = "Name";
            sortColumn.ValueMember = "No";
            sortColumn.DataPropertyName = "SortNo";
            sortColumn.DisplayIndex = 1;
            sortColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_NotExecute.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
        private void searchPackage()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_Type";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable TypeTable = new DataTable();
            DataTable SortTable = new DataTable();
            DataTable adviceTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(TypeTable);
            sqlCommand.CommandText = $@"select * from tb_Sort";
            sqlDataAdapter.Fill(SortTable);
            sqlCommand.CommandText = $@"select * from tb_DoctorAdvice ";
            sqlDataAdapter.Fill(adviceTable);
            sqlConnection.Close();
            this.dgv_Package.Columns.Clear();
            this.dgv_Package.DataSource = adviceTable;
            this.dgv_Package.Columns["PackageNo"].HeaderText = "套餐号";
            this.dgv_Package.Columns["AdviceContent"].HeaderText = "医嘱内容";
            this.dgv_Package.Columns["Dose"].HeaderText = "剂量";
            this.dgv_Package.Columns["Unit"].HeaderText = "单位";
            this.dgv_Package.Columns["Way"].HeaderText = "途径";
            this.dgv_Package.Columns["Frequency"].HeaderText = "频次";
            this.dgv_Package.Columns["Count"].HeaderText = "次";
            this.dgv_Package.Columns["xie"].HeaderText = "/";
            this.dgv_Package.Columns["Day"].HeaderText = "日";
            this.dgv_Package.Columns["AdviceTypeNo"].Visible = false;
            this.dgv_Package.Columns["SortNo"].Visible = false;
            this.dgv_Package.Columns["No"].Visible = false;
            this.dgv_Package.Columns["doctorno"].Visible = false;
            DataGridViewComboBoxColumn typeColumn = new DataGridViewComboBoxColumn();
            this.dgv_Package.Columns.Add(typeColumn);
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "长/临";
            typeColumn.DataSource = TypeTable;
            typeColumn.DisplayMember = "Name";
            typeColumn.ValueMember = "No";
            typeColumn.DataPropertyName = "AdviceTypeNo";
            typeColumn.DisplayIndex = 0;
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewComboBoxColumn sortColumn = new DataGridViewComboBoxColumn();
            this.dgv_Package.Columns.Add(sortColumn);
            sortColumn.Name = "Sort";
            sortColumn.HeaderText = "类别";
            sortColumn.DataSource = SortTable;
            sortColumn.DisplayMember = "Name";
            sortColumn.ValueMember = "No";
            sortColumn.DataPropertyName = "SortNo";
            sortColumn.DisplayIndex = 1;
            sortColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_NotExecute.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }



        private void btn_Submit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("现在就提交现在的医嘱吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
                SqlCommand insertCommand = sqlConnection.CreateCommand();
                insertCommand.CommandText = $@"INSERT tb_PatientAdvice 
                                                    (AdviceTypeNo, SortNo,GiveTime, AdviceContent, Dose, Unit, Way, Frequency, Count, xie, Day, ExecuteTime,lastTime, DoctorNo,PatientNo ,StartTime,isfinish)
                                                VALUES
                                                    (@AdviceTypeNo,@SortNo,@GiveTime,@AdviceContent,@Dose,@Unit,@Way,@Frequency,@Count,@xie,@Day,@ExecuteTime,@lastTime, '{Doctor.DoctorNo }','{lbl_PatientNo.Text}','{DateTime.Now}','否')";
                insertCommand.Parameters.Add("@AdviceTypeNo", SqlDbType.Int, 0, "AdviceTypeNo");
                insertCommand.Parameters.Add("@SortNo", SqlDbType.Int, 0, "SortNo");
                insertCommand.Parameters.Add("@GiveTime", SqlDbType.Date, 0, "GiveTime");
                insertCommand.Parameters.Add("@AdviceContent", SqlDbType.VarChar, 0, "AdviceContent");
                insertCommand.Parameters.Add("@Dose", SqlDbType.VarChar, 0, "Dose");
                insertCommand.Parameters.Add("@Unit", SqlDbType.VarChar, 0, "Unit");
                insertCommand.Parameters.Add("@Way", SqlDbType.VarChar, 0, "Way");
                insertCommand.Parameters.Add("@Frequency", SqlDbType.VarChar, 0, "Frequency");
                insertCommand.Parameters.Add("@Count", SqlDbType.Int, 0, "Count");
                insertCommand.Parameters.Add("@xie", SqlDbType.Int, 0, "Xie");
                insertCommand.Parameters.Add("@Day", SqlDbType.VarChar, 0, "Day");
                insertCommand.Parameters.Add("@ExecuteTime", SqlDbType.VarChar, 0, "ExecuteTime");
                insertCommand.Parameters.Add("@lastTime", SqlDbType.VarChar, 0, "lastTime");
                SqlCommand updateCommand = sqlConnection.CreateCommand();
                updateCommand.CommandText = $@"UPDATE tb_patientAdvice
                                            SET
                                                AdviceTypeNo=@AdviceTypeNo,SortNo=@SortNo,Givetime=@GiveTime,AdviceContent=@AdviceContent,Dose=@Dose,Unit=@Unit,Way=@Way,Frequency=@Frequency,Count=@Count,xie=@xie,Day=@Day,ExecuteTime=@ExecuteTime,lastTime=@lastTime,StartTime='{DateTime.Now }'
                                        where AdviceContent=@OldAdviceContent and  doctorno='{Doctor.DoctorNo }' and patientno='{lbl_PatientNo.Text  }' and starttime is null ";
                updateCommand.Parameters.Add("@AdviceTypeNo", SqlDbType.Int, 0, "AdviceTypeNo");
                updateCommand.Parameters.Add("@SortNo", SqlDbType.Int, 0, "SortNo");
                updateCommand.Parameters.Add("@GiveTime", SqlDbType.Date, 0, "GiveTime");
                updateCommand.Parameters.Add("@AdviceContent", SqlDbType.VarChar, 0, "AdviceContent");
                updateCommand.Parameters.Add("@Dose", SqlDbType.VarChar, 0, "Dose");
                updateCommand.Parameters.Add("@Unit", SqlDbType.VarChar, 0, "Unit");
                updateCommand.Parameters.Add("@Way", SqlDbType.VarChar, 0, "Way");
                updateCommand.Parameters.Add("@Frequency", SqlDbType.VarChar, 0, "Frequency");
                updateCommand.Parameters.Add("@Count", SqlDbType.Int, 0, "Count");
                updateCommand.Parameters.Add("@xie", SqlDbType.Int, 0, "Xie");
                updateCommand.Parameters.Add("@Day", SqlDbType.VarChar, 0, "Day");
                updateCommand.Parameters.Add("@ExecuteTime", SqlDbType.VarChar, 0, "ExecuteTime");
                updateCommand.Parameters.Add("@lastTime", SqlDbType.VarChar, 0, "lastTime");
                updateCommand.Parameters.Add("@OldAdviceContent", SqlDbType.VarChar, 0, "AdviceContent");
                updateCommand.Parameters["@OldAdviceContent"].SourceVersion = DataRowVersion.Original;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.InsertCommand = insertCommand;
                sqlDataAdapter.UpdateCommand = updateCommand;
                DataTable adviceTable = (DataTable)this.dgv_NotExecute.DataSource;
                sqlConnection.Open();
                int rowaffected = sqlDataAdapter.Update(adviceTable);
                sqlConnection.Close();
                if (rowaffected != 0)
                {
                    MessageBox.Show("提交成功！");
                }
                else
                {
                    MessageBox.Show($"{rowaffected }提交失败！");
                }
            }
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("已取消！");
            }
            search1();
        }

        private void Advice_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void btn_SearchAdvice_Click(object sender, EventArgs e)
        {
            SearchAdvice searchAdvice = new SearchAdvice(patientInHospitalNo);
            searchAdvice.Show();
        }

        private void btn_Upper_Click(object sender, EventArgs e)
        {
            if (dgv_Package.RowCount == 0)
            {
                return;
            }
            DataRowView currentRowView = this.dgv_Package.CurrentRow.DataBoundItem as DataRowView;
            DataRow
                currentRow = currentRowView.Row
                , selectedRow = this.AdviceTable.NewRow();
            selectedRow["AdviceTypeNo"] = currentRow["AdviceTypeNo"];
            selectedRow["SortNo"] = currentRow["SortNo"];
            selectedRow["AdviceContent"] = currentRow["AdviceContent"];
            selectedRow["Dose"] = currentRow["Dose"];
            selectedRow["unit"] = currentRow["unit"];
            selectedRow["way"] = currentRow["way"];
            selectedRow["Frequency"] = currentRow["Frequency"];
            selectedRow["Count"] = currentRow["Count"];
            selectedRow["xie"] = currentRow["xie"];
            selectedRow["Day"] = currentRow["Day"];
            this.AdviceTable.Rows.Add(selectedRow);


        }
        /// <summary>
        /// 删除按钮;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string adviceContent = dgv_NotExecute.CurrentRow.Cells["AdviceContent"].Value.ToString();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand deleteCommand = sqlConnection.CreateCommand();
            deleteCommand.CommandText = $@"delete tb_PatientAdvice where AdviceContent='{adviceContent }'  and ISExecute is null and patientno='{lbl_PatientNo.Text }'";
            MessageBox.Show(deleteCommand.CommandText);
            sqlConnection.Open();
            int count = deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show($"{count}删除成功！");
            search1();
        }
    }
}
