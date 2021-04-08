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
    public partial class AdvicePackage : Form
    {
        private DataTable AdviceTable;
        public AdvicePackage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgv_DoctorAdvice .BackgroundColor = Color.White;
            this.dgv_DoctorAdvice.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            string flag=Search(1);
            if(flag=="0" )
            {
                MessageBox.Show("不存在该医嘱套餐，可进行新建！");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand insertCommand = sqlConnection.CreateCommand();
            insertCommand.CommandText = $@"INSERT tb_DoctorAdvice 
                                                    (AdviceTypeNo, SortNo, AdviceContent, Dose, Unit, Way, Frequency, Count, xie, Day, PackageNo, DoctorNo)
                                                VALUES
                                                    (@AdviceTypeNo,@SortNo,@AdviceContent,@Dose,@Unit,@Way,@Frequency,@Count,@xie,@Day,@PackageNo,'{Doctor.DoctorNo }')";
            insertCommand.Parameters.Add("@AdviceTypeNo", SqlDbType.Int,0,"AdviceTypeNo");
            insertCommand.Parameters.Add("@SortNo", SqlDbType.Int, 0, "SortNo");
            insertCommand.Parameters.Add("@AdviceContent", SqlDbType.VarChar, 0, "AdviceContent");
            insertCommand.Parameters.Add("@Dose", SqlDbType.VarChar, 0, "Dose");
            insertCommand.Parameters.Add("@Unit", SqlDbType.VarChar, 0, "Unit");
            insertCommand.Parameters.Add("@Way", SqlDbType.VarChar, 0, "Way");
            insertCommand.Parameters.Add("@Frequency", SqlDbType.VarChar, 0, "Frequency");
            insertCommand.Parameters.Add("@Count", SqlDbType.Int , 0, "Count");
            insertCommand.Parameters.Add("@xie", SqlDbType.Int , 0, "Xie");
            insertCommand.Parameters.Add("@Day", SqlDbType.VarChar, 0, "Day");
            insertCommand.Parameters.AddWithValue("@PackageNo", txt_Name.Text.Trim());

            SqlCommand updateCommand = sqlConnection.CreateCommand();
            updateCommand.CommandText = $@"UPDATE tb_DoctorAdvice
                                            SET
                                                AdviceTypeNo=@AdviceTypeNo,SortNo=@SortNo,AdviceContent=@AdviceContent,Dose=@Dose,Unit=@Unit,Way=@Way,Frequency=@Frequency,Count=@Count,xie=@xie,Day=@Day,DoctorNo='{Doctor.DoctorNo }'
                                        where AdviceContent=@OldAdviceContent and PackageNo=@PackageNo";
            updateCommand.Parameters.Add("@AdviceTypeNo", SqlDbType.Int, 0, "AdviceTypeNo");
            updateCommand.Parameters.Add("@SortNo", SqlDbType.Int, 0, "SortNo");
            updateCommand.Parameters.Add("@AdviceContent", SqlDbType.VarChar, 0, "AdviceContent");
            updateCommand.Parameters.Add("@Dose", SqlDbType.VarChar, 0, "Dose");
            updateCommand.Parameters.Add("@Unit", SqlDbType.VarChar, 0, "Unit");
            updateCommand.Parameters.Add("@Way", SqlDbType.VarChar, 0, "Way");
            updateCommand.Parameters.Add("@Frequency", SqlDbType.VarChar, 0, "Frequency");
            updateCommand.Parameters.Add("@Count", SqlDbType.Int, 0, "Count");
            updateCommand.Parameters.Add("@xie", SqlDbType.Int, 0, "Xie");
            updateCommand.Parameters.Add("@Day", SqlDbType.VarChar, 0, "Day");
            updateCommand.Parameters.AddWithValue("@PackageNo", txt_Name.Text.Trim());
            updateCommand.Parameters.Add("@OldAdviceContent", SqlDbType.VarChar, 0, "AdviceContent");
            updateCommand.Parameters["@OldAdviceContent"].SourceVersion = DataRowVersion.Original ;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.UpdateCommand = updateCommand;
            DataTable adviceTable = (DataTable)this.dgv_DoctorAdvice.DataSource;
            sqlConnection.Open();
            int rowaffected = sqlDataAdapter.Update(adviceTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowaffected }行。");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand deleteCommand = sqlConnection.CreateCommand();

            //SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            //sqlCommand1.CommandText = $@"select count(1) from tb_DoctorAdvice where PackageNo='{txt_Name.Text.Trim()}'";

            //sqlConnection.Open();
            //int flag=int.Parse(sqlCommand1.ExecuteScalar().ToString());
            //sqlConnection.Close();
            //if(flag==0)
            //{
            //    MessageBox.Show("无可删除行！");
            //    return;
            //}
            if(this.dgv_DoctorAdvice.CurrentCell==null)
            {
                MessageBox.Show("你未选中行！");
                return;
            }
            string adviceContent = dgv_DoctorAdvice .CurrentRow.Cells["AdviceContent"].Value.ToString();
            deleteCommand.CommandText = @"DELETE tb_DoctorAdvice
                                           where AdviceContent=@AdviceContent and PackageNo=@PackageNo";
            deleteCommand.Parameters.AddWithValue("@PackageNo", txt_Name.Text.Trim());
            deleteCommand.Parameters.AddWithValue ("@AdviceContent",adviceContent );
            sqlConnection.Open();
            deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("删除成功！");
            Search(1);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void AdvicePackage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
        private string  Search(int a)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_Type";
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand1.CommandText = $@"select count(1) from tb_DoctorAdvice where PackageNo='{txt_Name.Text.Trim()}'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable TypeTable = new DataTable();
            DataTable SortTable = new DataTable();
            DataTable adviceTable = new DataTable();
            string flag = null;
            sqlConnection.Open();
            sqlDataAdapter.Fill(TypeTable);
            sqlCommand.CommandText = $@"select * from tb_Sort";
            sqlDataAdapter.Fill(SortTable);
            sqlCommand.CommandText = $@"select * from tb_DoctorAdvice where PackageNo='{txt_Name.Text.Trim()}'";
            flag = sqlCommand1.ExecuteScalar().ToString();
            sqlDataAdapter.Fill(adviceTable);
            sqlConnection.Close();
            this.AdviceTable = adviceTable;
            this.dgv_DoctorAdvice.Columns.Clear();
            this.dgv_DoctorAdvice.DataSource = adviceTable;
            this.dgv_DoctorAdvice.Columns["AdviceContent"].HeaderText = "医嘱内容";
            this.dgv_DoctorAdvice.Columns["Dose"].HeaderText = "剂量";
            this.dgv_DoctorAdvice.Columns["Unit"].HeaderText = "单位";
            this.dgv_DoctorAdvice.Columns["Way"].HeaderText = "途径";
            this.dgv_DoctorAdvice.Columns["Frequency"].HeaderText = "频次";
            this.dgv_DoctorAdvice.Columns["Count"].HeaderText = "次";
            this.dgv_DoctorAdvice.Columns["xie"].HeaderText = "/";
            this.dgv_DoctorAdvice.Columns["Day"].HeaderText = "日";
            this.dgv_DoctorAdvice.Columns["AdviceTypeNo"].Visible = false;
            this.dgv_DoctorAdvice.Columns["SortNo"].Visible = false;
            this.dgv_DoctorAdvice.Columns["DoctorNo"].Visible = false;
            this.dgv_DoctorAdvice.Columns["PackageNo"].Visible = false;
            this.dgv_DoctorAdvice.Columns["No"].Visible = false;
            DataGridViewComboBoxColumn typeColumn = new DataGridViewComboBoxColumn();
            this.dgv_DoctorAdvice.Columns.Add(typeColumn);
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "长/临";
            typeColumn.DataSource = TypeTable;
            typeColumn.DisplayMember = "Name";
            typeColumn.ValueMember = "No";
            typeColumn.DataPropertyName = "AdviceTypeNo";
            typeColumn.DisplayIndex = 0;
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_DoctorAdvice.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewComboBoxColumn sortColumn = new DataGridViewComboBoxColumn();
            this.dgv_DoctorAdvice.Columns.Add(sortColumn);
            sortColumn.Name = "Sort";
            sortColumn.HeaderText = "类别";
            sortColumn.DataSource = SortTable;
            sortColumn.DisplayMember = "Name";
            sortColumn.ValueMember = "No";
            sortColumn.DataPropertyName = "SortNo";
            sortColumn.DisplayIndex = 1;
            sortColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_DoctorAdvice.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            return flag;
        }
    }
}
