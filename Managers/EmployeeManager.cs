using MySql.Data.MySqlClient;
using ProvidenceFundQuize.Hepler;
using ProvidenceFundQuize.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvidenceFundQuize.Manager
{
    public class EmployeeManager
    {
        public class QuerySource
        {
            public string FieldName { get; set; }
            public object Value { get; set; }
        }

        #region Public Methods
        public static bool IsSaveLogEmployee(EmployeeLog employee)
        {
            MySqlConnection conn = new MySqlConnection(GlobalVariable.ConnectionString);
            conn.Open();
            MySqlTransaction tran = conn.BeginTransaction();

            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandText = QuerySaveLogEmployee(employee);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT MAX(EmployeeLogID) from provident.employeelog ;";
                string lastHDID = cmd.ExecuteScalar().ToString();

                foreach (EmployeeLogDetail employeeLogDetail in employee.employeeLogDetails)
                {
                    employeeLogDetail.EmployeeLogID = Convert.ToInt32(lastHDID);
                    cmd.Transaction = tran;
                    cmd.CommandText = QuerySaveLogEmployeeDetail(employeeLogDetail);
                    cmd.ExecuteNonQuery();
                }

                tran.Commit();

                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                tran.Dispose();
            }

            return false;
        }

        public static List<EmployeeLog> LoadDataEmployeeLog()
        {
            List<EmployeeLog> employees = new List<EmployeeLog>();
            MySqlConnection conn = new MySqlConnection(GlobalVariable.ConnectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = QueryGetDataEmployeeLog();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeLog emp = new EmployeeLog();
                    emp.EmployeeLogID = ReaderHepler.GetValueFromReader<int>(reader, nameof(EmployeeLog.EmployeeLogID));
                    emp.Firstname = ReaderHepler.GetValueFromReader<string>(reader, nameof(EmployeeLog.Firstname));
                    emp.Lastname = ReaderHepler.GetValueFromReader<string>(reader, nameof(EmployeeLog.Lastname));
                    emp.DateOfBirth = ReaderHepler.GetValueFromReader<DateTime>(reader, nameof(EmployeeLog.DateOfBirth));
                    emp.StartWorkDate = ReaderHepler.GetValueFromReader<DateTime>(reader, nameof(EmployeeLog.StartWorkDate));
                    emp.Salary = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLog.Salary));
                    emp.ProvidentFundRate = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLog.ProvidentFundRate));
                    emp.ProvidentFundCollectAmount = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLog.ProvidentFundCollectAmount));
                    emp.employeeLogDetails = GetEmployeeLogDetail(emp.EmployeeLogID);

                    employees.Add(emp);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return employees;
        }

        public static EmployeeLog GetDataEmployeeLogByID(int id)
        {
            MySqlConnection conn = new MySqlConnection(GlobalVariable.ConnectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = QueryGetDataEmployeeLog(id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeLog emp = new EmployeeLog();
                    emp.EmployeeLogID = ReaderHepler.GetValueFromReader<int>(reader, nameof(EmployeeLog.EmployeeLogID));
                    emp.Firstname = ReaderHepler.GetValueFromReader<string>(reader, nameof(EmployeeLog.Firstname));
                    emp.Lastname = ReaderHepler.GetValueFromReader<string>(reader, nameof(EmployeeLog.Lastname));
                    emp.DateOfBirth = ReaderHepler.GetValueFromReader<DateTime>(reader, nameof(EmployeeLog.DateOfBirth));
                    emp.StartWorkDate = ReaderHepler.GetValueFromReader<DateTime>(reader, nameof(EmployeeLog.StartWorkDate));
                    emp.Salary = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLog.Salary));
                    emp.ProvidentFundRate = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLog.ProvidentFundRate));
                    emp.ProvidentFundCollectAmount = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLog.ProvidentFundCollectAmount));
                    emp.employeeLogDetails = GetEmployeeLogDetail(emp.EmployeeLogID);

                    return emp;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return null;
        }

        public static List<EmployeeLogDetail> GetEmployeeLogDetail(int employeeLogID)
        {
            List<EmployeeLogDetail> employeeLogDetails = new List<EmployeeLogDetail>();
            MySqlConnection conn = new MySqlConnection(GlobalVariable.ConnectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = QueryGetEmployeeLogDetail(employeeLogID);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeLogDetail emp = new EmployeeLogDetail();
                    emp.EmployeeLogID = ReaderHepler.GetValueFromReader<int>(reader, nameof(EmployeeLogDetail.EmployeeLogID));
                    emp.EmployeeLogDetailID = ReaderHepler.GetValueFromReader<int>(reader, nameof(EmployeeLogDetail.EmployeeLogDetailID));
                    emp.WorkYear = ReaderHepler.GetValueFromReader<string>(reader, nameof(EmployeeLogDetail.WorkYear));
                    emp.Month = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLogDetail.Month));
                    emp.Salary = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLogDetail.Salary));
                    emp.PVDRate = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLogDetail.PVDRate));
                    emp.CompanyPaidPercent = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLogDetail.CompanyPaidPercent));
                    emp.ProvidentFundCollect = ReaderHepler.GetValueFromReader<decimal>(reader, nameof(EmployeeLogDetail.ProvidentFundCollect));

                    employeeLogDetails.Add(emp);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return employeeLogDetails;
        }

        #endregion

        #region Private Methods
        private static string QuerySaveLogEmployeeDetail(EmployeeLogDetail employeeDetail)
        {
            List<QuerySource> querySources = new List<QuerySource>();
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLogDetail.EmployeeLogID), Value = (employeeDetail.EmployeeLogID) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLogDetail.WorkYear), Value = StringFormatHelper.GetSingleQuote(employeeDetail.WorkYear) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLogDetail.Month), Value = (employeeDetail.Month) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLogDetail.Salary), Value = (employeeDetail.Salary) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLogDetail.PVDRate), Value = (employeeDetail.PVDRate) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLogDetail.CompanyPaidPercent), Value = (employeeDetail.CompanyPaidPercent) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLogDetail.ProvidentFundCollect), Value = (employeeDetail.ProvidentFundCollect) });

            var fieldNames = querySources.Select(a => a.FieldName).ToArray();
            var values = querySources.Select(a => a.Value).ToArray();

            string query = "INSERT INTO provident.employeelogdetail ( " + string.Join(",", fieldNames)
                    + ") VALUES ( " + string.Join(",", values) + " "
                    + ");"
                     ;

            return query;
        }

        private static string QuerySaveLogEmployee(EmployeeLog employee)
        {
            List<QuerySource> querySources = new List<QuerySource>();
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLog.Firstname), Value = StringFormatHelper.GetSingleQuote(employee.Firstname) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLog.Lastname), Value = StringFormatHelper.GetSingleQuote(employee.Lastname) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLog.DateOfBirth), Value = StringFormatHelper.GetSingleQuote(StringFormatHelper.GetShortEnDateFormat(employee.DateOfBirth)) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLog.StartWorkDate), Value = StringFormatHelper.GetSingleQuote(StringFormatHelper.GetShortEnDateFormat(employee.StartWorkDate)) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLog.Salary), Value = (employee.Salary) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLog.ProvidentFundRate), Value = (employee.ProvidentFundRate) });
            querySources.Add(new QuerySource { FieldName = nameof(EmployeeLog.ProvidentFundCollectAmount), Value = (employee.ProvidentFundCollectAmount) });

            var fieldNames = querySources.Select(a => a.FieldName).ToArray();
            var values = querySources.Select(a => a.Value).ToArray();

            string query = "INSERT INTO provident.employeelog ( " + string.Join(",", fieldNames)
                    + ") VALUES ( " + string.Join(",", values) + " "
                    + ");"
                     ;

            return query;
        }

        private static string QueryGetDataEmployeeLog()
        {
            return "SELECT * FROM provident.employeelog";
        }

        private static string QueryGetDataEmployeeLog(int employeeLogID)
        {
            return "SELECT * FROM provident.employeelog WHERE EmployeeLogID = '" + employeeLogID + "'";
        }

        private static string QueryGetEmployeeLogDetail(int employeeLogID)
        {
            return "SELECT * FROM provident.employeelogdetail WHERE EmployeeLogID = '" + employeeLogID + "'";
        }
        #endregion
    }
}
