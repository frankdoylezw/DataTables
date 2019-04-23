using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    class Helper
    {
        public static bool CompareRows(DataTable table1, DataTable table2)
        {
            foreach (DataRow row1 in table1.Rows)
            {
                foreach (DataRow row2 in table2.Rows)
                {
                    
                    var array1 = row1.ItemArray;
                    var array2 = row2.ItemArray;
                    var decimals1 = GetDecimals(array1, (decimal) 1.5);
                    var decimals2 = GetDecimals(array2, (decimal) 1.0);
                    return (decimals1.SequenceEqual(decimals2));

                   }
            }

            return false;
        }
        
        static List<decimal> GetDecimals(object[] array, decimal multiplier)
        {
            var list = new List<decimal>();
            foreach (object value in array)
            {
                try
                {
                    decimal result = (decimal) value;
                    result *= multiplier;
                    list.Add(result);
                }
                catch
                {
                    // Error.
                }
            }

            return list;
        }
    }
}