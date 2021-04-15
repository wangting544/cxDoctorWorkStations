namespace DoctorWorkStations
{
    partial class leaveHosptial
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
            this.dgv_leaveHosptial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leaveHosptial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_leaveHosptial
            // 
            this.dgv_leaveHosptial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_leaveHosptial.Location = new System.Drawing.Point(43, 12);
            this.dgv_leaveHosptial.Name = "dgv_leaveHosptial";
            this.dgv_leaveHosptial.RowTemplate.Height = 27;
            this.dgv_leaveHosptial.Size = new System.Drawing.Size(648, 286);
            this.dgv_leaveHosptial.TabIndex = 0;
            this.dgv_leaveHosptial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_leaveHosptial_CellContentClick);
            // 
            // leaveHosptial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_leaveHosptial);
            this.Name = "leaveHosptial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "病人出院";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.leaveHosptial_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leaveHosptial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_leaveHosptial;
    }
}