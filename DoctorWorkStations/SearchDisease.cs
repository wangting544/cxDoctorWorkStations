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
    public partial class SearchDisease : Form
    {
        public SearchDisease()
        {
            InitializeComponent();
            Search();
        }
        private DataTable dataTable;
        private void Search()
        {
            this.dgv_Search .AllowUserToAddRows = false;                                                     //数据网格视图不允许用户添加行；
            this.dgv_Search .RowHeadersVisible = false;                                                      //数据网格视图的行标题不可见；
            this.dgv_Search .BackgroundColor = Color.White;                                                  //数据网格视图的背景色设为白色；
            this.dgv_Search .AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select 
                                           p.No,p.Name, Description 
                                        from tb_Diagnosis as d
                                        join tb_Patient as p on d.PatientNo=p.No 
                                        where d.Description is not null";
            dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Search.DataSource = dataTable;
            this.dgv_Search .Columns["No"].HeaderText = "病人号";
            this.dgv_Search.Columns["Name"].HeaderText = "名字";
            this.dgv_Search.Columns["Description"].HeaderText = "病症描述";
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            var SearchResultRows = this.dataTable .Select($"Description LIKE '%{txt_Search .Text.Trim()}%'");
            DataTable dataTable = this.dataTable .Clone();
            foreach (var item in SearchResultRows)
            {
                dataTable.ImportRow(item);
            }
            this.dgv_Search .DataSource = dataTable;
        }

        private void btn_Ensure_Click(object sender, EventArgs e)
        {
            if (this.dgv_Search .CurrentCell == null)
            {
                MessageBox.Show("你未选中！");
                return;
            }
            string No = dgv_Search.CurrentRow.Cells["No"].Value.ToString();
            DialogResult dr = MessageBox.Show($"现在就打开{No}的病历？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
                return;
            string fileName = $"C:\\Users\\从心\\Desktop\\文件夹\\大二下\\医药数据库技术\\病程\\{No  }的病历.docx";
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void SearchDisease_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
