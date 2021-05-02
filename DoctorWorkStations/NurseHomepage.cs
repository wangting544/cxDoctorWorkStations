using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorWorkStations
{
    public partial class NurseHomepage : Form
    {
        public NurseHomepage()
        {
            InitializeComponent();
            label1.Text = $"{Doctor.name}护士，你好!";
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
    }
}
