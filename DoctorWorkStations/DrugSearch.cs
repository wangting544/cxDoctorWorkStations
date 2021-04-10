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
    public partial class DrugSearch : Form
    {
        public DrugSearch()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            gb_Name.Visible = false;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM TB_DRUG";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            cb_drug.DataSource = dataTable;
            cb_drug.DisplayMember = "ChineseName";
            cb_drug.ValueMember = "No";
            sqlConnection.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true ;
            gb_Name.Visible = true ;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"SELECT * FROM TB_DRUG where No='{cb_drug.SelectedValue }'";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if(sqlDataReader.Read())
            {
                txt_ChineseName.Text ="中文名：" + sqlDataReader["Chinesename"].ToString();
                txt_EnglishName.Text="英文名："+ sqlDataReader["EnglishName"].ToString();
                txt_Effect.Text= sqlDataReader["effect"].ToString();
            }
            sqlDataReader.Close();

        }
    }
}
