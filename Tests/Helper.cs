using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Tests
{
    internal static class Helper
    {
        //Compares names of columns. Returns false if column names do not match.
        public static bool CompareColumns(DataTable table1, DataTable table2)
        {
            if (table1.Columns.Cast<DataColumn>().Any(dc => !table2.Columns.Contains(dc.ColumnName))) return false;
            {
                return true;
            }
        }

        //Returns false if tables are null. Returns false if row count does not match. Returns false if column count does not match.
        public static bool CompareRowColumnCount(DataTable table1, DataTable table2)
        {
            {
                if (table1 == null) return false;
                if (table2 == null) return false;
                if (table1.Rows.Count != table2.Rows.Count) return false;
                if (table1.Columns.Count != table2.Columns.Count) return false;
                {
                    return true;
                }
            }
        }

        //Iterates over each table, comparing values (after multiplication factor has been applied). Returns false if the values do not match.
        public static bool CompareRowContent(DataTable table1, DataTable table2)
        {
            if (table1.Rows.Count != table2.Rows.Count)
            {
                return false;
            }

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                var row1 = table1.Rows[i];
                var row2 = table2.Rows[i];
                var decimals1 = GetDecimals(row1.ItemArray, (decimal) 1.5);
                var decimals2 = GetDecimals(row2.ItemArray, (decimal) 1.0);
                if (!decimals1.SequenceEqual(decimals2))
                {
                    return false;
                }
            }

            return true;
        }

        //Method returns a list whose members have been multiplied by the 'multiplier' parameter
        private static List<decimal> GetDecimals(object[] array, decimal multiplier)
        {
            var list = new List<decimal>();
            foreach (var value in array)
                try
                {
                    var result = (decimal) value;
                    result *= multiplier;
                    list.Add(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(@"Error creating decimal list." + e.Message);
                }

            return list;
        }
    }
}