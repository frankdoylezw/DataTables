using System;
using System.Data;

namespace DataTables
{
    public static class Tables
    {
        public static DataTable GetTable1()
        {
            var dt1 = new DataTable {TableName = "Table A - Prices in Sterling"};
            dt1.Columns.Add("Product", typeof(string));
            dt1.Columns.Add("Variety1", typeof(decimal));
            dt1.Columns.Add("Variety2", typeof(decimal));
            dt1.Columns.Add("Variety3", typeof(decimal));
            dt1.Columns.Add("Variety4", typeof(decimal));
            dt1.Rows.Add("Product 1", 10, 12, 14, 45);
            dt1.Rows.Add("Product 2", 20, 15, 24);
            dt1.Rows.Add("Product 3", 22, 60);
            dt1.Rows.Add("Product 4", 28);
            var sumvariety1 = (decimal) dt1.Compute("SUM(Variety1)", string.Empty);
            var sumvariety2 = (decimal) dt1.Compute("SUM(Variety2)", string.Empty);
            var sumvariety3 = (decimal) dt1.Compute("SUM(Variety3)", string.Empty);
            var sumvariety4 = (decimal) dt1.Compute("SUM(Variety4)", string.Empty);
            dt1.Rows.Add("Total", sumvariety1, sumvariety2, sumvariety3, sumvariety4);
            return dt1;
        }

        public static DataTable GetTable2()
        {
            var dt2 = new DataTable {TableName = "Table B - Prices in Euro"};
            dt2.Columns.Add("Product", typeof(string));
            dt2.Columns.Add("Variety1", typeof(decimal));
            dt2.Columns.Add("Variety2", typeof(decimal));
            dt2.Columns.Add("Variety3", typeof(decimal));
            dt2.Columns.Add("Variety4", typeof(decimal));
            dt2.Rows.Add("Product 1", 15, 18, 21, 67.5);
            dt2.Rows.Add("Product 2", 30, 22.5, 36);
            dt2.Rows.Add("Product 3", 33, 90);
            dt2.Rows.Add("Product 4", 42);
            decimal sumvariety1 = (decimal) dt2.Compute("SUM(Variety1)", String.Empty);
            decimal sumvariety2 = (decimal) dt2.Compute("SUM(Variety2)", String.Empty);
            decimal sumvariety3 = (decimal) dt2.Compute("SUM(Variety3)", String.Empty);
            decimal sumvariety4 = (decimal) dt2.Compute("SUM(Variety4)", String.Empty);
            dt2.Rows.Add("Total", sumvariety1, sumvariety2, sumvariety3, sumvariety4);
            return dt2;
        }
    }
}