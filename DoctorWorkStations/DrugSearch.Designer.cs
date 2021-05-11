namespace DoctorWorkStations
{
    partial class DrugSearch
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
            this.btn_SearchByNo = new System.Windows.Forms.Button();
            this.dgv_Drug = new System.Windows.Forms.DataGridView();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.txt_Py = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_SearchByName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SearchByNo
            // 
            this.btn_SearchByNo.Location = new System.Drawing.Point(244, 3);
            this.btn_SearchByNo.Name = "btn_SearchByNo";
            this.btn_SearchByNo.Size = new System.Drawing.Size(126, 30);
            this.btn_SearchByNo.TabIndex = 2;
            this.btn_SearchByNo.Text = "按照编号查询";
            this.btn_SearchByNo.UseVisualStyleBackColor = true;
            this.btn_SearchByNo.Click += new System.EventHandler(this.btn_SearchByNo_Click);
            // 
            // dgv_Drug
            // 
            this.dgv_Drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Drug.Location = new System.Drawing.Point(26, 142);
            this.dgv_Drug.Name = "dgv_Drug";
            this.dgv_Drug.RowTemplate.Height = 27;
            this.dgv_Drug.Size = new System.Drawing.Size(683, 267);
            this.dgv_Drug.TabIndex = 3;
            // 
            // txt_No
            // 
            this.txt_No.Location = new System.Drawing.Point(61, 8);
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(177, 25);
            this.txt_No.TabIndex = 4;
            // 
            // txt_Py
            // 
            this.txt_Py.Location = new System.Drawing.Point(475, 55);
            this.txt_Py.Name = "txt_Py";
            this.txt_Py.Size = new System.Drawing.Size(177, 25);
            this.txt_Py.TabIndex = 6;
            this.txt_Py.TextChanged += new System.EventHandler(this.txt_Py_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(61, 60);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(177, 25);
            this.txt_Name.TabIndex = 8;
            // 
            // btn_SearchByName
            // 
            this.btn_SearchByName.Location = new System.Drawing.Point(244, 55);
            this.btn_SearchByName.Name = "btn_SearchByName";
            this.btn_SearchByName.Size = new System.Drawing.Size(126, 30);
            this.btn_SearchByName.TabIndex = 7;
            this.btn_SearchByName.Text = "按照名称查询";
            this.btn_SearchByName.UseVisualStyleBackColor = true;
            this.btn_SearchByName.Click += new System.EventHandler(this.btn_SearchByName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "按照拼音查询：";
            // 
            // DrugSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_SearchByName);
            this.Controls.Add(this.txt_Py);
            this.Controls.Add(this.txt_No);
            this.Controls.Add(this.dgv_Drug);
            this.Controls.Add(this.btn_SearchByNo);
            this.Name = "DrugSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "药品信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DrugSearch_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SearchByNo;
        private System.Windows.Forms.DataGridView dgv_Drug;
        private System.Windows.Forms.TextBox txt_No;
        private System.Windows.Forms.TextBox txt_Py;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_SearchByName;
        private System.Windows.Forms.Label label1;
    }
}