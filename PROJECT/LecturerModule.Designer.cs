namespace PROJECT_ONT23
{
    partial class LecturerModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpLecturerMod = new System.Windows.Forms.DateTimePicker();
            this.cmbLectureName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLecturerModStatus = new System.Windows.Forms.ComboBox();
            this.cmbModuleName = new System.Windows.Forms.ComboBox();
            this.txtLecturerModuleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModulesManSystemExit = new System.Windows.Forms.Button();
            this.dgvDisplayLecturerModule = new System.Windows.Forms.DataGridView();
            this.btnLecturerModDelete = new System.Windows.Forms.Button();
            this.btnLecturerModUpdate = new System.Windows.Forms.Button();
            this.btnLecturerModRefresh = new System.Windows.Forms.Button();
            this.btnLecturerModExit = new System.Windows.Forms.Button();
            this.btnLecturerModAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLecturerModule)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpLecturerMod);
            this.panel1.Controls.Add(this.cmbLectureName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbLecturerModStatus);
            this.panel1.Controls.Add(this.cmbModuleName);
            this.panel1.Controls.Add(this.txtLecturerModuleID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 194);
            this.panel1.TabIndex = 14;
            // 
            // dtpLecturerMod
            // 
            this.dtpLecturerMod.Location = new System.Drawing.Point(176, 118);
            this.dtpLecturerMod.Name = "dtpLecturerMod";
            this.dtpLecturerMod.Size = new System.Drawing.Size(228, 21);
            this.dtpLecturerMod.TabIndex = 23;
            // 
            // cmbLectureName
            // 
            this.cmbLectureName.FormattingEnabled = true;
            this.cmbLectureName.Location = new System.Drawing.Point(176, 49);
            this.cmbLectureName.Name = "cmbLectureName";
            this.cmbLectureName.Size = new System.Drawing.Size(228, 24);
            this.cmbLectureName.TabIndex = 22;

            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(14, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "LECTURER NAME:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(14, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "MODULE NAME:";
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
            this.label7.Size = new System.Drawing.Size(159, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "LECTURER MODULE STATUS:";
            // 
            // cmbLecturerModStatus
            // 
            this.cmbLecturerModStatus.FormattingEnabled = true;
            this.cmbLecturerModStatus.Location = new System.Drawing.Point(176, 151);
            this.cmbLecturerModStatus.Name = "cmbLecturerModStatus";
            this.cmbLecturerModStatus.Size = new System.Drawing.Size(228, 24);
            this.cmbLecturerModStatus.TabIndex = 17;

            // 
            // cmbModuleName
            // 
            this.cmbModuleName.FormattingEnabled = true;
            this.cmbModuleName.Location = new System.Drawing.Point(176, 87);
            this.cmbModuleName.Name = "cmbModuleName";
            this.cmbModuleName.Size = new System.Drawing.Size(228, 24);
            this.cmbModuleName.TabIndex = 15;

            // 
            // txtLecturerModuleID
            // 
            this.txtLecturerModuleID.Enabled = false;
            this.txtLecturerModuleID.Location = new System.Drawing.Point(176, 14);
            this.txtLecturerModuleID.Name = "txtLecturerModuleID";
            this.txtLecturerModuleID.Size = new System.Drawing.Size(228, 21);
            this.txtLecturerModuleID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "LECTURER MODULE ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "LECTURER MODULES MANAGEMENT SYSTEM";
            // 
            // btnModulesManSystemExit
            // 
            this.btnModulesManSystemExit.BackColor = System.Drawing.Color.Transparent;
            this.btnModulesManSystemExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModulesManSystemExit.FlatAppearance.BorderSize = 0;
            this.btnModulesManSystemExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulesManSystemExit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulesManSystemExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModulesManSystemExit.Location = new System.Drawing.Point(812, -1);
            this.btnModulesManSystemExit.Name = "btnModulesManSystemExit";
            this.btnModulesManSystemExit.Size = new System.Drawing.Size(40, 40);
            this.btnModulesManSystemExit.TabIndex = 16;
            this.btnModulesManSystemExit.Text = "X";
            this.btnModulesManSystemExit.UseVisualStyleBackColor = false;
            this.btnModulesManSystemExit.Click += new System.EventHandler(this.btnModulesManSystemExit_Click);
            // 
            // dgvDisplayLecturerModule
            // 
            this.dgvDisplayLecturerModule.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDisplayLecturerModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayLecturerModule.Location = new System.Drawing.Point(12, 278);
            this.dgvDisplayLecturerModule.Name = "dgvDisplayLecturerModule";
            this.dgvDisplayLecturerModule.Size = new System.Drawing.Size(827, 213);
            this.dgvDisplayLecturerModule.TabIndex = 25;
            this.dgvDisplayLecturerModule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayLecturerModule_CellClick);
            // 
            // btnLecturerModDelete
            // 
            this.btnLecturerModDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLecturerModDelete.FlatAppearance.BorderSize = 0;
            this.btnLecturerModDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturerModDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturerModDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLecturerModDelete.Location = new System.Drawing.Point(763, 497);
            this.btnLecturerModDelete.Name = "btnLecturerModDelete";
            this.btnLecturerModDelete.Size = new System.Drawing.Size(75, 23);
            this.btnLecturerModDelete.TabIndex = 38;
            this.btnLecturerModDelete.Text = "DELETE";
            this.btnLecturerModDelete.UseVisualStyleBackColor = false;
            this.btnLecturerModDelete.Click += new System.EventHandler(this.btnLecturerModDelete_Click);
            // 
            // btnLecturerModUpdate
            // 
            this.btnLecturerModUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLecturerModUpdate.FlatAppearance.BorderSize = 0;
            this.btnLecturerModUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturerModUpdate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturerModUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLecturerModUpdate.Location = new System.Drawing.Point(666, 497);
            this.btnLecturerModUpdate.Name = "btnLecturerModUpdate";
            this.btnLecturerModUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnLecturerModUpdate.TabIndex = 39;
            this.btnLecturerModUpdate.Text = "UPDATE";
            this.btnLecturerModUpdate.UseVisualStyleBackColor = false;
            this.btnLecturerModUpdate.Click += new System.EventHandler(this.btnLecturerModUpdate_Click);
            // 
            // btnLecturerModRefresh
            // 
            this.btnLecturerModRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLecturerModRefresh.FlatAppearance.BorderSize = 0;
            this.btnLecturerModRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturerModRefresh.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturerModRefresh.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLecturerModRefresh.Location = new System.Drawing.Point(110, 497);
            this.btnLecturerModRefresh.Name = "btnLecturerModRefresh";
            this.btnLecturerModRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnLecturerModRefresh.TabIndex = 40;
            this.btnLecturerModRefresh.Text = "REFRESH";
            this.btnLecturerModRefresh.UseVisualStyleBackColor = false;
            this.btnLecturerModRefresh.Click += new System.EventHandler(this.btnLecturerModRefresh_Click);
            // 
            // btnLecturerModExit
            // 
            this.btnLecturerModExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLecturerModExit.FlatAppearance.BorderSize = 0;
            this.btnLecturerModExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturerModExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturerModExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLecturerModExit.Location = new System.Drawing.Point(12, 497);
            this.btnLecturerModExit.Name = "btnLecturerModExit";
            this.btnLecturerModExit.Size = new System.Drawing.Size(75, 23);
            this.btnLecturerModExit.TabIndex = 41;
            this.btnLecturerModExit.Text = "EXIT";
            this.btnLecturerModExit.UseVisualStyleBackColor = false;
            this.btnLecturerModExit.Click += new System.EventHandler(this.btnLecturerModExit_Click);
            // 
            // btnLecturerModAdd
            // 
            this.btnLecturerModAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLecturerModAdd.FlatAppearance.BorderSize = 0;
            this.btnLecturerModAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturerModAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturerModAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLecturerModAdd.Location = new System.Drawing.Point(565, 497);
            this.btnLecturerModAdd.Name = "btnLecturerModAdd";
            this.btnLecturerModAdd.Size = new System.Drawing.Size(75, 23);
            this.btnLecturerModAdd.TabIndex = 42;
            this.btnLecturerModAdd.Text = "ADD";
            this.btnLecturerModAdd.UseVisualStyleBackColor = false;
            this.btnLecturerModAdd.Click += new System.EventHandler(this.btnLecturerModAdd_Click);
            // 
            // LecturerModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btnLecturerModAdd);
            this.Controls.Add(this.btnLecturerModExit);
            this.Controls.Add(this.btnLecturerModRefresh);
            this.Controls.Add(this.btnLecturerModUpdate);
            this.Controls.Add(this.btnLecturerModDelete);
            this.Controls.Add(this.dgvDisplayLecturerModule);
            this.Controls.Add(this.btnModulesManSystemExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LecturerModule";
            this.Text = "LecturerModule";
            this.Load += new System.EventHandler(this.LecturerModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLecturerModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLecturerModStatus;
        private System.Windows.Forms.ComboBox cmbModuleName;
        private System.Windows.Forms.TextBox txtLecturerModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModulesManSystemExit;
        private System.Windows.Forms.ComboBox cmbLectureName;
        private System.Windows.Forms.DataGridView dgvDisplayLecturerModule;
        private System.Windows.Forms.Button btnLecturerModDelete;
        private System.Windows.Forms.Button btnLecturerModUpdate;
        private System.Windows.Forms.Button btnLecturerModRefresh;
        private System.Windows.Forms.Button btnLecturerModExit;
        private System.Windows.Forms.Button btnLecturerModAdd;
        private System.Windows.Forms.DateTimePicker dtpLecturerMod;
    }
}