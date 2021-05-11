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
    public partial class NStopAdvice : Form
    {
        public NStopAdvice()
        {
            InitializeComponent();
            this.dgv_Advice.AllowUserToAddRows = false;
            this.dgv_Advice.RowHeadersVisible = false;
            this.dgv_Advice.BackgroundColor = Color.White;
            dgv_Advice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            PatientNo();
            SearchAll();
        }
        /// <summary>
        /// 查询单个人正在执行的医嘱
        /// </summary>
        private void Search()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select 
		                                    t.Name  as 长期
		                                    ,s.Name as 类别
		                                    ,pa.StartTime as 开始时间
		                                    ,pa.AdviceContent as 医嘱内容
		                                    ,pa.Dose as 剂量
		                                    ,pa.Unit as 单位
		                                    ,pa.Way as 途径
		                                    ,pa.Frequency as 频次
		                                    ,pa.ExecuteTime as 执行时间
		                                    ,pa.LastTime as 持续时间
		                                    ,pa.IsFinish as 是否执行完
                                            ,pa.isexecute as 是否发放医嘱
	                                   from tb_PatientAdvice as pa
	                                        join tb_Patient as p on p.No=pa.PatientNo 
	                                        join tb_Type as t on t.No=pa.AdviceTypeNo 
	                                        join tb_Sort as s on s.No=pa.SortNo 
                                            where PatientNo='{cb_PatientNo .SelectedValue}' and pa.isexecute=1 and pa.isFinish='否'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Advice.DataSource = dataTable;
        }
        /// <summary>
        /// 查询所有正在执行的医嘱;
        /// </summary>
        private void SearchAll()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select 
                                            p.no as 病人号
                                            ,P.NAME AS 病人名
		                                    ,t.Name  as 长期
		                                    ,s.Name as 类别
		                                    ,pa.giveTime as 开始时间
		                                    ,pa.AdviceContent as 医嘱内容
		                                    ,pa.Dose as 剂量
		                                    ,pa.Unit as 单位
		                                    ,pa.Way as 途径
		                                    ,pa.Frequency as 频次
		                                    ,pa.ExecuteTime as 执行时间
		                                    ,pa.LastTime as 持续时间
		                                    ,d.name as 医生
                                            ,pa.startTime as 开医嘱时间
                                            ,pa.isexecute as 是否发放医嘱
	                                   from tb_PatientAdvice as pa
	                                        join tb_Patient as p on p.No=pa.PatientNo 
	                                        join tb_Type as t on t.No=pa.AdviceTypeNo 
	                                        join tb_Sort as s on s.No=pa.SortNo 
                                            join tb_doctor as d on d.no=pa.doctorno
                                            where pa.isexecute=1 and pa.isFinish='否'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Advice.DataSource = dataTable;
            //this.dgv_Advice .Columns["持续时间"].HeaderText = "持续时间（天）";
        }
        /// <summary>
        /// 填充cb_PatientNo;
        /// </summary>
        private void PatientNo()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"select P.No,P.Name  
                                        from tb_PatientInHosptial as PIH
                                        join tb_Patient as P on P.No=PIH.PatientNo   where flag=0 or flag is null";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            cb_PatientNo .DataSource = dataTable;
            cb_PatientNo .DisplayMember = "Name";
            cb_PatientNo .ValueMember = "No";
        }
        /// <summary>
        /// 单个病人医嘱按钮;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_SearchAll_Click(object sender, EventArgs e)
        {
            SearchAll();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (this.dgv_Advice.CurrentCell == null)
            {
                MessageBox.Show("你未选中医嘱！");
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"update tb_PatientAdvice
                                      set isexecute=@isexecute
                                          ,isFinish='是'
                                      where PatientNo=@PatientNo and AdviceContent=@AdviceContent and IsFinish='否' and givetime=@giveTime";
            DialogResult dr = MessageBox.Show("现在就提交现在的医嘱吗？", "提示", MessageBoxButtons.OKCancel);
            sqlCommand.Parameters.Add("@isexecute", SqlDbType.Bit, 0, "是否发放医嘱");
            sqlCommand.Parameters.Add("@PatientNo", SqlDbType.VarChar, 0, "病人号");
            sqlCommand.Parameters.Add("@AdviceContent", SqlDbType.VarChar, 0, "医嘱内容");
            sqlCommand.Parameters.Add("@giveTime", SqlDbType.Date, 0, "开始时间");
            if (dr == DialogResult.OK)
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.UpdateCommand = sqlCommand;
                DataTable adviceTable = (DataTable)this.dgv_Advice.DataSource;
                sqlConnection.Open();
                int rowaffected = sqlDataAdapter.Update(adviceTable);
                sqlConnection.Close();
                if (rowaffected != 0)
                {
                    MessageBox.Show($"{rowaffected }提交成功！");
                }
                else
                {
                    MessageBox.Show($"{rowaffected }提交失败！");
                }
            }
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("取消成功！");
            }

        }

        private void NStopAdvice_FormClosed(object sender, FormClosedEventArgs e)
        {
            NurseHomepage nurseHomepage = new NurseHomepage();
            nurseHomepage.Show();
        }
    }
}
