namespace PROJECT_ONT23
{
    partial class LecturerAssess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerAssess));
            this.label2 = new System.Windows.Forms.Label();
            this.btnAssessmentManSystemExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAssignment = new System.Windows.Forms.DateTimePicker();
            this.cmbLecturerModDetails = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAssessmentStatus = new System.Windows.Forms.ComboBox();
            this.cmbAssessmentType = new System.Windows.Forms.ComboBox();
            this.dgvDisplayAssignment = new System.Windows.Forms.DataGridView();
            this.btnAddAssessment = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAssessmentExit = new System.Windows.Forms.Button();
            this.btnAssessManSystemExit = new System.Windows.Forms.Button();
            this.btnAddAssess = new System.Windows.Forms.Button();
            this.btnRefreshTb = new System.Windows.Forms.Button();
            this.btnAssExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "ASSESSMENTS  MANAGEMENT SYSTEM";
            // 
            // btnAssessmentManSystemExit
            // 
            this.btnAssessmentManSystemExit.BackColor = System.Drawing.Color.Transparent;
            this.btnAssessmentManSystemExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssessmentManSystemExit.FlatAppearance.BorderSize = 0;
            this.btnAssessmentManSystemExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessmentManSystemExit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssessmentManSystemExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAssessmentManSystemExit.Location = new System.Drawing.Point(945, -1);
            this.btnAssessmentManSystemExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssessmentManSystemExit.Name = "btnAssessmentManSystemExit";
            this.btnAssessmentManSystemExit.Size = new System.Drawing.Size(47, 49);
            this.btnAssessmentManSystemExit.TabIndex = 17;
            this.btnAssessmentManSystemExit.Text = "X";
            this.btnAssessmentManSystemExit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStudentNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpAssignment);
            this.panel1.Controls.Add(this.cmbLecturerModDetails);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbAssessmentStatus);
            this.panel1.Controls.Add(this.cmbAssessmentType);
            this.panel1.Location = new System.Drawing.Point(13, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 195);
            this.panel1.TabIndex = 18;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Enabled = false;
            this.txtStudentNo.Location = new System.Drawing.Point(175, 49);
            this.txtStudentNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(228, 21);
            this.txtStudentNo.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "NUMBER OF STUDENTS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "LECTURER MODULE NAME:";
            // 
            // dtpAssignment
            // 
            this.dtpAssignment.Location = new System.Drawing.Point(175, 83);
            this.dtpAssignment.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAssignment.Name = "dtpAssignment";
            this.dtpAssignment.Size = new System.Drawing.Size(228, 21);
            this.dtpAssignment.TabIndex = 23;
            // 
            // cmbLecturerModDetails
            // 
            this.cmbLecturerModDetails.FormattingEnabled = true;
            this.cmbLecturerModDetails.Location = new System.Drawing.Point(175, 10);
            this.cmbLecturerModDetails.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLecturerModDetails.Name = "cmbLecturerModDetails";
            this.cmbLecturerModDetails.Size = new System.Drawing.Size(228, 24);
            this.cmbLecturerModDetails.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(16, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(4, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "DUE DATE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(4, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "ASSESSMENT TYPE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(4, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "ASSESSMENT STATUS:";
            // 
            // cmbAssessmentStatus
            // 
            this.cmbAssessmentStatus.FormattingEnabled = true;
            this.cmbAssessmentStatus.Location = new System.Drawing.Point(175, 151);
            this.cmbAssessmentStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAssessmentStatus.Name = "cmbAssessmentStatus";
            this.cmbAssessmentStatus.Size = new System.Drawing.Size(228, 24);
            this.cmbAssessmentStatus.TabIndex = 17;
            // 
            // cmbAssessmentType
            // 
            this.cmbAssessmentType.FormattingEnabled = true;
            this.cmbAssessmentType.Location = new System.Drawing.Point(175, 119);
            this.cmbAssessmentType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAssessmentType.Name = "cmbAssessmentType";
            this.cmbAssessmentType.Size = new System.Drawing.Size(228, 24);
            this.cmbAssessmentType.TabIndex = 15;
            // 
            // dgvDisplayAssignment
            // 
            this.dgvDisplayAssignment.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDisplayAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssignment.Location = new System.Drawing.Point(13, 275);
            this.dgvDisplayAssignment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDisplayAssignment.Name = "dgvDisplayAssignment";
            this.dgvDisplayAssignment.Size = new System.Drawing.Size(827, 213);
            this.dgvDisplayAssignment.TabIndex = 27;
            this.dgvDisplayAssignment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAssignment_CellClick);
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddAssessment.FlatAppearance.BorderSize = 0;
            this.btnAddAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAssessment.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssessment.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddAssessment.Location = new System.Drawing.Point(875, 613);
            this.btnAddAssessment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(88, 28);
            this.btnAddAssessment.TabIndex = 44;
            this.btnAddAssessment.Text = "ADD";
            this.btnAddAssessment.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRefresh.Location = new System.Drawing.Point(173, 613);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAssessmentExit
            // 
            this.btnAssessmentExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAssessmentExit.FlatAppearance.BorderSize = 0;
            this.btnAssessmentExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessmentExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssessmentExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAssessmentExit.Location = new System.Drawing.Point(34, 613);
            this.btnAssessmentExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssessmentExit.Name = "btnAssessmentExit";
            this.btnAssessmentExit.Size = new System.Drawing.Size(88, 28);
            this.btnAssessmentExit.TabIndex = 46;
            this.btnAssessmentExit.Text = "EXIT";
            this.btnAssessmentExit.UseVisualStyleBackColor = false;
            // 
            // btnAssessManSystemExit
            // 
            this.btnAssessManSystemExit.BackColor = System.Drawing.Color.Transparent;
            this.btnAssessManSystemExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssessManSystemExit.FlatAppearance.BorderSize = 0;
            this.btnAssessManSystemExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessManSystemExit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssessManSystemExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAssessManSystemExit.Location = new System.Drawing.Point(810, 1);
            this.btnAssessManSystemExit.Name = "btnAssessManSystemExit";
            this.btnAssessManSystemExit.Size = new System.Drawing.Size(40, 40);
            this.btnAssessManSystemExit.TabIndex = 47;
            this.btnAssessManSystemExit.Text = "X";
            this.btnAssessManSystemExit.UseVisualStyleBackColor = false;
            this.btnAssessManSystemExit.Click += new System.EventHandler(this.btnAssessManSystemExit_Click);
            // 
            // btnAddAssess
            // 
            this.btnAddAssess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddAssess.FlatAppearance.BorderSize = 0;
            this.btnAddAssess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAssess.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssess.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddAssess.Location = new System.Drawing.Point(718, 495);
            this.btnAddAssess.Name = "btnAddAssess";
            this.btnAddAssess.Size = new System.Drawing.Size(75, 23);
            this.btnAddAssess.TabIndex = 48;
            this.btnAddAssess.Text = "ADD";
            this.btnAddAssess.UseVisualStyleBackColor = false;
            this.btnAddAssess.Click += new System.EventHandler(this.btnAddAssess_Click);
            // 
            // btnRefreshTb
            // 
            this.btnRefreshTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRefreshTb.FlatAppearance.BorderSize = 0;
            this.btnRefreshTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTb.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRefreshTb.Location = new System.Drawing.Point(147, 495);
            this.btnRefreshTb.Name = "btnRefreshTb";
            this.btnRefreshTb.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshTb.TabIndex = 49;
            this.btnRefreshTb.Text = "REFRESH";
            this.btnRefreshTb.UseVisualStyleBackColor = false;
            this.btnRefreshTb.Click += new System.EventHandler(this.btnRefreshTb_Click);
            // 
            // btnAssExit
            // 
            this.btnAssExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAssExit.FlatAppearance.BorderSize = 0;
            this.btnAssExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAssExit.Location = new System.Drawing.Point(38, 495);
            this.btnAssExit.Name = "btnAssExit";
            this.btnAssExit.Size = new System.Drawing.Size(75, 23);
            this.btnAssExit.TabIndex = 50;
            this.btnAssExit.Text = "EXIT";
            this.btnAssExit.UseVisualStyleBackColor = false;
            this.btnAssExit.Click += new System.EventHandler(this.btnAssExit_Click);
            // 
            // LecturerAssess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btnAssExit);
            this.Controls.Add(this.btnRefreshTb);
            this.Controls.Add(this.btnAddAssess);
            this.Controls.Add(this.btnAssessManSystemExit);
            this.Controls.Add(this.btnAssessmentExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddAssessment);
            this.Controls.Add(this.dgvDisplayAssignment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAssessmentManSystemExit);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LecturerAssess";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.Lecturer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssessmentManSystemExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpAssignment;
        private System.Windows.Forms.ComboBox cmbLecturerModDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAssessmentStatus;
        private System.Windows.Forms.ComboBox cmbAssessmentType;
        private System.Windows.Forms.DataGridView dgvDisplayAssignment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAssessmentExit;
        private System.Windows.Forms.Button btnAssessManSystemExit;
        private System.Windows.Forms.Button btnAddAssess;
        private System.Windows.Forms.Button btnRefreshTb;
        private System.Windows.Forms.Button btnAssExit;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label4;
    }
}