namespace DoctorWorkStations
{
    partial class NCheckAdvice
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
            this.dgv_Advice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_inHosptial = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_SearchAll = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Advice
            // 
            this.dgv_Advice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Advice.Location = new System.Drawing.Point(12, 95);
            this.dgv_Advice.Name = "dgv_Advice";
            this.dgv_Advice.RowTemplate.Height = 27;
            this.dgv_Advice.Size = new System.Drawing.Size(1182, 312);
            this.dgv_Advice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "病人住院号：";
            // 
            // cb_inHosptial
            // 
            this.cb_inHosptial.FormattingEnabled = true;
            this.cb_inHosptial.Location = new System.Drawing.Point(138, 10);
            this.cb_inHosptial.Name = "cb_inHosptial";
            this.cb_inHosptial.Size = new System.Drawing.Size(121, 23);
            this.cb_inHosptial.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(289, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 31);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "查看";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_SearchAll
            // 
            this.btn_SearchAll.Location = new System.Drawing.Point(405, 10);
            this.btn_SearchAll.Name = "btn_SearchAll";
            this.btn_SearchAll.Size = new System.Drawing.Size(120, 30);
            this.btn_SearchAll.TabIndex = 4;
            this.btn_SearchAll.Text = "查看全部";
            this.btn_SearchAll.UseVisualStyleBackColor = true;
            this.btn_SearchAll.Click += new System.EventHandler(this.btn_SearchAll_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(594, 10);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 29);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // NCheckAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 450);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_SearchAll);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_inHosptial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Advice);
            this.Name = "NCheckAdvice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCheckAdvice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NCheckAdvice_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Advice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_inHosptial;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_SearchAll;
        private System.Windows.Forms.Button btn_Submit;
    }
}