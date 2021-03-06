namespace DoctorWorkStations
{
    partial class HomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CaseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.Shift_in = new System.Windows.Forms.ToolStripMenuItem();
            this.Shift_out = new System.Windows.Forms.ToolStripMenuItem();
            this.Property = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空白化验单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.制式化验单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchDisease = new System.Windows.Forms.ToolStripMenuItem();
            this.StudyCase = new System.Windows.Forms.ToolStripMenuItem();
            this.AdvicePackage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Drug = new System.Windows.Forms.ToolStripMenuItem();
            this.LeaveHosptial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_WaitBedPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.选择摆药药局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Patient = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbox_ParientOperate = new System.Windows.Forms.ListBox();
            this.lbl_Doctor = new System.Windows.Forms.Label();
            this.按主题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按医生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaseHistory,
            this.工具TToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CaseHistory
            // 
            this.CaseHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.Shift_in,
            this.Shift_out,
            this.Property,
            this.Quit});
            this.CaseHistory.Name = "CaseHistory";
            this.CaseHistory.Size = new System.Drawing.Size(96, 24);
            this.CaseHistory.Text = "病历（&M）";
            // 
            // Create
            // 
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(134, 26);
            this.Create.Text = "新建";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Shift_in
            // 
            this.Shift_in.Name = "Shift_in";
            this.Shift_in.Size = new System.Drawing.Size(134, 26);
            this.Shift_in.Text = "移入";
            this.Shift_in.Click += new System.EventHandler(this.Shift_in_Click);
            // 
            // Shift_out
            // 
            this.Shift_out.Name = "Shift_out";
            this.Shift_out.Size = new System.Drawing.Size(134, 26);
            this.Shift_out.Text = "移出";
            this.Shift_out.Click += new System.EventHandler(this.Shift_out_Click);
            // 
            // Property
            // 
            this.Property.Name = "Property";
            this.Property.Size = new System.Drawing.Size(134, 26);
            this.Property.Text = "属性";
            this.Property.Click += new System.EventHandler(this.Property_Click);
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(134, 26);
            this.Quit.Text = "退出(&X)";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.空白化验单ToolStripMenuItem,
            this.制式化验单ToolStripMenuItem,
            this.SearchDisease,
            this.StudyCase,
            this.AdvicePackage,
            this.tsm_Drug,
            this.LeaveHosptial,
            this.tsm_WaitBedPatient,
            this.选择摆药药局ToolStripMenuItem,
            this.ChangePassword});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.工具TToolStripMenuItem.Text = "工具（&T）";
            // 
            // 空白化验单ToolStripMenuItem
            // 
            this.空白化验单ToolStripMenuItem.Name = "空白化验单ToolStripMenuItem";
            this.空白化验单ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.空白化验单ToolStripMenuItem.Text = "空白化验单";
            // 
            // 制式化验单ToolStripMenuItem
            // 
            this.制式化验单ToolStripMenuItem.Name = "制式化验单ToolStripMenuItem";
            this.制式化验单ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.制式化验单ToolStripMenuItem.Text = "制式化验单";
            // 
            // SearchDisease
            // 
            this.SearchDisease.Name = "SearchDisease";
            this.SearchDisease.Size = new System.Drawing.Size(174, 26);
            this.SearchDisease.Text = "病案检索";
            this.SearchDisease.Click += new System.EventHandler(this.SearchDisease_Click);
            // 
            // StudyCase
            // 
            this.StudyCase.Name = "StudyCase";
            this.StudyCase.Size = new System.Drawing.Size(174, 26);
            this.StudyCase.Text = "学习病历";
            this.StudyCase.Click += new System.EventHandler(this.StudyCase_Click);
            // 
            // AdvicePackage
            // 
            this.AdvicePackage.Name = "AdvicePackage";
            this.AdvicePackage.Size = new System.Drawing.Size(174, 26);
            this.AdvicePackage.Text = "套餐医嘱定义";
            this.AdvicePackage.Click += new System.EventHandler(this.AdvicePackage_Click);
            // 
            // tsm_Drug
            // 
            this.tsm_Drug.Name = "tsm_Drug";
            this.tsm_Drug.Size = new System.Drawing.Size(174, 26);
            this.tsm_Drug.Text = "药品字典";
            this.tsm_Drug.Click += new System.EventHandler(this.tsm_Drug_Click);
            // 
            // LeaveHosptial
            // 
            this.LeaveHosptial.Name = "LeaveHosptial";
            this.LeaveHosptial.Size = new System.Drawing.Size(174, 26);
            this.LeaveHosptial.Text = "出院通知";
            this.LeaveHosptial.Click += new System.EventHandler(this.LeaveHosptial_Click);
            // 
            // tsm_WaitBedPatient
            // 
            this.tsm_WaitBedPatient.Name = "tsm_WaitBedPatient";
            this.tsm_WaitBedPatient.Size = new System.Drawing.Size(174, 26);
            this.tsm_WaitBedPatient.Text = "等床病人";
            this.tsm_WaitBedPatient.Click += new System.EventHandler(this.bsm_WaitBedPatient_Click);
            // 
            // 选择摆药药局ToolStripMenuItem
            // 
            this.选择摆药药局ToolStripMenuItem.Name = "选择摆药药局ToolStripMenuItem";
            this.选择摆药药局ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.选择摆药药局ToolStripMenuItem.Text = "选择摆药药局";
            // 
            // ChangePassword
            // 
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(174, 26);
            this.ChangePassword.Text = "修改口令";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(160, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 419);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "病人列表";
            // 
            // lb_Patient
            // 
            this.lb_Patient.FormattingEnabled = true;
            this.lb_Patient.ItemHeight = 15;
            this.lb_Patient.Location = new System.Drawing.Point(15, 49);
            this.lb_Patient.Name = "lb_Patient";
            this.lb_Patient.Size = new System.Drawing.Size(139, 364);
            this.lb_Patient.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.lbox_ParientOperate);
            this.groupBox1.Location = new System.Drawing.Point(190, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 364);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lbox_ParientOperate
            // 
            this.lbox_ParientOperate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox_ParientOperate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbox_ParientOperate.FormattingEnabled = true;
            this.lbox_ParientOperate.ItemHeight = 20;
            this.lbox_ParientOperate.Items.AddRange(new object[] {
            "病程",
            "检查",
            "检验",
            "首页",
            "体温",
            "医嘱"});
            this.lbox_ParientOperate.Location = new System.Drawing.Point(6, 24);
            this.lbox_ParientOperate.Name = "lbox_ParientOperate";
            this.lbox_ParientOperate.Size = new System.Drawing.Size(120, 140);
            this.lbox_ParientOperate.TabIndex = 0;
            this.lbox_ParientOperate.SelectedIndexChanged += new System.EventHandler(this.lbox_ParientOperate_SelectedIndexChanged);
            // 
            // lbl_Doctor
            // 
            this.lbl_Doctor.AutoSize = true;
            this.lbl_Doctor.Location = new System.Drawing.Point(597, 28);
            this.lbl_Doctor.Name = "lbl_Doctor";
            this.lbl_Doctor.Size = new System.Drawing.Size(55, 15);
            this.lbl_Doctor.TabIndex = 6;
            this.lbl_Doctor.Text = "label2";
            // 
            // 按主题ToolStripMenuItem
            // 
            this.按主题ToolStripMenuItem.Name = "按主题ToolStripMenuItem";
            this.按主题ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.按主题ToolStripMenuItem.Text = "按主题";
            // 
            // 按医生ToolStripMenuItem
            // 
            this.按医生ToolStripMenuItem.Name = "按医生ToolStripMenuItem";
            this.按医生ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.按医生ToolStripMenuItem.Text = "按医生";
            // 
            // 按时间ToolStripMenuItem
            // 
            this.按时间ToolStripMenuItem.Name = "按时间ToolStripMenuItem";
            this.按时间ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.按时间ToolStripMenuItem.Text = "按时间";
            // 
            // 按状态ToolStripMenuItem
            // 
            this.按状态ToolStripMenuItem.Name = "按状态ToolStripMenuItem";
            this.按状态ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.按状态ToolStripMenuItem.Text = "按状态";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Doctor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Patient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "医生工作站";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CaseHistory;
        private System.Windows.Forms.ToolStripMenuItem Create;
        private System.Windows.Forms.ToolStripMenuItem Shift_in;
        private System.Windows.Forms.ToolStripMenuItem Shift_out;
        private System.Windows.Forms.ToolStripMenuItem Property;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空白化验单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 制式化验单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchDisease;
        private System.Windows.Forms.ToolStripMenuItem StudyCase;
        private System.Windows.Forms.ToolStripMenuItem AdvicePackage;
        private System.Windows.Forms.ToolStripMenuItem tsm_Drug;
        private System.Windows.Forms.ToolStripMenuItem LeaveHosptial;
        private System.Windows.Forms.ToolStripMenuItem tsm_WaitBedPatient;
        private System.Windows.Forms.ToolStripMenuItem 选择摆药药局ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_Patient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbox_ParientOperate;
        private System.Windows.Forms.Label lbl_Doctor;
        private System.Windows.Forms.ToolStripMenuItem 按主题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按医生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按状态ToolStripMenuItem;
    }
}