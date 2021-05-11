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
    public partial class Temperature : Form
    {
        string PatientNo;
        public Temperature()
        {
            InitializeComponent();
        }
        public Temperature(string Patientno):this()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select Name from tb_Patient where No='{Patientno}'";
            sqlConnection.Open();
            string Name = sqlCommand.ExecuteScalar().ToString();
            sqlConnection.Close();
            label2.Text = $"{Name }的体症记录";
            this.PatientNo = Patientno;
            SearchAll1();
        }
        //查询
        private void Search1()
        {
            this.dgv_Record .AllowUserToAddRows = false;
            this.dgv_Record .RowHeadersVisible = false;
            this.dgv_Record .BackgroundColor = Color.White;                                                  //数据网格视图的背景色设为白色；
            this.dgv_Record .AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select * from tb_SignRecord where patientNo='{PatientNo}' and  RecordDate='{dtp_date .Value }'";
            if (txt_time .Text.Trim() != "")
            {
                sqlCommand.CommandText += $" and recordTime='{txt_time .Text }'";
            }
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Record  .DataSource = dataTable;
            dgv_Record .Columns["RecordDate"].HeaderText = "登记日期";
            dgv_Record .Columns["RecordTime"].HeaderText = "登记时间";
            dgv_Record .Columns["Temperature"].HeaderText = "体温  ℃";
            dgv_Record .Columns["Pluse"].HeaderText = "脉搏  次/分";
            dgv_Record .Columns["Breathe"].HeaderText = "呼吸  次/分";
            dgv_Record .Columns["No"].Visible = false;
            dgv_Record .Columns["PatientNo"].Visible = false;
            dgv_Record .Columns["NurseNo"].Visible = false;
        }
        //查询所有
        private void SearchAll1()
        {
            this.dgv_Record.AllowUserToAddRows = false;
            this.dgv_Record.RowHeadersVisible = false;
            this.dgv_Record.BackgroundColor = Color.White;                                                  //数据网格视图的背景色设为白色；
            this.dgv_Record.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select * from tb_SignRecord where patientNo='{PatientNo}'";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Record.DataSource = dataTable;
            dgv_Record.Columns["RecordDate"].HeaderText = "登记日期";
            dgv_Record.Columns["RecordTime"].HeaderText = "登记时间";
            dgv_Record.Columns["Temperature"].HeaderText = "体温（℃）";
            dgv_Record.Columns["Pluse"].HeaderText = "脉搏（次/分）";
            dgv_Record.Columns["Breathe"].HeaderText = "呼吸（次/分）";
            dgv_Record.Columns["No"].Visible = false;
            dgv_Record.Columns["PatientNo"].Visible = false;
            dgv_Record.Columns["NurseNo"].Visible = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search1();
        }

        private void btn_SearchAll_Click(object sender, EventArgs e)
        {
            SearchAll1();
        }

        private void Temperature_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
