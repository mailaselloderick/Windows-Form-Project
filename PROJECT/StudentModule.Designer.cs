namespace PROJECT_ONT23
{
    partial class StudentModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpStudentMod = new System.Windows.Forms.DateTimePicker();
            this.cmbLecturerModDetails = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStudentModuleStatus = new System.Windows.Forms.ComboBox();
            this.cmbStudentDetails = new System.Windows.Forms.ComboBox();
            this.txtStudentModuleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStudentModulesManSystemExit = new System.Windows.Forms.Button();
            this.dgvDisplayStudentModule = new System.Windows.Forms.DataGridView();
            this.btnStudentModAdd = new System.Windows.Forms.Button();
            this.btnStudentModUpdate = new System.Windows.Forms.Button();
            this.btnStudentModDelete = new System.Windows.Forms.Button();
            this.btnStudentModRefresh = new System.Windows.Forms.Button();
            this.btnStudentModExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudentModule)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpStudentMod);
            this.panel1.Controls.Add(this.cmbLecturerModDetails);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbStudentModuleStatus);
            this.panel1.Controls.Add(this.cmbStudentDetails);
            this.panel1.Controls.Add(this.txtStudentModuleID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 194);
            this.panel1.TabIndex = 14;
            // 
            // dtpStudentMod
            // 
            this.dtpStudentMod.Location = new System.Drawing.Point(174, 124);
            this.dtpStudentMod.Name = "dtpStudentMod";
            this.dtpStudentMod.Size = new System.Drawing.Size(229, 21);
            this.dtpStudentMod.TabIndex = 23;
            // 
            // cmbLecturerModDetails
            // 
            this.cmbLecturerModDetails.FormattingEnabled = true;
            this.cmbLecturerModDetails.Location = new System.Drawing.Point(174, 55);
            this.cmbLecturerModDetails.Name = "cmbLecturerModDetails";
            this.cmbLecturerModDetails.Size = new System.Drawing.Size(229, 24);
            this.cmbLecturerModDetails.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(14, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "LECTURER MODULE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(14, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "STUDENT NAME:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(14, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "DATE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(14, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "STUDENT MODULE STATUS:";
            // 
            // cmbStudentModuleStatus
            // 
            this.cmbStudentModuleStatus.FormattingEnabled = true;
            this.cmbStudentModuleStatus.Location = new System.Drawing.Point(174, 151);
            this.cmbStudentModuleStatus.Name = "cmbStudentModuleStatus";
            this.cmbStudentModuleStatus.Size = new System.Drawing.Size(229, 24);
            this.cmbStudentModuleStatus.TabIndex = 17;
            // 
            // cmbStudentDetails
            // 
            this.cmbStudentDetails.FormattingEnabled = true;
            this.cmbStudentDetails.Location = new System.Drawing.Point(174, 87);
            this.cmbStudentDetails.Name = "cmbStudentDetails";
            this.cmbStudentDetails.Size = new System.Drawing.Size(229, 24);
            this.cmbStudentDetails.TabIndex = 15;
            // 
            // txtStudentModuleID
            // 
            this.txtStudentModuleID.Enabled = false;
            this.txtStudentModuleID.Location = new System.Drawing.Point(174, 19);
            this.txtStudentModuleID.Name = "txtStudentModuleID";
            this.txtStudentModuleID.Size = new System.Drawing.Size(229, 21);
            this.txtStudentModuleID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "STUDENT MODULE ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "STUDENT MODULES MANAGEMENT SYSTEM";
            // 
            // btnStudentModulesManSystemExit
            // 
            this.btnStudentModulesManSystemExit.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentModulesManSystemExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentModulesManSystemExit.FlatAppearance.BorderSize = 0;
            this.btnStudentModulesManSystemExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentModulesManSystemExit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentModulesManSystemExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStudentModulesManSystemExit.Location = new System.Drawing.Point(813, -1);
            this.btnStudentModulesManSystemExit.Name = "btnStudentModulesManSystemExit";
            this.btnStudentModulesManSystemExit.Size = new System.Drawing.Size(40, 40);
            this.btnStudentModulesManSystemExit.TabIndex = 16;
            this.btnStudentModulesManSystemExit.Text = "X";
            this.btnStudentModulesManSystemExit.UseVisualStyleBackColor = false;
            this.btnStudentModulesManSystemExit.Click += new System.EventHandler(this.btnStudentModulesManSystemExit_Click);
            // 
            // dgvDisplayStudentModule
            // 
            this.dgvDisplayStudentModule.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDisplayStudentModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayStudentModule.Location = new System.Drawing.Point(12, 273);
            this.dgvDisplayStudentModule.Name = "dgvDisplayStudentModule";
            this.dgvDisplayStudentModule.Size = new System.Drawing.Size(827, 213);
            this.dgvDisplayStudentModule.TabIndex = 26;
            this.dgvDisplayStudentModule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayStudentModule_CellClick);
            // 
            // btnStudentModAdd
            // 
            this.btnStudentModAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStudentModAdd.FlatAppearance.BorderSize = 0;
            this.btnStudentModAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentModAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentModAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStudentModAdd.Location = new System.Drawing.Point(571, 495);
            this.btnStudentModAdd.Name = "btnStudentModAdd";
            this.btnStudentModAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentModAdd.TabIndex = 38;
            this.btnStudentModAdd.Text = "ADD";
            this.btnStudentModAdd.UseVisualStyleBackColor = false;
            this.btnStudentModAdd.Click += new System.EventHandler(this.btnStudentModAdd_Click);
            // 
            // btnStudentModUpdate
            // 
            this.btnStudentModUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStudentModUpdate.FlatAppearance.BorderSize = 0;
            this.btnStudentModUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentModUpdate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentModUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStudentModUpdate.Location = new System.Drawing.Point(670, 495);
            this.btnStudentModUpdate.Name = "btnStudentModUpdate";
            this.btnStudentModUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnStudentModUpdate.TabIndex = 39;
            this.btnStudentModUpdate.Text = "UPDATE";
            this.btnStudentModUpdate.UseVisualStyleBackColor = false;
            // 
            // btnStudentModDelete
            // 
            this.btnStudentModDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStudentModDelete.FlatAppearance.BorderSize = 0;
            this.btnStudentModDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentModDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentModDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStudentModDelete.Location = new System.Drawing.Point(763, 495);
            this.btnStudentModDelete.Name = "btnStudentModDelete";
            this.btnStudentModDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStudentModDelete.TabIndex = 40;
            this.btnStudentModDelete.Text = "DELETE";
            this.btnStudentModDelete.UseVisualStyleBackColor = false;
            // 
            // btnStudentModRefresh
            // 
            this.btnStudentModRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStudentModRefresh.FlatAppearance.BorderSize = 0;
            this.btnStudentModRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentModRefresh.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentModRefresh.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStudentModRefresh.Location = new System.Drawing.Point(125, 495);
            this.btnStudentModRefresh.Name = "btnStudentModRefresh";
            this.btnStudentModRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnStudentModRefresh.TabIndex = 41;
            this.btnStudentModRefresh.Text = "REFRESH";
            this.btnStudentModRefresh.UseVisualStyleBackColor = false;
            this.btnStudentModRefresh.Click += new System.EventHandler(this.btnStudentModRefresh_Click);
            // 
            // btnStudentModExit
            // 
            this.btnStudentModExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStudentModExit.FlatAppearance.BorderSize = 0;
            this.btnStudentModExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentModExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentModExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStudentModExit.Location = new System.Drawing.Point(12, 495);
            this.btnStudentModExit.Name = "btnStudentModExit";
            this.btnStudentModExit.Size = new System.Drawing.Size(75, 23);
            this.btnStudentModExit.TabIndex = 42;
            this.btnStudentModExit.Text = "EXIT";
            this.btnStudentModExit.UseVisualStyleBackColor = false;
            this.btnStudentModExit.Click += new System.EventHandler(this.btnLecturerModExit_Click);
            // 
            // StudentModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btnStudentModExit);
            this.Controls.Add(this.btnStudentModRefresh);
            this.Controls.Add(this.btnStudentModDelete);
            this.Controls.Add(this.btnStudentModUpdate);
            this.Controls.Add(this.btnStudentModAdd);
            this.Controls.Add(this.dgvDisplayStudentModule);
            this.Controls.Add(this.btnStudentModulesManSystemExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentModule";
            this.Text = "StudentModule";
            this.Load += new System.EventHandler(this.StudentModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudentModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStudentModuleStatus;
        private System.Windows.Forms.ComboBox cmbStudentDetails;
        private System.Windows.Forms.TextBox txtStudentModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStudentModulesManSystemExit;
        private System.Windows.Forms.DateTimePicker dtpStudentMod;
        private System.Windows.Forms.ComboBox cmbLecturerModDetails;
        private System.Windows.Forms.DataGridView dgvDisplayStudentModule;
        private System.Windows.Forms.Button btnStudentModAdd;
        private System.Windows.Forms.Button btnStudentModUpdate;
        private System.Windows.Forms.Button btnStudentModDelete;
        private System.Windows.Forms.Button btnStudentModRefresh;
        private System.Windows.Forms.Button btnStudentModExit;
    }
}