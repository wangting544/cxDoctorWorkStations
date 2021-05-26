namespace DoctorWorkStations
{
    partial class NLookAdvice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn_executed = new System.Windows.Forms.RadioButton();
            this.rbtn_Executing = new System.Windows.Forms.RadioButton();
            this.rbtn_Stop = new System.Windows.Forms.RadioButton();
            this.rbtn_All = new System.Windows.Forms.RadioButton();
            this.dgv_Advice = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_executed);
            this.panel1.Controls.Add(this.rbtn_Executing);
            this.panel1.Controls.Add(this.rbtn_Stop);
            this.panel1.Controls.Add(this.rbtn_All);
            this.panel1.Location = new System.Drawing.Point(73, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 41);
            this.panel1.TabIndex = 0;
            // 
            // rbtn_executed
            // 
            this.rbtn_executed.AutoSize = true;
            this.rbtn_executed.Location = new System.Drawing.Point(487, 12);
            this.rbtn_executed.Name = "rbtn_executed";
            this.rbtn_executed.Size = new System.Drawing.Size(73, 19);
            this.rbtn_executed.TabIndex = 3;
            this.rbtn_executed.TabStop = true;
            this.rbtn_executed.Text = "执行完";
            this.rbtn_executed.UseVisualStyleBackColor = true;
            this.rbtn_executed.CheckedChanged += new System.EventHandler(this.rbtn_executed_CheckedChanged);
            // 
            // rbtn_Executing
            // 
            this.rbtn_Executing.AutoSize = true;
            this.rbtn_Executing.Location = new System.Drawing.Point(341, 12);
            this.rbtn_Executing.Name = "rbtn_Executing";
            this.rbtn_Executing.Size = new System.Drawing.Size(73, 19);
            this.rbtn_Executing.TabIndex = 2;
            this.rbtn_Executing.TabStop = true;
            this.rbtn_Executing.Text = "执行中";
            this.rbtn_Executing.UseVisualStyleBackColor = true;
            this.rbtn_Executing.CheckedChanged += new System.EventHandler(this.rbtn_Executing_CheckedChanged);
            // 
            // rbtn_Stop
            // 
            this.rbtn_Stop.AutoSize = true;
            this.rbtn_Stop.Location = new System.Drawing.Point(184, 12);
            this.rbtn_Stop.Name = "rbtn_Stop";
            this.rbtn_Stop.Size = new System.Drawing.Size(73, 19);
            this.rbtn_Stop.TabIndex = 1;
            this.rbtn_Stop.TabStop = true;
            this.rbtn_Stop.Text = "已停止";
            this.rbtn_Stop.UseVisualStyleBackColor = true;
            this.rbtn_Stop.CheckedChanged += new System.EventHandler(this.rbtn_Stop_CheckedChanged);
            // 
            // rbtn_All
            // 
            this.rbtn_All.AutoSize = true;
            this.rbtn_All.Location = new System.Drawing.Point(35, 12);
            this.rbtn_All.Name = "rbtn_All";
            this.rbtn_All.Size = new System.Drawing.Size(88, 19);
            this.rbtn_All.TabIndex = 0;
            this.rbtn_All.TabStop = true;
            this.rbtn_All.Text = "所有医嘱";
            this.rbtn_All.UseVisualStyleBackColor = true;
            this.rbtn_All.CheckedChanged += new System.EventHandler(this.rbtn_All_CheckedChanged);
            // 
            // dgv_Advice
            // 
            this.dgv_Advice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Advice.Location = new System.Drawing.Point(54, 72);
            this.dgv_Advice.Name = "dgv_Advice";
            this.dgv_Advice.RowTemplate.Height = 27;
            this.dgv_Advice.Size = new System.Drawing.Size(1140, 460);
            this.dgv_Advice.TabIndex = 1;
            // 
            // NLookAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 566);
            this.Controls.Add(this.dgv_Advice);
            this.Controls.Add(this.panel1);
            this.Name = "NLookAdvice";
            this.Text = "查看医嘱";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NLookAdvice_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Advice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_Executing;
        private System.Windows.Forms.RadioButton rbtn_Stop;
        private System.Windows.Forms.RadioButton rbtn_All;
        private System.Windows.Forms.RadioButton rbtn_executed;
        private System.Windows.Forms.DataGridView dgv_Advice;
    }
}