namespace DoctorWorkStations
{
    partial class ChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Old = new System.Windows.Forms.TextBox();
            this.txt_New = new System.Windows.Forms.TextBox();
            this.txt_Check = new System.Windows.Forms.TextBox();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.btnSure = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "旧口令：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确定口令：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "新口令：";
            // 
            // txt_Old
            // 
            this.txt_Old.Location = new System.Drawing.Point(269, 68);
            this.txt_Old.Name = "txt_Old";
            this.txt_Old.Size = new System.Drawing.Size(146, 25);
            this.txt_Old.TabIndex = 4;
            // 
            // txt_New
            // 
            this.txt_New.Location = new System.Drawing.Point(269, 99);
            this.txt_New.Name = "txt_New";
            this.txt_New.Size = new System.Drawing.Size(146, 25);
            this.txt_New.TabIndex = 5;
            // 
            // txt_Check
            // 
            this.txt_Check.Location = new System.Drawing.Point(269, 130);
            this.txt_Check.Name = "txt_Check";
            this.txt_Check.Size = new System.Drawing.Size(146, 25);
            this.txt_Check.TabIndex = 6;
            // 
            // txt_No
            // 
            this.txt_No.Location = new System.Drawing.Point(269, 37);
            this.txt_No.Name = "txt_No";
            this.txt_No.ReadOnly = true;
            this.txt_No.Size = new System.Drawing.Size(146, 25);
            this.txt_No.TabIndex = 7;
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(214, 185);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 8;
            this.btnSure.Text = "确认";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 371);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.txt_No);
            this.Controls.Add(this.txt_Check);
            this.Controls.Add(this.txt_New);
            this.Controls.Add(this.txt_Old);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改口令";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Old;
        private System.Windows.Forms.TextBox txt_New;
        private System.Windows.Forms.TextBox txt_Check;
        private System.Windows.Forms.TextBox txt_No;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnCancel;
    }
}