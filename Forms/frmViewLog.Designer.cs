namespace ProvidenceFundQuize
{
    partial class frmViewLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewDisplay = new System.Windows.Forms.DataGridView();
            this.gridViewDetail = new System.Windows.Forms.DataGridView();
            this.WorkYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVDRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboPVDRate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CompanyPaidPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvidentFundCollect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLogDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLogIDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartWorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salarys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvidentFundRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvidentFundCollectAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewDisplay
            // 
            this.gridViewDisplay.AllowUserToAddRows = false;
            this.gridViewDisplay.AllowUserToDeleteRows = false;
            this.gridViewDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeLogIDs,
            this.Firstname,
            this.Lastname,
            this.DateOfBirth,
            this.StartWorkDate,
            this.Salarys,
            this.ProvidentFundRate,
            this.ProvidentFundCollectAmount});
            this.gridViewDisplay.Location = new System.Drawing.Point(6, 24);
            this.gridViewDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewDisplay.Name = "gridViewDisplay";
            this.gridViewDisplay.Size = new System.Drawing.Size(646, 517);
            this.gridViewDisplay.TabIndex = 1;
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.AllowUserToAddRows = false;
            this.gridViewDetail.AllowUserToDeleteRows = false;
            this.gridViewDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkYear,
            this.Month,
            this.Salary,
            this.PVDRate,
            this.cboPVDRate,
            this.CompanyPaidPercent,
            this.ProvidentFundCollect,
            this.EmployeeLogID,
            this.EmployeeLogDetailID});
            this.gridViewDetail.Location = new System.Drawing.Point(668, 24);
            this.gridViewDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.Size = new System.Drawing.Size(698, 517);
            this.gridViewDetail.TabIndex = 2;
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
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Salary.DefaultCellStyle = dataGridViewCellStyle3;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // PVDRate
            // 
            this.PVDRate.DataPropertyName = "PVDRate";
            this.PVDRate.HeaderText = "PVDRate";
            this.PVDRate.Name = "PVDRate";
            this.PVDRate.ReadOnly = true;
            // 
            // cboPVDRate
            // 
            this.cboPVDRate.HeaderText = "PVD Rate";
            this.cboPVDRate.MaxDropDownItems = 10;
            this.cboPVDRate.Name = "cboPVDRate";
            this.cboPVDRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cboPVDRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cboPVDRate.Visible = false;
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
            dataGridViewCellStyle4.Format = "N2";
            this.ProvidentFundCollect.DefaultCellStyle = dataGridViewCellStyle4;
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
            // EmployeeLogIDs
            // 
            this.EmployeeLogIDs.DataPropertyName = "EmployeeLogID";
            this.EmployeeLogIDs.HeaderText = "EmployeeLogID";
            this.EmployeeLogIDs.Name = "EmployeeLogIDs";
            this.EmployeeLogIDs.ReadOnly = true;
            this.EmployeeLogIDs.Visible = false;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // StartWorkDate
            // 
            this.StartWorkDate.DataPropertyName = "StartWorkDate";
            this.StartWorkDate.HeaderText = "StartWorkDate";
            this.StartWorkDate.Name = "StartWorkDate";
            this.StartWorkDate.ReadOnly = true;
            // 
            // Salarys
            // 
            this.Salarys.DataPropertyName = "Salary";
            dataGridViewCellStyle1.Format = "N2";
            this.Salarys.DefaultCellStyle = dataGridViewCellStyle1;
            this.Salarys.HeaderText = "Salary";
            this.Salarys.Name = "Salarys";
            this.Salarys.ReadOnly = true;
            // 
            // ProvidentFundRate
            // 
            this.ProvidentFundRate.DataPropertyName = "ProvidentFundRate";
            this.ProvidentFundRate.HeaderText = "ProvidentFundRate";
            this.ProvidentFundRate.Name = "ProvidentFundRate";
            this.ProvidentFundRate.ReadOnly = true;
            this.ProvidentFundRate.Visible = false;
            // 
            // ProvidentFundCollectAmount
            // 
            this.ProvidentFundCollectAmount.DataPropertyName = "ProvidentFundCollectAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.ProvidentFundCollectAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProvidentFundCollectAmount.HeaderText = "ProvidentFundCollectAmount";
            this.ProvidentFundCollectAmount.Name = "ProvidentFundCollectAmount";
            this.ProvidentFundCollectAmount.ReadOnly = true;
            // 
            // frmViewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 554);
            this.Controls.Add(this.gridViewDetail);
            this.Controls.Add(this.gridViewDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIewLog";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewDisplay;
        private System.Windows.Forms.DataGridView gridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVDRate;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboPVDRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyPaidPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvidentFundCollect;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLogDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLogIDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartWorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salarys;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvidentFundRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvidentFundCollectAmount;
    }
}