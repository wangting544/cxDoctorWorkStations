namespace DoctorWorkStations
{
    partial class AdvicePackage
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dgv_DoctorAdvice = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoctorAdvice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "套餐医嘱名称:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(150, 29);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(338, 25);
            this.txt_Name.TabIndex = 1;
            // 
            // dgv_DoctorAdvice
            // 
            this.dgv_DoctorAdvice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoctorAdvice.Location = new System.Drawing.Point(24, 85);
            this.dgv_DoctorAdvice.Name = "dgv_DoctorAdvice";
            this.dgv_DoctorAdvice.RowTemplate.Height = 27;
            this.dgv_DoctorAdvice.Size = new System.Drawing.Size(740, 266);
            this.dgv_DoctorAdvice.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(536, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "新建(&C)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(635, 400);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 30);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "关闭(&C)";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(534, 30);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 30);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(443, 400);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 30);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // AdvicePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgv_DoctorAdvice);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Name = "AdvicePackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "医嘱";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdvicePackage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoctorAdvice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DataGridView dgv_DoctorAdvice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
    }
}