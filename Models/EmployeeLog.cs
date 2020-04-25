using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidenceFundQuize.Model
{
    public class EmployeeLog
    {
        public int EmployeeLogID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartWorkDate { get; set; }
        public decimal Salary { get; set; }
        public decimal ProvidentFundRate { get; set; }
        public decimal ProvidentFundCollectAmount { get; set; }
        public List<EmployeeLogDetail> employeeLogDetails { get; set; }
    }
}
