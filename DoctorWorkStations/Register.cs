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
    public partial class Register : Form
    {
        SqlConnection sql = new SqlConnection();
        public Register()
        {
            InitializeComponent();
            sql.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sql.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM tb_Department ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable departmentTable = new DataTable();
            sql.Open();
            sqlDataAdapter.Fill(departmentTable);
            this.cbox_Department.DataSource = departmentTable;
            this.cbox_Department.DisplayMember = "Name";
            this.cbox_Department.ValueMember = "No";
            cb_Status.SelectedIndex = 0;
        }
        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (this.txt_No .Text.Trim() == "")                                                      //若用户号文本框为空；
            {
                MessageBox.Show("用户号不能为空！");														//给出错误提示；
                this.txt_No.Focus();                                                                //用户号文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (this.txt_Password.Text.Trim() == "")                                                    //若密码文本框为空；
            {
                MessageBox.Show("密码不能为空！");															//给出错误提示；
                this.txt_Password.Focus();                                                              //密码文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (this.txt_Name.Text.Trim() == "")                                                      //若用户号文本框为空；
            {
                MessageBox.Show("用户号不能为空！");														//给出错误提示；
                this.txt_Name.Focus();                                                                //用户号文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (this.txt_Tel .Text.Trim() == "")                                                    //若密码文本框为空；
            {
                MessageBox.Show("密码不能为空！");															//给出错误提示；
                this.txt_Tel.Focus();                                                              //密码文本框获得焦点；
                return;                                                                                 //返回；
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText=
                @"INSERT tb_Doctor 
                        (No, Name, Password, Tel,DepartmentNo,status)
                         VALUES
                        (@No,@Name,@Password,@Tel,@DepartmentNo,@Status);";
            sqlCommand.Parameters.AddWithValue("@No", this.txt_No.Text.Trim ());
            sqlCommand.Parameters.AddWithValue("@Name", this.txt_Name.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Password", this.txt_Password.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Tel", this.txt_Tel.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@DepartmentNo", this.cbox_Department.SelectedValue.ToString());
            sqlCommand.Parameters.AddWithValue("@Status", this.cb_Status.SelectedItem.ToString());
            int rowAffect=0;
            int flag = 0;
            try
            {
                sqlConnection.Open();
                rowAffect = sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
            {
                if(sqlEx.Number==2627)
                {
                    MessageBox.Show("您注册的用户已存在，请重新输入！\n");
                    txt_Name.Text  = null;
                    txt_No.Text  = null;
                    txt_Password.Text  = null;
                    txt_Tel.Text  = null;
                    this.txt_No.Focus();
                    flag = 1;
                }
            }
            finally
            {
                sqlConnection.Close();
            }
            if(flag==0)
            {
                if (rowAffect == 1)                                                                       //若成功写入1行记录；
                {
                    MessageBox.Show("注册成功。");                                                           //显示正确提示；
                }
                else                                                                                        //否则；
                {
                    MessageBox.Show($"注册失败！");                                                           //显示错误提示；
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Log_in log_In = new Log_in(txt_No.Text.Trim());
            log_In.Show();
            this.Close();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log_in l = new Log_in();
            l.Show();
        }

        private void txt_No_Validated(object sender, EventArgs e)
        {
            label6.Text = "*";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select count(1) from tb_Doctor where No=@No";
            sqlCommand.Parameters.AddWithValue("@No", this.txt_No.Text.Trim());
            sqlConnection.Open();
            int flag = int.Parse(sqlCommand.ExecuteScalar().ToString());
            sqlConnection.Close();
            if(flag==1)
            {
                label6.Text = "您注册的用户已存在，请重新输入！";
                this.txt_No.Focus();
            }
        }

        private void txt_Tel_Validated(object sender, EventArgs e)
        {
            if(txt_Tel.Text.Trim().Length !=11)
            {
                label7.Text = "电话号码只能为十一位数！";

            }
        }
    }
}
