using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Environment;

namespace DoctorWorkStations
{
    public partial class DiseaseCourse : Form
    {
        public DiseaseCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhotoDialog = new OpenFileDialog()
            {
                Title = "打开照片文件"
                ,
                Filter = "图像文件|*.docx"
                ,
                InitialDirectory = GetFolderPath(SpecialFolder.MyPictures)
            };
            openPhotoDialog.ShowDialog();
            
        }
    }
}
