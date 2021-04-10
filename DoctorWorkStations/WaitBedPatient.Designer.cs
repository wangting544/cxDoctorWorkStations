namespace DoctorWorkStations
{
    partial class WaitBedPatient
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
            this.dgv_WaitBedPatient = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WaitBedPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_WaitBedPatient
            // 
            this.dgv_WaitBedPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_WaitBedPatient.Location = new System.Drawing.Point(46, 54);
            this.dgv_WaitBedPatient.Name = "dgv_WaitBedPatient";
            this.dgv_WaitBedPatient.RowTemplate.Height = 27;
            this.dgv_WaitBedPatient.Size = new System.Drawing.Size(706, 304);
            this.dgv_WaitBedPatient.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(698, 392);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(597, 391);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 30);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // WaitBedPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dgv_WaitBedPatient);
            this.Name = "WaitBedPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "等床病人";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WaitBedPatient_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WaitBedPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_WaitBedPatient;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Submit;
    }
}