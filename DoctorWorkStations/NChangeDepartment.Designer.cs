namespace DoctorWorkStations
{
    partial class NChangeDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChangeDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Patient
            // 
            this.dgv_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patient.Location = new System.Drawing.Point(41, 38);
            this.dgv_Patient.Name = "dgv_Patient";
            this.dgv_Patient.RowTemplate.Height = 27;
            this.dgv_Patient.Size = new System.Drawing.Size(553, 382);
            this.dgv_Patient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "在科病人";
            // 
            // btn_ChangeDepartment
            // 
            this.btn_ChangeDepartment.Location = new System.Drawing.Point(628, 38);
            this.btn_ChangeDepartment.Name = "btn_ChangeDepartment";
            this.btn_ChangeDepartment.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangeDepartment.TabIndex = 2;
            this.btn_ChangeDepartment.Text = "转科";
            this.btn_ChangeDepartment.UseVisualStyleBackColor = true;
            this.btn_ChangeDepartment.Click += new System.EventHandler(this.btn_ChangeDepartment_Click);
            // 
            // NChangeDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ChangeDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Patient);
            this.Name = "NChangeDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "转科";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NChangeDepartment_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Patient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChangeDepartment;
    }
}