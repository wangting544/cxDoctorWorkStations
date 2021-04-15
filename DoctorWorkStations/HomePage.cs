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
using System.Configuration;

namespace DoctorWorkStations
{
    public partial class HomePage : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        public HomePage()
        {
            InitializeComponent();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
                                        P.No as PatientNo
	                                    ,pa.Name as PatientName
                                        FROM tb_PatientInHosptial AS P
                                        JOIN tb_Patient AS PA ON PA.No = P.PatientNo
                                        JOIN tb_Doctor AS D ON D.No = P.DoctorNo
                                        WHERE D.No = '{Doctor.DoctorNo }' and P.IsInHospital=1 and flag is null";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable ListTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(ListTable);
            this.lb_Patient.DataSource = ListTable;
            this.lb_Patient.DisplayMember = "PatientName";
            this.lb_Patient.ValueMember = "PatientNo";
            lbl_Doctor.Text = $"{Doctor.Department }的{Doctor.name}医生，你好！";
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
            Log_in log_In = new Log_in();
            log_In.Show();
            this.Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            MCreate mCreate = new MCreate();
            mCreate.Show();
            this.Close();
        }

        private void Shift_out_Click(object sender, EventArgs e)
        {
            if(lb_Patient.SelectedIndex==-1)
            {
                MessageBox.Show("无病人移出！");
                return;
            }
            Sign sign = new Sign(lb_Patient.SelectedValue.ToString());
            sign.Show();
            this.Close();
        }

        private void Shift_in_Click(object sender, EventArgs e)
        {
            Shiftin shiftin = new Shiftin();
            shiftin.Show();
            this.Close();
        }

        private void Property_Click(object sender, EventArgs e)
        {
            string No = lb_Patient.SelectedValue.ToString();
            Property p = new Property(No);
            p.Show();
            this.Close();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
            this.Close();
        }

        private void AdvicePackage_Click(object sender, EventArgs e)
        {
            AdvicePackage a = new AdvicePackage();
            a.Show();
            this.Close();
        }

        private void StudyCase_Click(object sender, EventArgs e)
        {
            StudyCase s = new StudyCase();
            s.Show();
        }

        private void bsm_WaitBedPatient_Click(object sender, EventArgs e)
        {
            WaitBedPatient waitBedPatient = new WaitBedPatient();
            waitBedPatient.Show();
            this.Close();
        }

        private void lbox_ParientOperate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lb_Patient.SelectedIndex==-1)
            {
                MessageBox.Show("无病人！");
                return;
            }
            if(lbox_ParientOperate.SelectedIndex==0)
            {
                MessageBox.Show("111");
            }
            if (lbox_ParientOperate.SelectedIndex == 1)
            {
                DiseaseCourse diseaseCourse = new DiseaseCourse();
                diseaseCourse.Show();
            }
            if (lbox_ParientOperate.SelectedIndex == 2)
            {

            }
            if (lbox_ParientOperate.SelectedIndex == 3)
            {

            }
            if (lbox_ParientOperate.SelectedIndex == 4)
            {

            }
            if (lbox_ParientOperate.SelectedIndex==5)
            {
                string No = lb_Patient.SelectedValue.ToString();
                Advice advice = new Advice(No);
                advice.Show();
                this.Close();
            }
        }

        private void tsm_Drug_Click(object sender, EventArgs e)
        {
            DrugSearch drugSearch = new DrugSearch();
            drugSearch.Show();
            this.Close();
        }

        private void LeaveHosptial_Click(object sender, EventArgs e)
        {
            leaveHosptial leaveHosptial = new leaveHosptial();
            leaveHosptial.Show();
            this.Close();
        }
    }
}
