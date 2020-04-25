using ProvidenceFundQuize.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidenceFundQuize.Manager
{
    public class ProvidentFundCalculator
    {
        #region Public Method
        public static decimal GetCalulateProvidentFund(decimal month, decimal companyPaidPercent, decimal salary, decimal pvdRate)
        {
            decimal totalPVDAmount = ((salary * companyPaidPercent / 100) * month) + ((salary * pvdRate / 100) * month);

            return totalPVDAmount;
        }

        public static decimal GetCalulateProvidentFund(DateTime startDate, DateTime endDate, decimal salary, decimal pvdRate)
        {
            decimal companyPaidPercent = GetCompanyPaidPercent(startDate, endDate);
            decimal month = GetMonthPVDPaid(startDate, endDate);

            decimal totalPVDAmount = GetCalulateProvidentFund(month, companyPaidPercent, salary, pvdRate);

            return totalPVDAmount;
        }

        public static decimal GetMonthPVDPaid(DateTime startDate, DateTime endDate)
        {
            ConditionsDatetime conditionsDatetime = new ConditionsDatetime(startDate);

            DateTime beginPaidDate = conditionsDatetime.ThreeMonthDate;

            decimal month = 0;
            while (beginPaidDate < endDate)
            {
                beginPaidDate = beginPaidDate.AddMonths(1);
                ++month;
            }

            return month;
        }

        public static Dictionary<Int32, decimal> GetMonthAndYearPVDPaid(DateTime startDate, DateTime endDate)
        {
            ConditionsDatetime conditionsDatetime = new ConditionsDatetime(startDate);
            DateTime beginPaidDate = conditionsDatetime.ThreeMonthDate;

            Dictionary<Int32, decimal> monthAndYear = new Dictionary<int, decimal>();

            decimal month = 0;
            int oldYear = beginPaidDate.Year;
            while (beginPaidDate < endDate)
            {
                beginPaidDate = beginPaidDate.AddMonths(1);
                ++month;

                if (beginPaidDate.Year != oldYear)
                {
                    monthAndYear.Add(oldYear, month);
                    oldYear = beginPaidDate.Year;
                    month = 0;
                }
            }

            monthAndYear.Add(oldYear, month);

            return monthAndYear;
        }

        public static decimal GetCompanyPaidPercent(DateTime startDate, DateTime endDate)
        {
            ConditionsDatetime conditionsDatetime = new ConditionsDatetime(startDate);

            if (endDate < conditionsDatetime.ThreeMonthDate)
                return 0;

            if (endDate < conditionsDatetime.OneYearDate)
                return 10;

            if (endDate < conditionsDatetime.ThreeYearDate)
                return 30;

            if (endDate < conditionsDatetime.FiveYearDate)
                return 50;

            //if (endDate > conditionsDatetime.FiveYearDate)
            return 80;
        }

        public static decimal GetWorkYear(DateTime startDate, DateTime endDate)
        {
            decimal month = GetMonthPVDPaid(startDate, endDate);
            decimal year = month / 12;

            if (year < 1)
                return year;

            return Math.Floor(year);
        }
        #endregion

        #region Private Method
        public static decimal GetProvidentFundNotOverRatePercent(DateTime startDate, DateTime endDate)
        {
            ConditionsDatetime conditionsDatetime = new ConditionsDatetime(startDate);

            if (endDate < conditionsDatetime.ThreeMonthDate)
                return 0;

            if (endDate < conditionsDatetime.OneYearDate)
                return 3;

            if (endDate < conditionsDatetime.ThreeYearDate)
                return 5;

            if (endDate < conditionsDatetime.FiveYearDate)
                return 8;

            //if (endDate > conditionsDatetime.FiveYearDate)
            return 12;
        }
        #endregion
    }
}
