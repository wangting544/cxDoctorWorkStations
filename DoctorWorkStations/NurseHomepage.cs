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
    public partial class NurseHomepage : Form
    {
        public NurseHomepage()
        {
            InitializeComponent();
            label1.Text = $"{Doctor.name}护士，你好!";
            Tree();
        }

        private void RegisterInformation_Click(object sender, EventArgs e)
        {
            NRegisterInformation nRegisterInformation = new NRegisterInformation();
            nRegisterInformation.Show();
            this.Close();
        }

        private void EnterDepartment_Click(object sender, EventArgs e)
        {
            NEnterDepartment nEnterDepartment = new NEnterDepartment();
            nEnterDepartment.Show();
            this.Close();
        }

        private void 转科ChangeDepartment_Click(object sender, EventArgs e)
        {
            NChangeDepartment nChangeDepartment = new NChangeDepartment();
            nChangeDepartment.Show();
            this.Close();
        }

        private void 退出Out_Click(object sender, EventArgs e)
        {
            Log_in log_In = new Log_in();
            log_In.Show();
            this.Close();
        }

        private void 出院Out_Click(object sender, EventArgs e)
        {
            NLeaveHospital nLeaveHospital = new NLeaveHospital();
            nLeaveHospital.Show();
            this.Close();
        }

        private void 校对医嘱Check_Click(object sender, EventArgs e)
        {
            NCheckAdvice nCheckAdvice = new NCheckAdvice();
            nCheckAdvice.Show();
            this.Close();
        }

        private void 停止医嘱Stop_Click(object sender, EventArgs e)
        {
            NStopAdvice nStopAdvice = new NStopAdvice();
            nStopAdvice.Show();
            this.Close();
        }

        private void 查看医嘱LookAdvice_Click(object sender, EventArgs e)
        {
            NLookAdvice nLookAdvice = new NLookAdvice();
            nLookAdvice.Show();
            this.Close();
        }
        /// <summary>
        /// 填充treeview
        /// </summary>
        private void Tree()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from tb_Department;"
                                  + "select * from tb_Doctor;"
                                  + @" select P.No as PatientNo
		                                ,P.Name as PatientName
		                                ,PI.No as HosptialNo
                                        ,pi.DoctorNo 
                                        from tb_Patient as P join tb_PatientInHosptial as PI on PI.PatientNo =P.No 
                                        where
	                                    (PI.flag is null or PI.Flag=0) and isinhospital =1 ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();
            DataTable departmentTable = dataSet.Tables[0];
            DataTable DoctorTable = dataSet.Tables[1];
            DataTable PatientTable = dataSet.Tables[2];
            DataRelation[] dataRelations =
            {
                new DataRelation
                ("Department_Doctor"
                ,departmentTable.Columns["No"]
                ,DoctorTable.Columns["DepartmentNo"]
                ,false
                )
                ,new DataRelation
                ("Doctor_Patient"
                ,DoctorTable.Columns["No"]
                ,PatientTable.Columns["DoctorNo"]
                ,false
                )
            };
            dataSet.Relations.AddRange(dataRelations);
            this.trv_Patient.Nodes.Clear();
            foreach (DataRow  departmentRow in departmentTable.Rows )
            {
                TreeNode departmentNode = new TreeNode();
                departmentNode.Text = departmentRow["Name"].ToString();
                this.trv_Patient.Nodes.Add(departmentNode);
                foreach (DataRow  DoctorRow in departmentRow.GetChildRows("Department_Doctor"))
                {
                    TreeNode doctorNode = new TreeNode();
                    doctorNode .Text = DoctorRow["Name"].ToString();
                    departmentNode .Nodes.Add(doctorNode );
                    foreach (DataRow PatientRow in DoctorRow .GetChildRows("Doctor_Patient"))
                    {
                        TreeNode patientNode = new TreeNode();
                        patientNode .Text = PatientRow ["PatientName"].ToString();
                        patientNode.Tag = PatientRow["HosptialNo"];
                        doctorNode .Nodes.Add(patientNode );
                    }
                }
            }
        }
        /// <summary>
        /// 选择教学单位树形视图；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trv_Patient_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void lbox_Advice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.trv_Patient .SelectedNode.Level != 2)                                         //若树形视图的选中节点的级别不为3，即未选中班级节点；
                return;																					//则返回；
            string  inHosptialNo = this.trv_Patient.SelectedNode.Tag.ToString();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select PatientNo  from tb_PatientInHosptial where No='{inHosptialNo  }'";
            sqlConnection.Open();
            string PatientNo = sqlCommand.ExecuteScalar().ToString();
            sqlConnection.Close();

            //医嘱
            if(lbox_Advice.SelectedIndex==0)
            {
                SearchAdvice searchAdvice = new SearchAdvice(inHosptialNo);
                searchAdvice.Show();
            }
            //体温
            if (lbox_Advice.SelectedIndex ==1 )
            {
                Temperature temperature = new Temperature(PatientNo);
                temperature.Show();
            }
            //属性
            if (lbox_Advice.SelectedIndex == 2)
            {
                Property property = new Property(inHosptialNo);
                property.Show();
            }
            //手术
            if(lbox_Advice.SelectedIndex==3)
            {
                NSearchOperation nSearchOperation = new NSearchOperation(PatientNo );
                nSearchOperation.Show();
            }
        }
    }
}
