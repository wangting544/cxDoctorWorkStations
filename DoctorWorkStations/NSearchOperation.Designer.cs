namespace DoctorWorkStations
{
    partial class NSearchOperation
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
            this.dgv_Operation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Operation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Operation
            // 
            this.dgv_Operation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Operation.Location = new System.Drawing.Point(29, 104);
            this.dgv_Operation.Name = "dgv_Operation";
            this.dgv_Operation.RowTemplate.Height = 27;
            this.dgv_Operation.Size = new System.Drawing.Size(699, 274);
            this.dgv_Operation.TabIndex = 0;
            // 
            // NSearchOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Operation);
            this.Name = "NSearchOperation";
            this.Text = "NSearchOperation";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Operation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Operation;
    }
}