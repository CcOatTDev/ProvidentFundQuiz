using ProvidenceFundQuize.Hepler;
using ProvidenceFundQuize.Manager;
using ProvidenceFundQuize.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvidenceFundQuize
{
    public partial class frmCalculatorPerYear : Form
    {
        #region Member , Properties
        #endregion

        #region Constructor
        public frmCalculatorPerYear()
        {
            InitializeComponent();

            this.Load += FrmCalculator_Load;
        }
        #endregion

        #region Methods 
        private void ActivateEvents()
        {
            dtpStartWorkDate.ValueChanged += DtpStartWorkDate_ValueChanged;
            btnCalculate.Click += BtnCalculate_Click;
            txtSalary.KeyUp += TxtSalary_KeyUp;
            txtSalary.KeyPress += TxtSalary_KeyPress;
            btnSave.Click += BtnSave_Click;
            gridViewDisplay.CellValueChanged += GridViewDisplay_CellValueChanged;
            btnViewLog.Click += BtnViewLog_Click;
        }

        private void LoadDefaultData()
        {
            SetValueDateOfBirth();
        }

        private void CalulateOnGird()
        {
            if (gridViewDisplay.DataSource == null)
                return;

            List<EmployeeLogDetail> providentFunds = gridViewDisplay.DataSource as List<EmployeeLogDetail>;

            foreach (EmployeeLogDetail provident in providentFunds)
            {
                decimal providentFundCalculator = ProvidentFundCalculator.GetCalulateProvidentFund(provident.Month, provident.CompanyPaidPercent, provident.Salary, provident.PVDRate);
                provident.ProvidentFundCollect = providentFundCalculator;
            }

            lbTatalPVD.Text = providentFunds.Sum(a => a.ProvidentFundCollect).ToString("N2");
        }

        private void SetDatasourceGridView()
        {
            DateTime startDate = dtpStartWorkDate.Value.Date;
            DateTime endDate = DateTime.Now.Date;

            //Dictionary<Int32, decimal> monthAndYear = ProvidentFundCalculator.GetMonthAndYearPVDPaid(startDate, endDate);

            decimal month = ProvidentFundCalculator.GetMonthPVDPaid(startDate, endDate);
            decimal monthCal = ProvidentFundCalculator.GetMonthPVDPaid(startDate, endDate);
            monthCal -= 3;
            decimal yearWork = ProvidentFundCalculator.GetWorkYear(startDate, endDate);
            if (yearWork == 0)
                return;

            List<EmployeeLogDetail> providentFunds = new List<EmployeeLogDetail>();
            for (int row = 0; row <= yearWork; row++)
            {
                EmployeeLogDetail providentFund = new EmployeeLogDetail();

                if (row == 0)
                    providentFund.Month = month - 11 >= 0 ? 11 : month;
                else if (month - 12 >= 0)
                    providentFund.Month = 12;
                else
                    providentFund.Month = month;

                month -= providentFund.Month;

                providentFund.WorkYear = row == 0 ? "1-11 M" : row + "+";
                providentFund.ProvidentFundCollect = 0;
                providentFund.Salary = Convert.ToDecimal(txtSalary.Text);

                DateTime newEndDate = endDate.AddMonths(-Convert.ToInt32(monthCal));
                providentFund.CompanyPaidPercent = ProvidentFundCalculator.GetCompanyPaidPercent(startDate, newEndDate);
                monthCal -= providentFund.Month;

                ConditionsDatetime conditionsDatetime = new ConditionsDatetime(startDate);

                providentFunds.Add(providentFund);
            }

            gridViewDisplay.DataSource = providentFunds;

            SetComBoboxOnGird(startDate, endDate, providentFunds);
        }

        private void SetComBoboxOnGird(DateTime startDate, DateTime endDate, List<EmployeeLogDetail> providentFunds)
        {
            int index = 0;
            decimal month = ProvidentFundCalculator.GetMonthPVDPaid(startDate, endDate);
            month -= 3;
            foreach (EmployeeLogDetail data in providentFunds)
            {
                DateTime newEndDate = endDate.AddMonths(-Convert.ToInt32(month));
                month -= data.Month;
                decimal rate = ProvidentFundCalculator.GetProvidentFundNotOverRatePercent(startDate, newEndDate);
                List<ComboBoxHelper.ComboBoxSource<decimal>> comboBoxSource = new List<ComboBoxHelper.ComboBoxSource<decimal>>();
                for (int loop = 1; loop <= rate; loop++)
                {
                    comboBoxSource.Add(new ComboBoxHelper.ComboBoxSource<decimal>
                    {
                        Display = loop.ToString(),
                        Value = loop,
                    });
                }

                if (rate == 0)
                {
                    comboBoxSource.Add(new ComboBoxHelper.ComboBoxSource<decimal>
                    {
                        Display = rate.ToString(),
                        Value = rate,
                    });
                }

                DataGridViewComboBoxCell cellCombobox = new DataGridViewComboBoxCell();
                cellCombobox.DisplayMember = nameof(ComboBoxHelper.ComboBoxSource<decimal>.Display);
                cellCombobox.ValueMember = nameof(ComboBoxHelper.ComboBoxSource<decimal>.Value);
                cellCombobox.DataSource = comboBoxSource;

                gridViewDisplay.Rows[index].Cells["cboPVDRate"] = cellCombobox;

                ++index;
            }

            gridViewDisplay.Refresh();
        }

        private void SetValueDateOfBirth()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now;
        }

        private bool IsValidate()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                MessageBox.Show("Press Firstname !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                MessageBox.Show("Press LastName !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #endregion

        #region Events
        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            ActivateEvents();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalulateOnGird();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CalulateOnGird();

            if (!IsValidate())
                return;

            EmployeeLog employee = PrepareData();

            if (!EmployeeManager.IsSaveLogEmployee(employee))
            {
                MessageBox.Show("Fail !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Success !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearData();
        }

        private void ClearData()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Now.Date;
            dtpStartWorkDate.Value = DateTime.Now.Date;
            txtSalary.Text = "0";
            lbTatalPVD.Text = "0.00";

            gridViewDisplay.DataSource = new List<EmployeeLogDetail>();
        }

        private EmployeeLog PrepareData()
        {
            return new EmployeeLog
            {
                Firstname = txtFirstName.Text,
                Lastname = txtLastName.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                StartWorkDate = dtpStartWorkDate.Value,
                ProvidentFundRate = ComboBoxHelper.GetSelectedValueFromComboBox<decimal>(cboProvidentFundRate),
                Salary = Convert.ToDecimal(txtSalary.Text),
                ProvidentFundCollectAmount = Convert.ToDecimal(lbTatalPVD.Text),
                employeeLogDetails = PrepareDataFromGridView()
            };
        }

        private List<EmployeeLogDetail> PrepareDataFromGridView()
        {
            if (gridViewDisplay.DataSource == null)
                return new List<EmployeeLogDetail>();

            return gridViewDisplay.DataSource as List<EmployeeLogDetail>;
        }

        private void DtpStartWorkDate_ValueChanged(object sender, EventArgs e)
        {
            SetDatasourceGridView();
        }

        private void TxtSalary_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalary.Text))
                return;

            e.SuppressKeyPress = !char.IsNumber((char)e.KeyCode);

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            int valueBefore = Int32.Parse(txtSalary.Text, System.Globalization.NumberStyles.AllowThousands);
            txtSalary.Text = String.Format(culture, "{0:N0}", valueBefore);
            txtSalary.Select(txtSalary.Text.Length, 0);
        }

        private void TxtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (gridViewDisplay.DataSource == null)
                return;

            foreach (DataGridViewRow row in gridViewDisplay.Rows)
            {
                row.Cells[nameof(EmployeeLogDetail.Salary)].Value = Convert.ToDecimal(txtSalary.Text);
            }

        }

        private void GridViewDisplay_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            decimal rate = Convert.ToDecimal(gridViewDisplay["cboPVDRate", e.RowIndex].Value);
            gridViewDisplay.Rows[e.RowIndex].Cells[nameof(EmployeeLogDetail.PVDRate)].Value = rate;

            decimal month = Convert.ToDecimal(gridViewDisplay[nameof(EmployeeLogDetail.Month), e.RowIndex].Value);
            decimal salary = Convert.ToDecimal(gridViewDisplay[nameof(EmployeeLogDetail.Salary), e.RowIndex].Value);
            decimal companyPaidPercent = Convert.ToDecimal(gridViewDisplay[nameof(EmployeeLogDetail.CompanyPaidPercent), e.RowIndex].Value);
            decimal providentFundCollect = ProvidentFundCalculator.GetCalulateProvidentFund(month, companyPaidPercent, salary, rate);

            gridViewDisplay.Rows[e.RowIndex].Cells[nameof(EmployeeLogDetail.ProvidentFundCollect)].Value = providentFundCollect;
        }

        private void BtnViewLog_Click(object sender, EventArgs e)
        {
            frmViewLog frm = new frmViewLog();
            frm.Owner = this;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
        }

        #endregion
    }
}
