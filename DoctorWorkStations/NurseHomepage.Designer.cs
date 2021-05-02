namespace DoctorWorkStations
{
    partial class NurseHomepage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.病人管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnterDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.转科ChangeDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.退出Out = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.病人管理ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 病人管理ToolStripMenuItem
            // 
            this.病人管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnterDepartment,
            this.转科ChangeDepartment,
            this.RegisterInformation,
            this.退出Out});
            this.病人管理ToolStripMenuItem.Name = "病人管理ToolStripMenuItem";
            this.病人管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.病人管理ToolStripMenuItem.Text = "病人管理";
            // 
            // EnterDepartment
            // 
            this.EnterDepartment.Name = "EnterDepartment";
            this.EnterDepartment.Size = new System.Drawing.Size(216, 26);
            this.EnterDepartment.Text = "入科";
            this.EnterDepartment.Click += new System.EventHandler(this.EnterDepartment_Click);
            // 
            // 转科ChangeDepartment
            // 
            this.转科ChangeDepartment.Name = "转科ChangeDepartment";
            this.转科ChangeDepartment.Size = new System.Drawing.Size(216, 26);
            this.转科ChangeDepartment.Text = "转科";
            this.转科ChangeDepartment.Click += new System.EventHandler(this.转科ChangeDepartment_Click);
            // 
            // RegisterInformation
            // 
            this.RegisterInformation.Name = "RegisterInformation";
            this.RegisterInformation.Size = new System.Drawing.Size(216, 26);
            this.RegisterInformation.Text = "信息登记";
            this.RegisterInformation.Click += new System.EventHandler(this.RegisterInformation_Click);
            // 
            // 退出Out
            // 
            this.退出Out.Name = "退出Out";
            this.退出Out.Size = new System.Drawing.Size(216, 26);
            this.退出Out.Text = "退出";
            this.退出Out.Click += new System.EventHandler(this.退出Out_Click);
            // 
            // NurseHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NurseHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "护士工作站";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 病人管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterInformation;
        private System.Windows.Forms.ToolStripMenuItem EnterDepartment;
        private System.Windows.Forms.ToolStripMenuItem 转科ChangeDepartment;
        private System.Windows.Forms.ToolStripMenuItem 退出Out;
    }
}