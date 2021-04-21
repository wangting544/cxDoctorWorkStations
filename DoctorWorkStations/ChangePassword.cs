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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            this.txt_No.Text = Doctor.DoctorNo;

        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if(txt_Old.Text.Trim()=="")
            {
                MessageBox.Show("旧密码不能为空！");
                txt_Old.Focus();
                return;
            }
            if (txt_New .Text.Trim() == "")
            {
                MessageBox.Show("新密码不能为空！");
                this.txt_New.Focus();
                return;
            }
            if (txt_Check .Text.Trim() == "")
            {
                MessageBox.Show("确认密码不能为空！");
                this.txt_Check.Focus();
                return;
            }
            if (txt_Old .Text != Doctor.Password)
            {
                MessageBox.Show("旧密码错误！");
                txt_Old.Text = null;
                txt_New.Text = null;
                txt_Check.Text = null;
                txt_Old.Focus();
                return;
            }
            if(txt_New.Text != txt_Check.Text )
            {
                MessageBox.Show("新密码与确认密码不一致！");
                txt_New.Text = null;
                txt_Check.Text = null;
                txt_New.Focus();
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand1.CommandText = $@"UPDATE tb_Doctor 
	                                        SET Password=@Password
	                                        WHERE No={txt_No.Text }";
            sqlCommand1.Parameters.AddWithValue("@Password", txt_Check.Text.Trim());
            sqlConnection.Open();
            int flag = sqlCommand1.ExecuteNonQuery();
            sqlConnection.Close();
            if(flag==1)
            {
                MessageBox.Show("修改成功！");
                Doctor.Password = txt_Check.Text;
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomePage h = new HomePage();
            h.Show();
        }

    }
}
