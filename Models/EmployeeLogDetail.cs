using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvidenceFundQuize.Model
{
    public class EmployeeLogDetail
    {
        public int EmployeeLogDetailID { get; set; }
        public int EmployeeLogID { get; set; }
        public string WorkYear { get; set; }
        public decimal Month { get; set; }
        public decimal Salary { get; set; }
        public decimal PVDRate { get; set; }
        public decimal CompanyPaidPercent { get; set; }
        public decimal ProvidentFundCollect { get; set; }
    }
}
