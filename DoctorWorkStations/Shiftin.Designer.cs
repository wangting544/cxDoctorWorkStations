namespace DoctorWorkStations
{
    partial class Shiftin
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
            this.dgv_Patient = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_Inhospital = new System.Windows.Forms.RadioButton();
            this.rbtn_Study = new System.Windows.Forms.RadioButton();
            this.btnSure = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Patient
            // 
            this.dgv_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patient.Location = new System.Drawing.Point(26, 12);
            this.dgv_Patient.Name = "dgv_Patient";
            this.dgv_Patient.RowTemplate.Height = 27;
            this.dgv_Patient.Size = new System.Drawing.Size(336, 317);
            this.dgv_Patient.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_Inhospital);
            this.panel1.Controls.Add(this.rbtn_Study);
            this.panel1.Location = new System.Drawing.Point(381, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 100);
            this.panel1.TabIndex = 1;
            // 
            // rbtn_Inhospital
            // 
            this.rbtn_Inhospital.AutoSize = true;
            this.rbtn_Inhospital.Location = new System.Drawing.Point(25, 60);
            this.rbtn_Inhospital.Name = "rbtn_Inhospital";
            this.rbtn_Inhospital.Size = new System.Drawing.Size(88, 19);
            this.rbtn_Inhospital.TabIndex = 1;
            this.rbtn_Inhospital.TabStop = true;
            this.rbtn_Inhospital.Text = "在院病历";
            this.rbtn_Inhospital.UseVisualStyleBackColor = true;
            // 
            // rbtn_Study
            // 
            this.rbtn_Study.AutoSize = true;
            this.rbtn_Study.Location = new System.Drawing.Point(25, 24);
            this.rbtn_Study.Name = "rbtn_Study";
            this.rbtn_Study.Size = new System.Drawing.Size(88, 19);
            this.rbtn_Study.TabIndex = 0;
            this.rbtn_Study.TabStop = true;
            this.rbtn_Study.Text = "学习病历";
            this.rbtn_Study.UseVisualStyleBackColor = true;
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(406, 177);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(88, 32);
            this.btnSure.TabIndex = 2;
            this.btnSure.Text = "确认&O";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(406, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消&C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Shiftin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 347);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Patient);
            this.Name = "Shiftin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "移出";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shiftin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Patient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_Inhospital;
        private System.Windows.Forms.RadioButton rbtn_Study;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnCancel;
    }
}