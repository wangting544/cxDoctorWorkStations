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
using System.IO;
using static System.Environment;
using System.Drawing.Imaging;


namespace DoctorWorkStations
{
    public partial class Property : Form
    {
        string PatientInHospitalNo;
        public Property()
        {
            InitializeComponent();
        }
        public Property(string PatientInHospitalNo):this()
        {
            this.PatientInHospitalNo = PatientInHospitalNo;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"SELECT
	                                        PA.No as PatientNo
	                                        ,PA.Name 
	                                        ,PA.Sex
	                                        ,PA.Birthday
	                                        ,PA.Work 
	                                        ,P.No
	                                        ,P.AdmWardDate
	                                        ,P.BedNo
	                                        ,P.PrincipalDiagnosis
	                                        ,P.Prepayment
	                                        ,P.TotalCost
                                            ,PA.Photo
                                        FROM tb_PatientInHosptial AS P
                                            JOIN tb_Patient AS PA ON PA.No=P.PatientNo 
                                        WHERE P.No='{PatientInHospitalNo }' and p.flag is null";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            byte[] photoType = null;
            if(sqlDataReader.Read())
            {
                txt_PatientNo.Text = sqlDataReader["PatientNo"].ToString();
                txt_Name.Text= sqlDataReader["Name"].ToString();
                string sex= sqlDataReader["Sex"].ToString();
                if(sex=="男")
                {
                    rbtn_Male.Checked = true;
                }
                if (sex == "女")
                {
                    rbtn_Female.Checked = true;
                }
                dtp_Birthday.Value = (DateTime)sqlDataReader["Birthday"];
                txt_Work.Text = sqlDataReader["Work"].ToString();
                txt_InHosptial.Text = sqlDataReader["No"].ToString();
                dtp_AdmWard.Value = (DateTime)sqlDataReader["AdmWardDate"];
                txt_bedNo.Text = sqlDataReader["BedNo"].ToString();
                txt_Dialogue.Text  = sqlDataReader["PrincipalDiagnosis"].ToString();
                txt_Prepayment .Text = sqlDataReader["Prepayment"].ToString();
                txt_TotalCost.Text = sqlDataReader["TotalCost"].ToString();
                photoType =
                    (sqlDataReader["Photo"] == DBNull.Value ? null : (byte[])sqlDataReader["Photo"]);

            }
            sqlDataReader.Close();
            if (photoType != null)
            {
                MemoryStream memoryStream = new MemoryStream(photoType);
                this.pb_Photo.Image = Image.FromStream(memoryStream);
            }

        }

        private void Property_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhotoDialog = new OpenFileDialog()
            {
                Title = "打开照片文件"
                ,
                Filter = "图像文件|*.bmp;*.jpg"
                ,
                InitialDirectory = GetFolderPath(SpecialFolder.MyPictures)
            };
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openPhotoDialog.FileName;
                this.pb_Photo .Image = Image.FromFile(fileName);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            this.pb_Photo.Image.Save(memoryStream, ImageFormat.Gif);
            byte[] photoBytes = new byte[memoryStream.Length];
            memoryStream.Seek(0, SeekOrigin.Begin);
            memoryStream.Read(photoBytes, 0, photoBytes.Length);
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"UPDATE tb_Patient 
                                        SET No = @No, Name=@Name,Sex=@Sex,Birthday=@Birthday, Work=@Work, Photo=@Photo
                                        where No = '{txt_PatientNo.Text.Trim()}'";
            sqlCommand.Parameters.AddWithValue("@No", this.txt_PatientNo.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Name", this.txt_Name.Text.Trim());
            if (this.rbtn_Male.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@Sex", "男");
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Sex", "女");
            }
            sqlCommand.Parameters.AddWithValue("@Birthday", this.dtp_Birthday.Value);
            sqlCommand.Parameters.AddWithValue("@Work", this.txt_Work.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Photo", photoBytes);

            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
            sqlCommand1.CommandText = $@"UPDATE tb_PatientInHosptial 
		                            SET AdmWardDate=@AdmWardDate,BedNo=@BedNo,PrincipalDiagnosis=@PrincipalDiagnosis,Prepayment=@Prepayment ,TotalCost=@TotalCost
		                            where No='{PatientInHospitalNo }'";
            sqlCommand1.Parameters.AddWithValue("@BedNo", this.txt_bedNo .Text.Trim());
            sqlCommand1.Parameters.AddWithValue("@AdmWardDate", this.dtp_AdmWard .Value);
            sqlCommand1.Parameters.AddWithValue("@PrincipalDiagnosis", this.txt_Dialogue.Text.Trim());
            sqlCommand1.Parameters.AddWithValue("@Prepayment", this.txt_Prepayment .Text.Trim());
            sqlCommand1.Parameters.AddWithValue("@TotalCost", this.txt_TotalCost .Text.Trim());

            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            rowAffected += sqlCommand1.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }
    }
}
