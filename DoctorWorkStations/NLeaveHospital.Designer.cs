namespace DoctorWorkStations
{
    partial class NLeaveHospital
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
            this.dgv_LeaveHosptial = new System.Windows.Forms.DataGridView();
            this.btn_Leave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LeaveHosptial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LeaveHosptial
            // 
            this.dgv_LeaveHosptial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LeaveHosptial.Location = new System.Drawing.Point(40, 69);
            this.dgv_LeaveHosptial.Name = "dgv_LeaveHosptial";
            this.dgv_LeaveHosptial.RowTemplate.Height = 27;
            this.dgv_LeaveHosptial.Size = new System.Drawing.Size(691, 320);
            this.dgv_LeaveHosptial.TabIndex = 0;
            // 
            // btn_Leave
            // 
            this.btn_Leave.Location = new System.Drawing.Point(77, 33);
            this.btn_Leave.Name = "btn_Leave";
            this.btn_Leave.Size = new System.Drawing.Size(75, 30);
            this.btn_Leave.TabIndex = 1;
            this.btn_Leave.Text = "出院";
            this.btn_Leave.UseVisualStyleBackColor = true;
            this.btn_Leave.Click += new System.EventHandler(this.btn_Leave_Click);
            // 
            // NLeaveHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Leave);
            this.Controls.Add(this.dgv_LeaveHosptial);
            this.Name = "NLeaveHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出院";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NLeaveHospital_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LeaveHosptial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LeaveHosptial;
        private System.Windows.Forms.Button btn_Leave;
    }
}