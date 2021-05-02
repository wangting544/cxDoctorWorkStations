namespace DoctorWorkStations
{
    partial class NEnterDepartment
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
            this.rbtn_New = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtn_ALL = new System.Windows.Forms.RadioButton();
            this.dgv_Patient = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PatientNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Bed = new System.Windows.Forms.ComboBox();
            this.txt_Adwarddate = new System.Windows.Forms.TextBox();
            this.cb_nurse = new System.Windows.Forms.ComboBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_doctor = new System.Windows.Forms.ComboBox();
            this.l = new System.Windows.Forms.Label();
            this.txt_Prepayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Keep = new System.Windows.Forms.Button();
            this.txt_Dialogue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_InHosptial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_PreviousPage = new System.Windows.Forms.Button();
            this.btn_NextPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn_New
            // 
            this.rbtn_New.AutoSize = true;
            this.rbtn_New.Location = new System.Drawing.Point(114, 11);
            this.rbtn_New.Name = "rbtn_New";
            this.rbtn_New.Size = new System.Drawing.Size(88, 19);
            this.rbtn_New.TabIndex = 0;
            this.rbtn_New.TabStop = true;
            this.rbtn_New.Text = "新入病人";
            this.rbtn_New.UseVisualStyleBackColor = true;
            this.rbtn_New.CheckedChanged += new System.EventHandler(this.rbtn_New_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(226, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "转科病人";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtn_ALL
            // 
            this.rbtn_ALL.AutoSize = true;
            this.rbtn_ALL.Location = new System.Drawing.Point(337, 10);
            this.rbtn_ALL.Name = "rbtn_ALL";
            this.rbtn_ALL.Size = new System.Drawing.Size(88, 19);
            this.rbtn_ALL.TabIndex = 2;
            this.rbtn_ALL.TabStop = true;
            this.rbtn_ALL.Text = "所有病人";
            this.rbtn_ALL.UseVisualStyleBackColor = true;
            this.rbtn_ALL.CheckedChanged += new System.EventHandler(this.rbtn_ALL_CheckedChanged);
            // 
            // dgv_Patient
            // 
            this.dgv_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patient.Location = new System.Drawing.Point(114, 68);
            this.dgv_Patient.Name = "dgv_Patient";
            this.dgv_Patient.RowTemplate.Height = 27;
            this.dgv_Patient.Size = new System.Drawing.Size(565, 205);
            this.dgv_Patient.TabIndex = 3;
            this.dgv_Patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Patient_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Age);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_PatientNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(114, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 47);
            this.panel1.TabIndex = 44;
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(421, 8);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.ReadOnly = true;
            this.txt_Age.Size = new System.Drawing.Size(71, 25);
            this.txt_Age.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "病人标识号：";
            // 
            // txt_PatientNo
            // 
            this.txt_PatientNo.Location = new System.Drawing.Point(118, 7);
            this.txt_PatientNo.Name = "txt_PatientNo";
            this.txt_PatientNo.ReadOnly = true;
            this.txt_PatientNo.Size = new System.Drawing.Size(98, 25);
            this.txt_PatientNo.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "姓名：";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(280, 8);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(64, 25);
            this.txt_Name.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "年龄：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Bed);
            this.groupBox1.Controls.Add(this.txt_Adwarddate);
            this.groupBox1.Controls.Add(this.cb_nurse);
            this.groupBox1.Controls.Add(this.txt_Date);
            this.groupBox1.Controls.Add(this.cb_Department);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cb_doctor);
            this.groupBox1.Controls.Add(this.l);
            this.groupBox1.Controls.Add(this.txt_Prepayment);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_Keep);
            this.groupBox1.Controls.Add(this.txt_Dialogue);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_InHosptial);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(114, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 162);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人在院信息";
            // 
            // cb_Bed
            // 
            this.cb_Bed.FormattingEnabled = true;
            this.cb_Bed.Location = new System.Drawing.Point(244, 90);
            this.cb_Bed.Name = "cb_Bed";
            this.cb_Bed.Size = new System.Drawing.Size(81, 23);
            this.cb_Bed.TabIndex = 77;
            // 
            // txt_Adwarddate
            // 
            this.txt_Adwarddate.Location = new System.Drawing.Point(382, 48);
            this.txt_Adwarddate.Name = "txt_Adwarddate";
            this.txt_Adwarddate.ReadOnly = true;
            this.txt_Adwarddate.Size = new System.Drawing.Size(94, 25);
            this.txt_Adwarddate.TabIndex = 76;
            // 
            // cb_nurse
            // 
            this.cb_nurse.FormattingEnabled = true;
            this.cb_nurse.Location = new System.Drawing.Point(244, 18);
            this.cb_nurse.Name = "cb_nurse";
            this.cb_nurse.Size = new System.Drawing.Size(121, 23);
            this.cb_nurse.TabIndex = 75;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(99, 53);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.Size = new System.Drawing.Size(84, 25);
            this.txt_Date.TabIndex = 73;
            // 
            // cb_Department
            // 
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Location = new System.Drawing.Point(62, 90);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(96, 23);
            this.cb_Department.TabIndex = 72;
            this.cb_Department.SelectedIndexChanged += new System.EventHandler(this.cb_Department_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 70;
            this.label5.Text = "护士：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "入科时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 61;
            this.label11.Text = "科室：";
            // 
            // cb_doctor
            // 
            this.cb_doctor.FormattingEnabled = true;
            this.cb_doctor.Location = new System.Drawing.Point(404, 90);
            this.cb_doctor.Name = "cb_doctor";
            this.cb_doctor.Size = new System.Drawing.Size(88, 23);
            this.cb_doctor.TabIndex = 45;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(346, 94);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(52, 15);
            this.l.TabIndex = 44;
            this.l.Text = "医生：";
            // 
            // txt_Prepayment
            // 
            this.txt_Prepayment.Location = new System.Drawing.Point(482, 17);
            this.txt_Prepayment.Name = "txt_Prepayment";
            this.txt_Prepayment.ReadOnly = true;
            this.txt_Prepayment.Size = new System.Drawing.Size(83, 25);
            this.txt_Prepayment.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 55;
            this.label10.Text = "预交金金额：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "床号：";
            // 
            // btn_Keep
            // 
            this.btn_Keep.Location = new System.Drawing.Point(458, 124);
            this.btn_Keep.Name = "btn_Keep";
            this.btn_Keep.Size = new System.Drawing.Size(75, 30);
            this.btn_Keep.TabIndex = 64;
            this.btn_Keep.Text = "保存";
            this.btn_Keep.UseVisualStyleBackColor = true;
            this.btn_Keep.Click += new System.EventHandler(this.btn_Keep_Click);
            // 
            // txt_Dialogue
            // 
            this.txt_Dialogue.Location = new System.Drawing.Point(99, 131);
            this.txt_Dialogue.Name = "txt_Dialogue";
            this.txt_Dialogue.Size = new System.Drawing.Size(327, 25);
            this.txt_Dialogue.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 54;
            this.label9.Text = "主要诊断：";
            // 
            // txt_InHosptial
            // 
            this.txt_InHosptial.Location = new System.Drawing.Point(72, 22);
            this.txt_InHosptial.Name = "txt_InHosptial";
            this.txt_InHosptial.ReadOnly = true;
            this.txt_InHosptial.Size = new System.Drawing.Size(99, 25);
            this.txt_InHosptial.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "入院日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "住院号：";
            // 
            // btn_PreviousPage
            // 
            this.btn_PreviousPage.Location = new System.Drawing.Point(403, 33);
            this.btn_PreviousPage.Name = "btn_PreviousPage";
            this.btn_PreviousPage.Size = new System.Drawing.Size(75, 23);
            this.btn_PreviousPage.TabIndex = 46;
            this.btn_PreviousPage.Text = "上一页";
            this.btn_PreviousPage.UseVisualStyleBackColor = true;
            this.btn_PreviousPage.Click += new System.EventHandler(this.btn_PreviousPage_Click);
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Location = new System.Drawing.Point(560, 32);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(75, 23);
            this.btn_NextPage.TabIndex = 47;
            this.btn_NextPage.Text = "下一页";
            this.btn_NextPage.UseVisualStyleBackColor = true;
            this.btn_NextPage.Click += new System.EventHandler(this.btn_NextPage_Click);
            // 
            // NEnterDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.btn_NextPage);
            this.Controls.Add(this.btn_PreviousPage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Patient);
            this.Controls.Add(this.rbtn_ALL);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbtn_New);
            this.Name = "NEnterDepartment";
            this.Text = "入科";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NEnterDepartment_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_New;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtn_ALL;
        private System.Windows.Forms.DataGridView dgv_Patient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PatientNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_doctor;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txt_Prepayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Keep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Dialogue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_InHosptial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.ComboBox cb_nurse;
        private System.Windows.Forms.TextBox txt_Adwarddate;
        private System.Windows.Forms.ComboBox cb_Bed;
        private System.Windows.Forms.Button btn_PreviousPage;
        private System.Windows.Forms.Button btn_NextPage;
    }
}