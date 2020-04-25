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
    public partial class frmCalculator : Form
    {
        #region Member , Properties
        #endregion

        #region Constructor
        public frmCalculator()
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
        }

        private void LoadDefaultData()
        {
            SetValueDateOfBirth();
            SetDatasourceCombobox();
            LoadDatasourceToGridDisplay();
        }

        private void LoadDatasourceToGridDisplay()
        {
            List<EmployeeLog> employees = EmployeeManager.LoadDataEmployeeLog();

            gridViewDisplay.DataSource = employees;
            gridViewDisplay.Refresh();
        }

        private void SetDatasourceCombobox()
        {
            DateTime startDate = dtpStartWorkDate.Value.Date;
            DateTime endDate = DateTime.Now.Date;
            decimal rate = ProvidentFundCalculator.GetProvidentFundNotOverRatePercent(startDate, endDate);

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

            ComboBoxHelper.SetSourceToComboBox(cboProvidentFundRate, nameof(ComboBoxHelper.ComboBoxSource<decimal>.Display), nameof(ComboBoxHelper.ComboBoxSource<decimal>.Value), comboBoxSource);
        }

        private void SetValueDateOfBirth()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now;
        }

        private void Calulate()
        {
            DateTime startDate = dtpStartWorkDate.Value.Date;
            DateTime endDate = DateTime.Now.Date;
            decimal salary = Convert.ToDecimal(txtSalary.Text);
            decimal rate = ComboBoxHelper.GetSelectedValueFromComboBox<decimal>(cboProvidentFundRate);

            decimal providentFundCalculator = ProvidentFundCalculator.GetCalulateProvidentFund(startDate, endDate, salary, rate);
            lbTatalPVD.Text = providentFundCalculator.ToString("N2");
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
            };

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
            Calulate();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Calulate();

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
            LoadDatasourceToGridDisplay();
        }

        private void ClearData()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Now.Date;
            dtpStartWorkDate.Value = DateTime.Now.Date;
            txtSalary.Text = "0";
            lbTatalPVD.Text = "0.00";
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
            };
        }

        private void DtpStartWorkDate_ValueChanged(object sender, EventArgs e)
        {
            SetDatasourceCombobox();
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
        }
        #endregion
    }
}
