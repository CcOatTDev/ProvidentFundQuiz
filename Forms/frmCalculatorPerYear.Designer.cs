namespace ProvidenceFundQuize
{
    partial class frmCalculatorPerYear
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewDisplay = new System.Windows.Forms.DataGridView();
            this.WorkYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVDRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboPVDRate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CompanyPaidPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvidentFundCollect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLogDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dtpStartWorkDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProvidentFundRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTatalPVD = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnViewLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewDisplay
            // 
            this.gridViewDisplay.AllowUserToAddRows = false;
            this.gridViewDisplay.AllowUserToDeleteRows = false;
            this.gridViewDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkYear,
            this.Month,
            this.Salary,
            this.PVDRate,
            this.cboPVDRate,
            this.CompanyPaidPercent,
            this.ProvidentFundCollect,
            this.EmployeeLogID,
            this.EmployeeLogDetailID});
            this.gridViewDisplay.Location = new System.Drawing.Point(378, 32);
            this.gridViewDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewDisplay.Name = "gridViewDisplay";
            this.gridViewDisplay.Size = new System.Drawing.Size(697, 437);
            this.gridViewDisplay.TabIndex = 7;
            // 
            // WorkYear
            // 
            this.WorkYear.DataPropertyName = "WorkYear";
            this.WorkYear.HeaderText = "WorkYear";
            this.WorkYear.Name = "WorkYear";
            this.WorkYear.ReadOnly = true;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.Salary.DefaultCellStyle = dataGridViewCellStyle1;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            // 
            // PVDRate
            // 
            this.PVDRate.DataPropertyName = "PVDRate";
            this.PVDRate.HeaderText = "PVDRateVale";
            this.PVDRate.Name = "PVDRate";
            this.PVDRate.ReadOnly = true;
            this.PVDRate.Visible = false;
            // 
            // cboPVDRate
            // 
            this.cboPVDRate.HeaderText = "PVD Rate";
            this.cboPVDRate.MaxDropDownItems = 10;
            this.cboPVDRate.Name = "cboPVDRate";
            this.cboPVDRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cboPVDRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CompanyPaidPercent
            // 
            this.CompanyPaidPercent.DataPropertyName = "CompanyPaidPercent";
            this.CompanyPaidPercent.HeaderText = "CompanyPaidPercent";
            this.CompanyPaidPercent.Name = "CompanyPaidPercent";
            this.CompanyPaidPercent.ReadOnly = true;
            // 
            // ProvidentFundCollect
            // 
            this.ProvidentFundCollect.DataPropertyName = "ProvidentFundCollect";
            dataGridViewCellStyle2.Format = "N2";
            this.ProvidentFundCollect.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProvidentFundCollect.HeaderText = "ProvidentFundCollect";
            this.ProvidentFundCollect.Name = "ProvidentFundCollect";
            this.ProvidentFundCollect.ReadOnly = true;
            this.ProvidentFundCollect.Width = 150;
            // 
            // EmployeeLogID
            // 
            this.EmployeeLogID.DataPropertyName = "EmployeeLogID";
            this.EmployeeLogID.HeaderText = "EmployeeLogID";
            this.EmployeeLogID.Name = "EmployeeLogID";
            this.EmployeeLogID.ReadOnly = true;
            this.EmployeeLogID.Visible = false;
            // 
            // EmployeeLogDetailID
            // 
            this.EmployeeLogDetailID.DataPropertyName = "EmployeeLogDetailID";
            this.EmployeeLogDetailID.HeaderText = "EmployeeLogDetailID";
            this.EmployeeLogDetailID.Name = "EmployeeLogDetailID";
            this.EmployeeLogDetailID.ReadOnly = true;
            this.EmployeeLogDetailID.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(151, 81);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(185, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(151, 127);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(151, 268);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(132, 23);
            this.txtSalary.TabIndex = 5;
            this.txtSalary.Text = "0";
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(151, 173);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(154, 23);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // dtpStartWorkDate
            // 
            this.dtpStartWorkDate.Location = new System.Drawing.Point(151, 219);
            this.dtpStartWorkDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartWorkDate.Name = "dtpStartWorkDate";
            this.dtpStartWorkDate.Size = new System.Drawing.Size(154, 23);
            this.dtpStartWorkDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start work date";
            // 
            // cboProvidentFundRate
            // 
            this.cboProvidentFundRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvidentFundRate.FormattingEnabled = true;
            this.cboProvidentFundRate.Location = new System.Drawing.Point(151, 320);
            this.cboProvidentFundRate.Name = "cboProvidentFundRate";
            this.cboProvidentFundRate.Size = new System.Drawing.Size(132, 24);
            this.cboProvidentFundRate.TabIndex = 6;
            this.cboProvidentFundRate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Salary";
            // 
            // lbTatalPVD
            // 
            this.lbTatalPVD.AutoSize = true;
            this.lbTatalPVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTatalPVD.ForeColor = System.Drawing.Color.Green;
            this.lbTatalPVD.Location = new System.Drawing.Point(154, 414);
            this.lbTatalPVD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTatalPVD.Name = "lbTatalPVD";
            this.lbTatalPVD.Size = new System.Drawing.Size(23, 25);
            this.lbTatalPVD.TabIndex = 3;
            this.lbTatalPVD.Text = "0";
            this.lbTatalPVD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(378, 490);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(134, 40);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Provident fund rate";
            this.label6.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(931, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(63, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Collect :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(20, 12);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(134, 40);
            this.btnViewLog.TabIndex = 10;
            this.btnViewLog.Text = "View Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            // 
            // frmCalculatorPerYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 554);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cboProvidentFundRate);
            this.Controls.Add(this.lbTatalPVD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartWorkDate);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.gridViewDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalculatorPerYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProvidentFundCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpStartWorkDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProvidentFundRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTatalPVD;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridViewDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVDRate;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboPVDRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyPaidPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvidentFundCollect;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLogDetailID;
        private System.Windows.Forms.Button btnViewLog;
    }
}

