namespace DoctorWorkStations
{
    partial class Temperature
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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dgv_Record = new System.Windows.Forms.DataGridView();
            this.r = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_SearchAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Record)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(91, 32);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 25);
            this.dtp_date.TabIndex = 0;
            // 
            // dgv_Record
            // 
            this.dgv_Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Record.Location = new System.Drawing.Point(36, 123);
            this.dgv_Record.Name = "dgv_Record";
            this.dgv_Record.RowTemplate.Height = 27;
            this.dgv_Record.Size = new System.Drawing.Size(665, 240);
            this.dgv_Record.TabIndex = 1;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Location = new System.Drawing.Point(33, 39);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(52, 15);
            this.r.TabIndex = 2;
            this.r.Text = "日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "时间：";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(385, 31);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(100, 25);
            this.txt_time.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(532, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 30);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_SearchAll
            // 
            this.btn_SearchAll.Location = new System.Drawing.Point(532, 77);
            this.btn_SearchAll.Name = "btn_SearchAll";
            this.btn_SearchAll.Size = new System.Drawing.Size(75, 30);
            this.btn_SearchAll.TabIndex = 6;
            this.btn_SearchAll.Text = "查询全部";
            this.btn_SearchAll.UseVisualStyleBackColor = true;
            this.btn_SearchAll.Click += new System.EventHandler(this.btn_SearchAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SearchAll);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r);
            this.Controls.Add(this.dgv_Record);
            this.Controls.Add(this.dtp_date);
            this.Name = "Temperature";
            this.Text = "体症记录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Temperature_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Record)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DataGridView dgv_Record;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_SearchAll;
        private System.Windows.Forms.Label label2;
    }
}