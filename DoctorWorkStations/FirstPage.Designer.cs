namespace DoctorWorkStations
{
    partial class FirstPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PatientNo = new System.Windows.Forms.TextBox();
            this.txt_inHosptial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Department = new System.Windows.Forms.TextBox();
            this.txt_Sex = new System.Windows.Forms.TextBox();
            this.txt_work = new System.Windows.Forms.TextBox();
            this.txt_OutDate = new System.Windows.Forms.TextBox();
            this.txt_AdmWardDate = new System.Windows.Forms.TextBox();
            this.txt_Birthday = new System.Windows.Forms.TextBox();
            this.dgv_Diagnosis = new System.Windows.Forms.DataGridView();
            this.btn_Keep1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "病人ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "住院号：";
            // 
            // txt_PatientNo
            // 
            this.txt_PatientNo.Location = new System.Drawing.Point(66, 6);
            this.txt_PatientNo.Name = "txt_PatientNo";
            this.txt_PatientNo.ReadOnly = true;
            this.txt_PatientNo.Size = new System.Drawing.Size(100, 25);
            this.txt_PatientNo.TabIndex = 2;
            // 
            // txt_inHosptial
            // 
            this.txt_inHosptial.Location = new System.Drawing.Point(66, 37);
            this.txt_inHosptial.Name = "txt_inHosptial";
            this.txt_inHosptial.ReadOnly = true;
            this.txt_inHosptial.Size = new System.Drawing.Size(100, 25);
            this.txt_inHosptial.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "入院科室：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "身份：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "性别：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "出院日期：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "入院日期：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "出生日期：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 323);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Keep1);
            this.tabPage1.Controls.Add(this.dgv_Diagnosis);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "      诊断信息      ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "      中医诊断信息      ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "        手术信息        ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 252);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "       其他信息       ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(260, 6);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(100, 25);
            this.txt_Name.TabIndex = 13;
            // 
            // txt_Department
            // 
            this.txt_Department.Location = new System.Drawing.Point(260, 37);
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.ReadOnly = true;
            this.txt_Department.Size = new System.Drawing.Size(100, 25);
            this.txt_Department.TabIndex = 14;
            // 
            // txt_Sex
            // 
            this.txt_Sex.Location = new System.Drawing.Point(461, 6);
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.ReadOnly = true;
            this.txt_Sex.Size = new System.Drawing.Size(100, 25);
            this.txt_Sex.TabIndex = 15;
            // 
            // txt_work
            // 
            this.txt_work.Location = new System.Drawing.Point(461, 37);
            this.txt_work.Name = "txt_work";
            this.txt_work.ReadOnly = true;
            this.txt_work.Size = new System.Drawing.Size(100, 25);
            this.txt_work.TabIndex = 16;
            // 
            // txt_OutDate
            // 
            this.txt_OutDate.Location = new System.Drawing.Point(677, 68);
            this.txt_OutDate.Name = "txt_OutDate";
            this.txt_OutDate.ReadOnly = true;
            this.txt_OutDate.Size = new System.Drawing.Size(177, 25);
            this.txt_OutDate.TabIndex = 17;
            // 
            // txt_AdmWardDate
            // 
            this.txt_AdmWardDate.Location = new System.Drawing.Point(677, 37);
            this.txt_AdmWardDate.Name = "txt_AdmWardDate";
            this.txt_AdmWardDate.ReadOnly = true;
            this.txt_AdmWardDate.Size = new System.Drawing.Size(177, 25);
            this.txt_AdmWardDate.TabIndex = 18;
            // 
            // txt_Birthday
            // 
            this.txt_Birthday.Location = new System.Drawing.Point(677, 6);
            this.txt_Birthday.Name = "txt_Birthday";
            this.txt_Birthday.ReadOnly = true;
            this.txt_Birthday.Size = new System.Drawing.Size(177, 25);
            this.txt_Birthday.TabIndex = 19;
            // 
            // dgv_Diagnosis
            // 
            this.dgv_Diagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Diagnosis.Location = new System.Drawing.Point(0, 0);
            this.dgv_Diagnosis.Name = "dgv_Diagnosis";
            this.dgv_Diagnosis.RowTemplate.Height = 27;
            this.dgv_Diagnosis.Size = new System.Drawing.Size(791, 239);
            this.dgv_Diagnosis.TabIndex = 0;
            // 
            // btn_Keep1
            // 
            this.btn_Keep1.Location = new System.Drawing.Point(640, 258);
            this.btn_Keep1.Name = "btn_Keep1";
            this.btn_Keep1.Size = new System.Drawing.Size(83, 30);
            this.btn_Keep1.TabIndex = 1;
            this.btn_Keep1.Text = "保存（&S）";
            this.btn_Keep1.UseVisualStyleBackColor = true;
            this.btn_Keep1.Click += new System.EventHandler(this.btn_Keep1_Click);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.txt_Birthday);
            this.Controls.Add(this.txt_AdmWardDate);
            this.Controls.Add(this.txt_OutDate);
            this.Controls.Add(this.txt_work);
            this.Controls.Add(this.txt_Sex);
            this.Controls.Add(this.txt_Department);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_inHosptial);
            this.Controls.Add(this.txt_PatientNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "首页信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FirstPage_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diagnosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PatientNo;
        private System.Windows.Forms.TextBox txt_inHosptial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Department;
        private System.Windows.Forms.TextBox txt_Sex;
        private System.Windows.Forms.TextBox txt_work;
        private System.Windows.Forms.TextBox txt_OutDate;
        private System.Windows.Forms.TextBox txt_AdmWardDate;
        private System.Windows.Forms.TextBox txt_Birthday;
        private System.Windows.Forms.DataGridView dgv_Diagnosis;
        private System.Windows.Forms.Button btn_Keep1;
    }
}