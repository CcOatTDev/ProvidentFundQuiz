using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidenceFundQuize.Model
{
    public class ConditionsDatetime
    {
        private DateTime startDate;

        public ConditionsDatetime(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public DateTime ThreeMonthDate { get { return startDate.AddMonths(3); } }
        public DateTime OneYearDate { get { return startDate.AddYears(1); } }
        public DateTime ThreeYearDate { get { return startDate.AddYears(3); } }
        public DateTime FiveYearDate { get { return startDate.AddYears(5); } }
    }
}
