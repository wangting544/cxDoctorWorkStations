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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_drug = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gb_Name = new System.Windows.Forms.GroupBox();
            this.txt_ChineseName = new System.Windows.Forms.TextBox();
            this.txt_EnglishName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Effect = new System.Windows.Forms.TextBox();
            this.gb_Name.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "药品：";
            // 
            // cb_drug
            // 
            this.cb_drug.FormattingEnabled = true;
            this.cb_drug.Location = new System.Drawing.Point(135, 12);
            this.cb_drug.Name = "cb_drug";
            this.cb_drug.Size = new System.Drawing.Size(153, 23);
            this.cb_drug.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(315, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 30);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gb_Name
            // 
            this.gb_Name.Controls.Add(this.txt_EnglishName);
            this.gb_Name.Controls.Add(this.txt_ChineseName);
            this.gb_Name.Location = new System.Drawing.Point(54, 60);
            this.gb_Name.Name = "gb_Name";
            this.gb_Name.Size = new System.Drawing.Size(692, 100);
            this.gb_Name.TabIndex = 3;
            this.gb_Name.TabStop = false;
            this.gb_Name.Text = "药品名称";
            // 
            // txt_ChineseName
            // 
            this.txt_ChineseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ChineseName.Location = new System.Drawing.Point(109, 24);
            this.txt_ChineseName.Multiline = true;
            this.txt_ChineseName.Name = "txt_ChineseName";
            this.txt_ChineseName.ReadOnly = true;
            this.txt_ChineseName.Size = new System.Drawing.Size(309, 25);
            this.txt_ChineseName.TabIndex = 0;
            // 
            // txt_EnglishName
            // 
            this.txt_EnglishName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_EnglishName.Location = new System.Drawing.Point(109, 55);
            this.txt_EnglishName.Multiline = true;
            this.txt_EnglishName.Name = "txt_EnglishName";
            this.txt_EnglishName.ReadOnly = true;
            this.txt_EnglishName.Size = new System.Drawing.Size(309, 25);
            this.txt_EnglishName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Effect);
            this.groupBox1.Location = new System.Drawing.Point(54, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "适应性";
            // 
            // txt_Effect
            // 
            this.txt_Effect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Effect.Location = new System.Drawing.Point(43, 25);
            this.txt_Effect.Multiline = true;
            this.txt_Effect.Name = "txt_Effect";
            this.txt_Effect.ReadOnly = true;
            this.txt_Effect.Size = new System.Drawing.Size(605, 165);
            this.txt_Effect.TabIndex = 0;
            // 
            // DrugSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Name);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_drug);
            this.Controls.Add(this.label1);
            this.Name = "DrugSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "药品信息";
            this.gb_Name.ResumeLayout(false);
            this.gb_Name.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_drug;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_Name;
        private System.Windows.Forms.TextBox txt_EnglishName;
        private System.Windows.Forms.TextBox txt_ChineseName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Effect;
    }
}