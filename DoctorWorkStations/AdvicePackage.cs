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
            this.dgv_DoctorAdvice .RowHeadersVisible = false;
            this.dgv_DoctorAdvice .BackgroundColor = Color.White;
            this.dgv_DoctorAdvice.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn_Search_Click(object sender, EventArgs e)
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
            sqlDataAdapter.Fill(SortTable );
            sqlCommand.CommandText = $@"select * from tb_DoctorAdvice where PackageNo='{txt_Name.Text.Trim()}'";
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
            this.dgv_DoctorAdvice.Columns["AdviceTypeNo"].Visible =false ;
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
            typeColumn .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_DoctorAdvice .Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewComboBoxColumn sortColumn = new DataGridViewComboBoxColumn();
            this.dgv_DoctorAdvice.Columns.Add(sortColumn);
            sortColumn.Name = "Sort";
            sortColumn.HeaderText = "类别";
            sortColumn.DataSource = SortTable ;
            sortColumn.DisplayMember = "Name";
            sortColumn.ValueMember = "No";
            sortColumn.DataPropertyName = "SortNo";
            sortColumn.DisplayIndex = 1;
            sortColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_DoctorAdvice.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
