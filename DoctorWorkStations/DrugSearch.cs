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
        private DataTable drugTable;
        private DataView drugViewByName;
        public DrugSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;                                            //本窗体启动位置设为屏幕中央； 
            this.dgv_Drug .AllowUserToAddRows = false;                                                     //数据网格视图不允许用户添加行；
            this.dgv_Drug .RowHeadersVisible = false;                                                      //数据网格视图的行标题不可见；
            this.dgv_Drug .BackgroundColor = Color.White;                                                  //数据网格视图的背景色设为白色；
            this.dgv_Drug .AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            Search();
        }
        private void Search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from tb_drug";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            this.drugTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(this.drugTable);
            sqlConnection.Close();
            this.drugViewByName = new DataView();
            this.drugViewByName.Table = drugTable;
            this.drugViewByName.Sort = "ChineseName ASC";
            this.dgv_Drug.Columns.Clear();
            this.dgv_Drug.DataSource = drugTable;
            this.dgv_Drug.Columns["No"].HeaderText = "编号";
            this.dgv_Drug.Columns["ChineseName"].HeaderText = "名称";
            this.dgv_Drug.Columns["pinyin"].HeaderText = "拼音";
            this.dgv_Drug.Columns["effect"].HeaderText = "疗效";
            this.dgv_Drug.Columns[this.dgv_Drug .Columns.Count - 1].AutoSizeMode =                       //数据网格视图的倒数第2列（即考试类型列）的自动调整列宽模式设为填充（至数据网格视图右侧边缘）；
               DataGridViewAutoSizeColumnMode.Fill;

        }
        //按照编号查找
        private void btn_SearchByNo_Click(object sender, EventArgs e)
        {
            DataRow searchReauleRow = this.drugTable.Rows.Find(this.txt_No.Text.Trim());
            DataTable searchReaultTable = this.drugTable.Clone();
            searchReaultTable.ImportRow(searchReauleRow);
            this.dgv_Drug.DataSource = searchReaultTable;
        }

        private void btn_SearchByName_Click(object sender, EventArgs e)
        {
            var SearchResultRowViews = this.drugViewByName.FindRows(this.txt_Name.Text.Trim())[0];
            DataTable dataTable = this.drugTable.Clone();
            dataTable.ImportRow(SearchResultRowViews.Row);
            dgv_Drug.DataSource = dataTable;
        }

        private void txt_Py_TextChanged(object sender, EventArgs e)
        {
            var SearchResultRows = this.drugTable.Select($"pinyin LIKE '%{txt_Py.Text.Trim()}%'");
            DataTable dataTable = this.drugTable.Clone();
            foreach (var item in SearchResultRows )
            {
                dataTable.ImportRow(item);
            }
            this.dgv_Drug.DataSource = dataTable;
        }

        private void DrugSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
