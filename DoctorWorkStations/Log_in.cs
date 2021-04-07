﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoctorWorkStations
{
    public partial class Log_in : Form
    {
        int num = 0;
        public Log_in()
        {
            InitializeComponent();

        }
        public Log_in(string No):this()
        {
            txt_No.Text  = No;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"SELECT 
	                                        COUNT(1)
	                                        FROM tb_Doctor AS D
	                                        WHERE
		                                    D.No=@No AND D.Password=@Password;";
            sqlCommand.Parameters.AddWithValue("@No", this.txt_No.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Password", this.txt_Password.Text.Trim());
            int count=0;
            sqlConnection.Open();
            count = int.Parse(sqlCommand.ExecuteScalar().ToString());
            sqlConnection.Close();
            if(count==1 )
            {
                Doctor.DoctorNo = txt_No.Text;
                Doctor.Password = txt_Password.Text;
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                num = num + 1;
                if(num<3)
                    MessageBox.Show($"登录失败！你还有{3-num}次登录机会。");
                else
                    MessageBox.Show($"登录失败！你已没有登录机会。");
            }
            if (num == 3)
            {
                btn_Login.Enabled = false;
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}