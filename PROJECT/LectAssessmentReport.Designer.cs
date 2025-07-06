namespace PROJECT_ONT23
{
    partial class LectAssessmentReport
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
            this.btnSystemExit = new System.Windows.Forms.Button();
            this.btnRefreshTb = new System.Windows.Forms.Button();
            this.dgvDisplayAssignment = new System.Windows.Forms.DataGridView();
            this.btnAssExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFilterByAssessmentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilterByAssessmentStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFilterByDueDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLecName = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSystemExit
            // 
            this.btnSystemExit.BackColor = System.Drawing.Color.Transparent;
            this.btnSystemExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystemExit.FlatAppearance.BorderSize = 0;
            this.btnSystemExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemExit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSystemExit.Location = new System.Drawing.Point(895, -1);
            this.btnSystemExit.Name = "btnSystemExit";
            this.btnSystemExit.Size = new System.Drawing.Size(40, 40);
            this.btnSystemExit.TabIndex = 2;
            this.btnSystemExit.Text = "X";
            this.btnSystemExit.UseVisualStyleBackColor = false;
            this.btnSystemExit.Click += new System.EventHandler(this.btnSystemExit_Click_1);
            // 
            // btnRefreshTb
            // 
            this.btnRefreshTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRefreshTb.FlatAppearance.BorderSize = 0;
            this.btnRefreshTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTb.ForeColor = System.Drawing.Color.White;
            this.btnRefreshTb.Location = new System.Drawing.Point(802, 495);
            this.btnRefreshTb.Name = "btnRefreshTb";
            this.btnRefreshTb.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshTb.TabIndex = 50;
            this.btnRefreshTb.Text = "REFRESH";
            this.btnRefreshTb.UseVisualStyleBackColor = false;
            this.btnRefreshTb.Click += new System.EventHandler(this.btnRefreshTb_Click);
            // 
            // dgvDisplayAssignment
            // 
            this.dgvDisplayAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssignment.Location = new System.Drawing.Point(48, 170);
            this.dgvDisplayAssignment.Name = "dgvDisplayAssignment";
            this.dgvDisplayAssignment.Size = new System.Drawing.Size(853, 266);
            this.dgvDisplayAssignment.TabIndex = 51;
            // 
            // btnAssExit
            // 
            this.btnAssExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAssExit.FlatAppearance.BorderSize = 0;
            this.btnAssExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssExit.ForeColor = System.Drawing.Color.White;
            this.btnAssExit.Location = new System.Drawing.Point(96, 495);
            this.btnAssExit.Name = "btnAssExit";
            this.btnAssExit.Size = new System.Drawing.Size(75, 23);
            this.btnAssExit.TabIndex = 52;
            this.btnAssExit.Text = "EXIT";
            this.btnAssExit.UseVisualStyleBackColor = false;
            this.btnAssExit.Click += new System.EventHandler(this.btnAssExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "ASSESSMENTS REPORT MANAGEMENT SYSTEM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(463, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "Assessment Type:";
            // 
            // cmbFilterByAssessmentType
            // 
            this.cmbFilterByAssessmentType.FormattingEnabled = true;
            this.cmbFilterByAssessmentType.Location = new System.Drawing.Point(479, 125);
            this.cmbFilterByAssessmentType.Name = "cmbFilterByAssessmentType";
            this.cmbFilterByAssessmentType.Size = new System.Drawing.Size(156, 24);
            this.cmbFilterByAssessmentType.TabIndex = 55;
            this.cmbFilterByAssessmentType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByAssessmentType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Assessment Status:";
            // 
            // cmbFilterByAssessmentStatus
            // 
            this.cmbFilterByAssessmentStatus.FormattingEnabled = true;
            this.cmbFilterByAssessmentStatus.Location = new System.Drawing.Point(224, 125);
            this.cmbFilterByAssessmentStatus.Name = "cmbFilterByAssessmentStatus";
            this.cmbFilterByAssessmentStatus.Size = new System.Drawing.Size(152, 24);
            this.cmbFilterByAssessmentStatus.TabIndex = 57;
            this.cmbFilterByAssessmentStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByAssessmentStatus_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(699, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "DueDate:";
            // 
            // dtpFilterByDueDate
            // 
            this.dtpFilterByDueDate.Location = new System.Drawing.Point(702, 128);
            this.dtpFilterByDueDate.Name = "dtpFilterByDueDate";
            this.dtpFilterByDueDate.Size = new System.Drawing.Size(219, 21);
            this.dtpFilterByDueDate.TabIndex = 59;
            this.dtpFilterByDueDate.ValueChanged += new System.EventHandler(this.dtpFilterByDueDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Student Name:";
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(27, 128);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(144, 21);
            this.txtStudName.TabIndex = 65;
            this.txtStudName.TextChanged += new System.EventHandler(this.txtStudName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Lecturer Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "Module Name:";
            // 
            // lblLecName
            // 
            this.lblLecName.AutoSize = true;
            this.lblLecName.Location = new System.Drawing.Point(136, 45);
            this.lblLecName.Name = "lblLecName";
            this.lblLecName.Size = new System.Drawing.Size(40, 16);
            this.lblLecName.TabIndex = 68;
            this.lblLecName.Text = "label7";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(136, 70);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(40, 16);
            this.lblModName.TabIndex = 69;
            this.lblModName.Text = "label8";
            // 
            // LectAssessmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 530);
            this.ControlBox = false;
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.lblLecName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFilterByDueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFilterByAssessmentStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilterByAssessmentType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAssExit);
            this.Controls.Add(this.dgvDisplayAssignment);
            this.Controls.Add(this.btnRefreshTb);
            this.Controls.Add(this.btnSystemExit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LectAssessmentReport";
            this.Text = "LectAssessmentReport";
            this.Load += new System.EventHandler(this.LectAssessmentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSystemExit;
        private System.Windows.Forms.Button btnRefreshTb;
        private System.Windows.Forms.DataGridView dgvDisplayAssignment;
        private System.Windows.Forms.Button btnAssExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFilterByAssessmentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilterByAssessmentStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFilterByDueDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLecName;
        private System.Windows.Forms.Label lblModName;
    }
}