namespace DoctorWorkStations
{
    partial class DiseaseCourse
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
            this.txt_Topic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBox_Model = new System.Windows.Forms.ComboBox();
            this.btn_Write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "病历主题：";
            // 
            // txt_Topic
            // 
            this.txt_Topic.Location = new System.Drawing.Point(202, 90);
            this.txt_Topic.Name = "txt_Topic";
            this.txt_Topic.Size = new System.Drawing.Size(121, 25);
            this.txt_Topic.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "模板：";
            // 
            // cBox_Model
            // 
            this.cBox_Model.FormattingEnabled = true;
            this.cBox_Model.Items.AddRange(new object[] {
            "入科记录",
            "会诊记录"});
            this.cBox_Model.Location = new System.Drawing.Point(202, 140);
            this.cBox_Model.Name = "cBox_Model";
            this.cBox_Model.Size = new System.Drawing.Size(121, 23);
            this.cBox_Model.TabIndex = 4;
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(202, 211);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_Write.TabIndex = 5;
            this.btn_Write.Text = "编辑";
            this.btn_Write.UseVisualStyleBackColor = true;
            // 
            // DiseaseCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 319);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.cBox_Model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Topic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiseaseCourse";
            this.Text = "病历";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Topic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBox_Model;
        private System.Windows.Forms.Button btn_Write;
    }
}