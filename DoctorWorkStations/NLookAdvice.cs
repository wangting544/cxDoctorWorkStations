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
    public partial class NLookAdvice : Form
    {
        public NLookAdvice()
        {
            InitializeComponent();
            this.dgv_Advice.AllowUserToAddRows = false;
            this.dgv_Advice.RowHeadersVisible = false;
            this.dgv_Advice.BackgroundColor = Color.White;
            dgv_Advice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            rbtn_All.Checked = true;
            Search();
            E();
        }
        /// <summary>
        /// 查看医嘱
        /// </summary>
        private void Search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select P.Name as PatientName,D.Name as DoctorName,givetime, t.Name as TypeName,s.Name as SortName ,
                                        AdviceContent,Dose,Unit,Way,Frequency,Count,xie,Day ,ExecuteTime,LastTime,P.no as patientno
                                        from tb_PatientAdvice as PA
                                        join tb_Patient as P on P.No = PA.PatientNo
                                        join tb_Doctor as D on D.No = PA.DoctorNo
                                        join tb_Type as t on t.No = pa.AdviceTypeNo
                                        join tb_Sort as s on s.No = PA.SortNo 
                                        ";
            if(rbtn_Stop .Checked )
            {
                sqlCommand.CommandText += "  where isexecute=0  ";
            }
            if(rbtn_Executing .Checked )
            {
                sqlCommand.CommandText += "  where  isFinish = '否' and isexecute =1";
            }
            if(rbtn_executed .Checked )
            {
                sqlCommand.CommandText += "  where  isFinish='是' and isexecute=1";
            }
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Advice.DataSource = dataTable;
            dgv_Advice.Columns["PatientName"].HeaderText = "病人姓名";
            dgv_Advice.Columns["DoctorName"].HeaderText = "医生";
            dgv_Advice.Columns["TypeName"].HeaderText = "长/短期";
            dgv_Advice.Columns["SortName"].HeaderText = "类别";
            dgv_Advice.Columns["givetime"].HeaderText = "类别";
            dgv_Advice.Columns["AdviceContent"].HeaderText = "医嘱内容";
            dgv_Advice.Columns["Dose"].HeaderText = "剂量";
            dgv_Advice.Columns["Unit"].HeaderText = "单位";
            dgv_Advice.Columns["Way"].HeaderText = "途径";
            dgv_Advice.Columns["Frequency"].HeaderText = "频次";
            dgv_Advice.Columns["Count"].HeaderText = "次数";
            dgv_Advice.Columns["xie"].HeaderText = "/";
            dgv_Advice.Columns["Day"].HeaderText = "日";
            dgv_Advice.Columns["ExecuteTime"].HeaderText = "执行时间";
            dgv_Advice.Columns["LastTime"].HeaderText = "持续时间";
            dgv_Advice.Columns["patientno"].Visible = false;

        }
        /// <summary>
        /// 执行完
        /// </summary>
        private void E()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            DateTime dateTime = DateTime.Now;
            int row = dgv_Advice.Rows.Count;//总行数
            for(int i=0;i<row;i++)
            {            
                if (dgv_Advice.Rows[i].Cells[14].Value.ToString()!="")
                {
                    int lastTime = int.Parse(dgv_Advice.Rows[i].Cells[14].Value.ToString());
                    DateTime giveTime = (DateTime)(dgv_Advice.Rows[i].Cells[2].Value);
                    string GiveTime = giveTime .ToShortDateString();
                    string AdviceContent = dgv_Advice.Rows[i].Cells[5].Value.ToString();
                    string PatientNo = dgv_Advice.Rows[i].Cells[15].Value.ToString();
                    DateTime Time= giveTime.AddDays(lastTime);
                    if(dateTime>Time )
                    {                       
                        sqlCommand.CommandText = $@"update tb_PatientAdvice
                                      set 
                                          isFinish='是'
                                      where PatientNo='{PatientNo }' and AdviceContent='{AdviceContent }' and givetime='{GiveTime }'";
                        sqlConnection.Open();
                        int count =sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
            }
            
        }

        private void rbtn_All_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_All.Checked )
            {
                Search();
            }
        }

        private void rbtn_Stop_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_Stop.Checked )
            {
                Search();
            }
        }

        private void rbtn_Executing_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_Executing.Checked )
            {
                Search();
            }
        }

        private void rbtn_executed_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_executed.Checked )
            {
                Search();
            }
        }

        private void NLookAdvice_FormClosed(object sender, FormClosedEventArgs e)
        {
            NurseHomepage nurseHomepage = new NurseHomepage();
            nurseHomepage.Show();
        }
    }
}
