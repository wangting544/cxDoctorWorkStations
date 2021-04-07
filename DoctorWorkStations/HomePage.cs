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
                                        WHERE D.No = '{Doctor.DoctorNo }' and P.IsInHospital=1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable ListTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(ListTable);
            this.lb_Patient.DataSource = ListTable;
            this.lb_Patient.DisplayMember = "PatientName";
            this.lb_Patient.ValueMember = "PatientNo";
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

        }

    }
}
