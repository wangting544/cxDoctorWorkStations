namespace DoctorWorkStations
{
    partial class MCreate
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgv_Patient = new System.Windows.Forms.DataGridView();
            this.btn_Ensure = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Patient
            // 
            this.dgv_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patient.Location = new System.Drawing.Point(12, 35);
            this.dgv_Patient.Name = "dgv_Patient";
            this.dgv_Patient.RowTemplate.Height = 27;
            this.dgv_Patient.Size = new System.Drawing.Size(766, 313);
            this.dgv_Patient.TabIndex = 0;
            // 
            // btn_Ensure
            // 
            this.btn_Ensure.Location = new System.Drawing.Point(424, 383);
            this.btn_Ensure.Name = "btn_Ensure";
            this.btn_Ensure.Size = new System.Drawing.Size(75, 33);
            this.btn_Ensure.TabIndex = 1;
            this.btn_Ensure.Text = "确定&O";
            this.btn_Ensure.UseVisualStyleBackColor = true;
            this.btn_Ensure.Click += new System.EventHandler(this.btn_Ensure_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(548, 382);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 34);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "取消&C";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // MCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ensure);
            this.Controls.Add(this.dgv_Patient);
            this.Name = "MCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新入病人";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MCreate_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgv_Patient;
        private System.Windows.Forms.Button btn_Ensure;
        private System.Windows.Forms.Button btn_Cancel;
    }
}