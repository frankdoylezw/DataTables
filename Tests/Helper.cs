using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    internal static class Helper
    {
        public static bool CompareColumns(DataTable table1, DataTable table2)
        {
            if (table1.Columns.Cast<DataColumn>().Any(dc => !table2.Columns.Contains(dc.ColumnName))) return false;
            {
                return true;
            }
        }

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

        public static bool CompareRowContent(DataTable table1, DataTable table2)
        {
            foreach (DataRow row1 in table1.Rows)
            {
                foreach (DataRow row2 in table2.Rows)
                {
                    var decimals1 = GetDecimals(row1.ItemArray, (decimal) 1.5);
                    var decimals2 = GetDecimals(row2.ItemArray, (decimal) 1.0);
                    if (decimals1.SequenceEqual(decimals2))
                    {
                        return true;
                    };
                }
            }

            return false;
        }

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