namespace PROJECT_ONT23
{
    partial class Modules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modules));
            this.label2 = new System.Windows.Forms.Label();
            this.btnModulesManSystemExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModuleStatus = new System.Windows.Forms.ComboBox();
            this.cmbModuleDescription = new System.Windows.Forms.ComboBox();
            this.cmbModuleDuration = new System.Windows.Forms.ComboBox();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.txtModuleID = new System.Windows.Forms.TextBox();
            this.dgvDisplayModule = new System.Windows.Forms.DataGridView();
            this.btnModuleDelete = new System.Windows.Forms.Button();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.btnModuleRefresh = new System.Windows.Forms.Button();
            this.btnModManExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterByModName = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModule)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "MODULES MANAGEMENT SYSTEM";
            // 
            // btnModulesManSystemExit
            // 
            this.btnModulesManSystemExit.BackColor = System.Drawing.Color.Transparent;
            this.btnModulesManSystemExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModulesManSystemExit.FlatAppearance.BorderSize = 0;
            this.btnModulesManSystemExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulesManSystemExit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulesManSystemExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModulesManSystemExit.Location = new System.Drawing.Point(810, -1);
            this.btnModulesManSystemExit.Name = "btnModulesManSystemExit";
            this.btnModulesManSystemExit.Size = new System.Drawing.Size(40, 40);
            this.btnModulesManSystemExit.TabIndex = 7;
            this.btnModulesManSystemExit.Text = "X";
            this.btnModulesManSystemExit.UseVisualStyleBackColor = false;
            this.btnModulesManSystemExit.Click += new System.EventHandler(this.btnModulesManSystemExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "MODULE ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbModuleStatus);
            this.panel1.Controls.Add(this.cmbModuleDescription);
            this.panel1.Controls.Add(this.cmbModuleDuration);
            this.panel1.Controls.Add(this.txtModuleName);
            this.panel1.Controls.Add(this.txtModuleID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 194);
            this.panel1.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(14, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "MODULE NAME:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(14, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "MODULE DURATION:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(14, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "MODULE DESCRIPTION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(14, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "MODULE STATUS:";
            // 
            // cmbModuleStatus
            // 
            this.cmbModuleStatus.FormattingEnabled = true;
            this.cmbModuleStatus.Location = new System.Drawing.Point(155, 151);
            this.cmbModuleStatus.Name = "cmbModuleStatus";
            this.cmbModuleStatus.Size = new System.Drawing.Size(155, 24);
            this.cmbModuleStatus.TabIndex = 17;
            // 
            // cmbModuleDescription
            // 
            this.cmbModuleDescription.FormattingEnabled = true;
            this.cmbModuleDescription.Location = new System.Drawing.Point(155, 117);
            this.cmbModuleDescription.Name = "cmbModuleDescription";
            this.cmbModuleDescription.Size = new System.Drawing.Size(155, 24);
            this.cmbModuleDescription.TabIndex = 16;
            this.cmbModuleDescription.SelectedIndexChanged += new System.EventHandler(this.cmbModuleDescription_SelectedIndexChanged);
            // 
            // cmbModuleDuration
            // 
            this.cmbModuleDuration.FormattingEnabled = true;
            this.cmbModuleDuration.Location = new System.Drawing.Point(155, 87);
            this.cmbModuleDuration.Name = "cmbModuleDuration";
            this.cmbModuleDuration.Size = new System.Drawing.Size(155, 24);
            this.cmbModuleDuration.TabIndex = 15;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(155, 52);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(228, 21);
            this.txtModuleName.TabIndex = 14;
            // 
            // txtModuleID
            // 
            this.txtModuleID.Enabled = false;
            this.txtModuleID.Location = new System.Drawing.Point(155, 14);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(228, 21);
            this.txtModuleID.TabIndex = 13;
            // 
            // dgvDisplayModule
            // 
            this.dgvDisplayModule.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDisplayModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayModule.Location = new System.Drawing.Point(11, 315);
            this.dgvDisplayModule.Name = "dgvDisplayModule";
            this.dgvDisplayModule.Size = new System.Drawing.Size(827, 213);
            this.dgvDisplayModule.TabIndex = 24;
            this.dgvDisplayModule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayModule_CellClick);
            // 
            // btnModuleDelete
            // 
            this.btnModuleDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnModuleDelete.FlatAppearance.BorderSize = 0;
            this.btnModuleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuleDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModuleDelete.Location = new System.Drawing.Point(746, 534);
            this.btnModuleDelete.Name = "btnModuleDelete";
            this.btnModuleDelete.Size = new System.Drawing.Size(75, 23);
            this.btnModuleDelete.TabIndex = 34;
            this.btnModuleDelete.Text = "DELETE";
            this.btnModuleDelete.UseVisualStyleBackColor = false;
            this.btnModuleDelete.Click += new System.EventHandler(this.btnModuleDelete_Click);
            // 
            // btnAddModule
            // 
            this.btnAddModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddModule.FlatAppearance.BorderSize = 0;
            this.btnAddModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModule.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModule.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddModule.Location = new System.Drawing.Point(631, 534);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(75, 23);
            this.btnAddModule.TabIndex = 36;
            this.btnAddModule.Text = "ADD";
            this.btnAddModule.UseVisualStyleBackColor = false;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // btnModuleRefresh
            // 
            this.btnModuleRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnModuleRefresh.FlatAppearance.BorderSize = 0;
            this.btnModuleRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuleRefresh.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleRefresh.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModuleRefresh.Location = new System.Drawing.Point(130, 534);
            this.btnModuleRefresh.Name = "btnModuleRefresh";
            this.btnModuleRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnModuleRefresh.TabIndex = 37;
            this.btnModuleRefresh.Text = "REFRESH";
            this.btnModuleRefresh.UseVisualStyleBackColor = false;
            this.btnModuleRefresh.Click += new System.EventHandler(this.btnModuleRefresh_Click);
            // 
            // btnModManExit
            // 
            this.btnModManExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnModManExit.FlatAppearance.BorderSize = 0;
            this.btnModManExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModManExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModManExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModManExit.Location = new System.Drawing.Point(24, 534);
            this.btnModManExit.Name = "btnModManExit";
            this.btnModManExit.Size = new System.Drawing.Size(75, 23);
            this.btnModManExit.TabIndex = 38;
            this.btnModManExit.Text = "EXIT";
            this.btnModManExit.UseVisualStyleBackColor = false;
            this.btnModManExit.Click += new System.EventHandler(this.btnModManExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Filter By Module Name:";
            // 
            // cmbFilterByModName
            // 
            this.cmbFilterByModName.FormattingEnabled = true;
            this.cmbFilterByModName.Location = new System.Drawing.Point(173, 283);
            this.cmbFilterByModName.Name = "cmbFilterByModName";
            this.cmbFilterByModName.Size = new System.Drawing.Size(210, 24);
            this.cmbFilterByModName.TabIndex = 44;
            this.cmbFilterByModName.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByModName_SelectedIndexChanged);
            // 
            // Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 560);
            this.ControlBox = false;
            this.Controls.Add(this.cmbFilterByModName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModManExit);
            this.Controls.Add(this.btnModuleRefresh);
            this.Controls.Add(this.btnAddModule);
            this.Controls.Add(this.btnModuleDelete);
            this.Controls.Add(this.dgvDisplayModule);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModulesManSystemExit);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Modules";
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.Modules_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModulesManSystemExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbModuleStatus;
        private System.Windows.Forms.ComboBox cmbModuleDescription;
        private System.Windows.Forms.ComboBox cmbModuleDuration;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.TextBox txtModuleID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDisplayModule;
        private System.Windows.Forms.Button btnModuleDelete;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Button btnModuleRefresh;
        private System.Windows.Forms.Button btnModManExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterByModName;
    }
}