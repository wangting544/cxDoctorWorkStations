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
    public partial class AdvicePackage : Form
    {
        public AdvicePackage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgv_DoctorAdvice .RowHeadersVisible = false;
            this.dgv_DoctorAdvice .BackgroundColor = Color.White;
            this.dgv_DoctorAdvice.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
