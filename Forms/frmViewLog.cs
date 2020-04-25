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
    public partial class frmViewLog : Form
    {
        #region Member,Properties
        private List<EmployeeLog> employees = new List<EmployeeLog>();
        #endregion

        #region Constructor
        public frmViewLog()
        {
            InitializeComponent();

            this.Load += FrmViewLog_Load;
        }
        #endregion

        #region Methods
        private void ActivateEvents()
        {
            gridViewDisplay.CellDoubleClick += GridViewDisplay_CellDoubleClick;
            gridViewDisplay.CellClick += GridViewDisplay_CellClick;
        }

        private void LoadDefaultData()
        {
            LoadDatasourceToGridDisplay();
        }

        private void LoadDatasourceToGridDisplay()
        {
            employees = EmployeeManager.LoadDataEmployeeLog();

            gridViewDisplay.DataSource = employees;
            gridViewDisplay.Refresh();

            if (!employees.Any())
                return;

            gridViewDetail.DataSource = employees.FirstOrDefault().employeeLogDetails;
            gridViewDetail.Refresh();
        }

        #endregion

        #region Events
        private void FrmViewLog_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            ActivateEvents();
        }

        private void GridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(gridViewDisplay.Rows[e.RowIndex].Cells["EmployeeLogIDs"].Value);

            gridViewDetail.DataSource = employees.Find(a => a.EmployeeLogID == id).employeeLogDetails;
            gridViewDetail.Refresh();
        }

        private void GridViewDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
        }
        #endregion
    }
}
