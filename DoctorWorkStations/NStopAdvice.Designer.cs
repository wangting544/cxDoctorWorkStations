namespace DoctorWorkStations
{
    partial class NStopAdvice
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
            this.cb_PatientNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_SearchAll = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_Advice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advice)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_PatientNo
            // 
            this.cb_PatientNo.FormattingEnabled = true;
            this.cb_PatientNo.Location = new System.Drawing.Point(131, 12);
            this.cb_PatientNo.Name = "cb_PatientNo";
            this.cb_PatientNo.Size = new System.Drawing.Size(121, 23);
            this.cb_PatientNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "病人号：";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(580, 7);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 29);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_SearchAll
            // 
            this.btn_SearchAll.Location = new System.Drawing.Point(391, 7);
            this.btn_SearchAll.Name = "btn_SearchAll";
            this.btn_SearchAll.Size = new System.Drawing.Size(120, 30);
            this.btn_SearchAll.TabIndex = 7;
            this.btn_SearchAll.Text = "查看全部";
            this.btn_SearchAll.UseVisualStyleBackColor = true;
            this.btn_SearchAll.Click += new System.EventHandler(this.btn_SearchAll_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(275, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 31);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "查看";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_Advice
            // 
            this.dgv_Advice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Advice.Location = new System.Drawing.Point(42, 85);
            this.dgv_Advice.Name = "dgv_Advice";
            this.dgv_Advice.RowTemplate.Height = 27;
            this.dgv_Advice.Size = new System.Drawing.Size(1108, 329);
            this.dgv_Advice.TabIndex = 9;
            // 
            // NStopAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.dgv_Advice);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_SearchAll);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_PatientNo);
            this.Name = "NStopAdvice";
            this.Text = "停止医嘱";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NStopAdvice_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_PatientNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_SearchAll;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Advice;
    }
}