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
    public partial class NSearchOperation : Form
    {
        public NSearchOperation()
        {
            InitializeComponent();
        }
        public string patientNo;
        public NSearchOperation(string PatientNo):this()
        {
            this.patientNo = PatientNo;
            SearchOperation();
        }
        /// <summary>
        /// 查看手术信息
        /// </summary>
        private void SearchOperation()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select * from tb_operation where patientNo='{patientNo}' ";
            DataTable operationTable = new DataTable();
            DataTable doctorTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(operationTable);
            sqlCommand.CommandText = $@"select * from tb_doctor";
            sqlDataAdapter.Fill(doctorTable);
            sqlConnection.Close();
            dgv_Operation.Columns.Clear();
            dgv_Operation.DataSource = operationTable;
            DataGridViewComboBoxColumn DoctorColumn = new DataGridViewComboBoxColumn();
            dgv_Operation.Columns.Add(DoctorColumn);
            DoctorColumn.Name = "Doctor";
            DoctorColumn.HeaderText = "主刀医生";
            DoctorColumn.DataSource = doctorTable;
            DoctorColumn.DisplayMember = "Name";
            DoctorColumn.ValueMember = "No";
            DoctorColumn.DataPropertyName = "doctorNo";
            DoctorColumn.DisplayIndex = 5;
            dgv_Operation.Columns["no"].HeaderText = "编号";
            dgv_Operation.Columns["OperateName"].HeaderText = "手术名称";
            dgv_Operation.Columns["StartTime"].HeaderText = "开始时间";
            dgv_Operation.Columns["EndTime"].HeaderText = "结束时间";
            dgv_Operation.Columns["IsExecute"].HeaderText = "是否执行";
            dgv_Operation.Columns["DoctorNo"].Visible = false;
            dgv_Operation.Columns["PatientNo"].Visible = false;

        }
    }
}
