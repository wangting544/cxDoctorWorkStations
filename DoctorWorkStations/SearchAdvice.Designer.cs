namespace DoctorWorkStations
{
    partial class SearchAdvice
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_Execute = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_Stop = new System.Windows.Forms.RadioButton();
            this.rbtn_Executing = new System.Windows.Forms.RadioButton();
            this.rbtn_execute = new System.Windows.Forms.RadioButton();
            this.rbtn_Allexecute = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_temporary = new System.Windows.Forms.RadioButton();
            this.rbtn_Long = new System.Windows.Forms.RadioButton();
            this.rbtn_AllType = new System.Windows.Forms.RadioButton();
            this.lbl_InHosptial = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_BedNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Execute)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(639, 63);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 30);
            this.btn_Search.TabIndex = 31;
            this.btn_Search.Text = "查找";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_Execute
            // 
            this.dgv_Execute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Execute.Location = new System.Drawing.Point(12, 130);
            this.dgv_Execute.Name = "dgv_Execute";
            this.dgv_Execute.RowTemplate.Height = 27;
            this.dgv_Execute.Size = new System.Drawing.Size(958, 239);
            this.dgv_Execute.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_Stop);
            this.groupBox2.Controls.Add(this.rbtn_Executing);
            this.groupBox2.Controls.Add(this.rbtn_execute);
            this.groupBox2.Controls.Add(this.rbtn_Allexecute);
            this.groupBox2.Location = new System.Drawing.Point(269, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 63);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示范围";
            // 
            // rbtn_Stop
            // 
            this.rbtn_Stop.AutoSize = true;
            this.rbtn_Stop.Location = new System.Drawing.Point(241, 22);
            this.rbtn_Stop.Name = "rbtn_Stop";
            this.rbtn_Stop.Size = new System.Drawing.Size(58, 19);
            this.rbtn_Stop.TabIndex = 3;
            this.rbtn_Stop.TabStop = true;
            this.rbtn_Stop.Text = "停用";
            this.rbtn_Stop.UseVisualStyleBackColor = true;
            this.rbtn_Stop.CheckedChanged += new System.EventHandler(this.rbtn_Stop_CheckedChanged);
            // 
            // rbtn_Executing
            // 
            this.rbtn_Executing.AutoSize = true;
            this.rbtn_Executing.Location = new System.Drawing.Point(161, 22);
            this.rbtn_Executing.Name = "rbtn_Executing";
            this.rbtn_Executing.Size = new System.Drawing.Size(73, 19);
            this.rbtn_Executing.TabIndex = 2;
            this.rbtn_Executing.TabStop = true;
            this.rbtn_Executing.Text = "执行中";
            this.rbtn_Executing.UseVisualStyleBackColor = true;
            this.rbtn_Executing.CheckedChanged += new System.EventHandler(this.rbtn_Executing_CheckedChanged);
            // 
            // rbtn_execute
            // 
            this.rbtn_execute.AutoSize = true;
            this.rbtn_execute.Location = new System.Drawing.Point(87, 23);
            this.rbtn_execute.Name = "rbtn_execute";
            this.rbtn_execute.Size = new System.Drawing.Size(73, 19);
            this.rbtn_execute.TabIndex = 1;
            this.rbtn_execute.TabStop = true;
            this.rbtn_execute.Text = "己执行";
            this.rbtn_execute.UseVisualStyleBackColor = true;
            this.rbtn_execute.CheckedChanged += new System.EventHandler(this.rbtn_execute_CheckedChanged);
            // 
            // rbtn_Allexecute
            // 
            this.rbtn_Allexecute.AutoSize = true;
            this.rbtn_Allexecute.Location = new System.Drawing.Point(7, 25);
            this.rbtn_Allexecute.Name = "rbtn_Allexecute";
            this.rbtn_Allexecute.Size = new System.Drawing.Size(73, 19);
            this.rbtn_Allexecute.TabIndex = 0;
            this.rbtn_Allexecute.TabStop = true;
            this.rbtn_Allexecute.Text = "都显示";
            this.rbtn_Allexecute.UseVisualStyleBackColor = true;
            this.rbtn_Allexecute.CheckedChanged += new System.EventHandler(this.rbtn_Allexecute_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_temporary);
            this.groupBox1.Controls.Add(this.rbtn_Long);
            this.groupBox1.Controls.Add(this.rbtn_AllType);
            this.groupBox1.Location = new System.Drawing.Point(21, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 63);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "长期 / 临时";
            // 
            // rbtn_temporary
            // 
            this.rbtn_temporary.AutoSize = true;
            this.rbtn_temporary.Location = new System.Drawing.Point(136, 24);
            this.rbtn_temporary.Name = "rbtn_temporary";
            this.rbtn_temporary.Size = new System.Drawing.Size(58, 19);
            this.rbtn_temporary.TabIndex = 2;
            this.rbtn_temporary.TabStop = true;
            this.rbtn_temporary.Text = "临时";
            this.rbtn_temporary.UseVisualStyleBackColor = true;
            this.rbtn_temporary.CheckedChanged += new System.EventHandler(this.rbtn_temporary_CheckedChanged);
            // 
            // rbtn_Long
            // 
            this.rbtn_Long.AutoSize = true;
            this.rbtn_Long.Location = new System.Drawing.Point(72, 24);
            this.rbtn_Long.Name = "rbtn_Long";
            this.rbtn_Long.Size = new System.Drawing.Size(58, 19);
            this.rbtn_Long.TabIndex = 1;
            this.rbtn_Long.TabStop = true;
            this.rbtn_Long.Text = "长期";
            this.rbtn_Long.UseVisualStyleBackColor = true;
            this.rbtn_Long.CheckedChanged += new System.EventHandler(this.rbtn_Long_CheckedChanged);
            // 
            // rbtn_AllType
            // 
            this.rbtn_AllType.AutoSize = true;
            this.rbtn_AllType.Location = new System.Drawing.Point(7, 25);
            this.rbtn_AllType.Name = "rbtn_AllType";
            this.rbtn_AllType.Size = new System.Drawing.Size(58, 19);
            this.rbtn_AllType.TabIndex = 0;
            this.rbtn_AllType.TabStop = true;
            this.rbtn_AllType.Text = "全部";
            this.rbtn_AllType.UseVisualStyleBackColor = true;
            this.rbtn_AllType.CheckedChanged += new System.EventHandler(this.rbtn_AllType_CheckedChanged);
            // 
            // lbl_InHosptial
            // 
            this.lbl_InHosptial.AutoSize = true;
            this.lbl_InHosptial.Location = new System.Drawing.Point(572, 9);
            this.lbl_InHosptial.Name = "lbl_InHosptial";
            this.lbl_InHosptial.Size = new System.Drawing.Size(63, 15);
            this.lbl_InHosptial.TabIndex = 27;
            this.lbl_InHosptial.Text = "label10";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(429, 9);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(55, 15);
            this.lbl_Age.TabIndex = 26;
            this.lbl_Age.Text = "label9";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Location = new System.Drawing.Point(309, 9);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(55, 15);
            this.lbl_Sex.TabIndex = 25;
            this.lbl_Sex.Text = "label8";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(204, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(55, 15);
            this.lbl_Name.TabIndex = 24;
            this.lbl_Name.Text = "label7";
            // 
            // lbl_BedNo
            // 
            this.lbl_BedNo.AutoSize = true;
            this.lbl_BedNo.Location = new System.Drawing.Point(61, 9);
            this.lbl_BedNo.Name = "lbl_BedNo";
            this.lbl_BedNo.Size = new System.Drawing.Size(79, 15);
            this.lbl_BedNo.TabIndex = 23;
            this.lbl_BedNo.Text = "lbl_BedNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "病人ID：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "床号：";
            // 
            // SearchAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_Execute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_InHosptial);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Sex);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_BedNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchAdvice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchAdvice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchAdvice_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Execute)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Execute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_Executing;
        private System.Windows.Forms.RadioButton rbtn_execute;
        private System.Windows.Forms.RadioButton rbtn_Allexecute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_temporary;
        private System.Windows.Forms.RadioButton rbtn_Long;
        private System.Windows.Forms.RadioButton rbtn_AllType;
        private System.Windows.Forms.Label lbl_InHosptial;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_BedNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_Stop;
    }
}