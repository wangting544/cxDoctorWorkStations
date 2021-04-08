namespace DoctorWorkStations
{
    partial class StudyCase
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
            this.dgvStudyCase = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudyCase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudyCase
            // 
            this.dgvStudyCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudyCase.Location = new System.Drawing.Point(44, 40);
            this.dgvStudyCase.Name = "dgvStudyCase";
            this.dgvStudyCase.RowTemplate.Height = 27;
            this.dgvStudyCase.Size = new System.Drawing.Size(686, 272);
            this.dgvStudyCase.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(635, 362);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 30);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "关闭(&C)";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(536, 362);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 30);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "提交(&C)";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // StudyCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.dgvStudyCase);
            this.Name = "StudyCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学习病历";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudyCase_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudyCase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudyCase;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Submit;
    }
}