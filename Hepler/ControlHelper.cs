using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProvidenceFundQuize.Hepler
{
    public class ControlHelper
    {

    }

    public class ReaderHepler
    {
        public static T GetValueFromReader<T>(MySqlDataReader reader, string name)
        {
            object value = reader[name];
            Type t = typeof(T);
            t = Nullable.GetUnderlyingType(t) ?? t;

            if (t.IsEnum)
            {
                try
                {
                    return value == null || DBNull.Value.Equals(value) || string.IsNullOrEmpty(value.ToString())
                         ? default(T)
                         : (T)Enum.Parse(t, value.ToString());
                }
                catch (Exception ex)
                {
                    return default(T);
                }
            }

            if (typeof(T) == typeof(Boolean))
                return value == null || DBNull.Value.Equals(value)
                    ? default(T)
                    : (T)Convert.ChangeType(Convert.ToInt32(value), t);

            if (typeof(T) == typeof(DateTime?))
                return value == null || DBNull.Value.Equals(value)
                    ? default(T)
                    : (T)Convert.ChangeType(value, t);

            return value == null || DBNull.Value.Equals(value)
                    ? default(T)
                    : (T)Convert.ChangeType(value, t);
        }

        public static T GetValueFromReader<T>(SqlDataReader reader, string name)
        {
            object value = reader[name];
            Type t = typeof(T);
            t = Nullable.GetUnderlyingType(t) ?? t;

            if (typeof(T) == typeof(Boolean))
                return value == null || DBNull.Value.Equals(value)
                    ? default(T)
                    : (T)Convert.ChangeType(Convert.ToInt32(value), t);

            if (typeof(T) == typeof(DateTime?))
                return value == null || DBNull.Value.Equals(value)
                    ? default(T)
                    : (T)Convert.ChangeType(value, t);

            return value == null || DBNull.Value.Equals(value)
                    ? default(T)
                    : (T)Convert.ChangeType(value, t);
        }
    }

    public class StringFormatHelper
    {
        public static string GetEnDateOptimizeFormat(DateTime dt, string formatDate)
        {
            return dt.ToString(formatDate, new System.Globalization.CultureInfo("en-US"));
        }

        public static string GetShortEnDateAndTimeFormat(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss", new System.Globalization.CultureInfo("en-US"));
        }

        public static string GetShortEnDateFormat(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"));
        }

        public static string GetThDateOptimizeFormat(DateTime dt, string formatDate)
        {
            return dt.ToString(formatDate, new System.Globalization.CultureInfo("th-TH"));
        }

        public static string GetShortThDateAndTimeFormat(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy HH:mm:ss", new System.Globalization.CultureInfo("th-TH"));
        }
        public static string GetShortThDateFormat(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy", new System.Globalization.CultureInfo("th-TH"));
        }

        public static string GetSingleQuote<T>(T text)
        {
            return string.Format("'{0}'", text.ToString());
        }
    }

    public class ComboBoxHelper
    {
        #region Combobox
        public class ComboBoxSource
        {
            public string Display { get; set; }
            public object Value { get; set; }
        }

        public class ComboBoxSource<T>
        {
            public string Display { get; set; }
            public T Value { get; set; }
        }

        public static void SetSourceToComboBox<TList, T>(ComboBox comboBox, string displayMember, string valueMember, List<TList> sources, T selectValue)
        {
            comboBox.DataSource = sources;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;

            if (sources == null || sources.Count == 0)
                return;

            comboBox.SelectedValue = (T)Convert.ChangeType(selectValue, typeof(T));
        }

        public static void SetSourceToComboBox(ComboBox comboBox, string displayMember, string valueMember, DataTable sources, int selectedIndex = 0)
        {
            comboBox.DataSource = sources;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;

            if (sources == null || sources.Rows.Count == 0)
                return;

            comboBox.SelectedIndex = selectedIndex;
        }

        public static void SetSourceToComboBox<T>(ComboBox comboBox, string displayMember, string valueMember, DataTable sources, T selectValue)
        {
            comboBox.DataSource = sources;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;

            if (sources == null || sources.Rows.Count == 0)
                return;

            comboBox.SelectedValue = (T)Convert.ChangeType(selectValue, typeof(T));
        }

        public static void SetSourceToComboBox<TList>(ComboBox comboBox, string displayMember, string valueMember, List<TList> sources, int selectedIndex = 0)
        {
            comboBox.DataSource = sources;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;

            if (sources == null || sources.Count == 0)
                return;

            comboBox.SelectedIndex = selectedIndex;
        }

        public static void SetSourceToComboBox<T>(ComboBox comboBox, List<ComboBoxSource<T>> sources, T selectValue)
        {
            comboBox.DataSource = sources;
            comboBox.DisplayMember = "Display";
            comboBox.ValueMember = "Value";

            if (sources == null || sources.Count == 0)
                return;

            comboBox.SelectedValue = (T)Convert.ChangeType(selectValue, typeof(T));
        }

        public static void SetSourceToComboBox<T>(ComboBox comboBox, List<ComboBoxSource<T>> sources, int selectedIndex = 0)
        {
            comboBox.DataSource = sources;
            comboBox.DisplayMember = "Display";
            comboBox.ValueMember = "Value";

            if (sources == null || sources.Count == 0)
                return;

            comboBox.SelectedIndex = selectedIndex;
        }

        public static T GetSelectedValueFromComboBox<T>(ComboBox comboBox)
        {
            object value = comboBox.SelectedValue;
            Type t = typeof(T);
            t = Nullable.GetUnderlyingType(t) ?? t;

            if (t.IsEnum)
            {
                try
                {
                    return value == null || DBNull.Value.Equals(value) || string.IsNullOrEmpty(value.ToString())
                         ? default(T)
                         : (T)Enum.Parse(t, value.ToString());
                }
                catch (Exception ex)
                {
                    return default(T);
                }
            }


            if (typeof(T) == typeof(string))
                return value == null || DBNull.Value.Equals(value)
                 ? default(T)
                : (T)Convert.ChangeType(value.ToString(), t);

            if (typeof(T) == typeof(bool))
                return value == null || DBNull.Value.Equals(value)
                 ? default(T)
                : (T)Convert.ChangeType(Convert.ToInt32(value), t);

            if (typeof(T) == typeof(DateTime?))
                return value == null || DBNull.Value.Equals(value)
                    ? default(T)
                    : (T)Convert.ChangeType(value, t);

            return value == null || DBNull.Value.Equals(value)
                ? default(T)
                : (T)Convert.ChangeType(value, t);

        }
        #endregion
    }
}
