using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTables
{
    public partial class CurrencyTables : Form
    {
        public CurrencyTables()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dt1 = new DataTable {TableName = "Table A - Prices in Sterling"};
            var dt2 = new DataTable {TableName = "Table B - Prices in Euro" };

            dt1.Columns.Add("Product",typeof(string));
            dt1.Columns.Add("Variety1",typeof(decimal));
            dt1.Columns.Add("Variety2",typeof(decimal));
            dt1.Columns.Add("Variety3", typeof(decimal));
            dt1.Columns.Add("Variety4", typeof(decimal));

            dt1.Rows.Add("Product 1", 10, 12, 14, 45);
            dt1.Rows.Add("Product 2", 20, 15, 24, null);
            dt1.Rows.Add("Product 3", 22, 60, null, null);
            dt1.Rows.Add("Product 4", 28, null, null, null);
            decimal sumvariety1 = (decimal) dt1.Compute("SUM(Variety1)", string.Empty);
            decimal sumvariety2 = (decimal) dt1.Compute("SUM(Variety2)", string.Empty);
            decimal sumvariety3 = (decimal) dt1.Compute("SUM(Variety3)", string.Empty);
            decimal sumvariety4 = (decimal) dt1.Compute("SUM(Variety4)", string.Empty);


            dt1.Rows.Add("Total", sumvariety1, sumvariety2, sumvariety3, sumvariety4);

            dt2.Columns.Add("Product", typeof(string));
            dt2.Columns.Add("Variety1", typeof(decimal));
            dt2.Columns.Add("Variety2", typeof(decimal));
            dt2.Columns.Add("Variety3", typeof(decimal));
            dt2.Columns.Add("Variety4", typeof(decimal));

            dt2.Rows.Add("Product 1", 15, 18, 21, 67.5);
            dt2.Rows.Add("Product 2", 30, 22.5, 36, null);
            dt2.Rows.Add("Product 3", 33, 90, null, null);
            dt2.Rows.Add("Product 4", 42, null, 24, null);

            decimal dt2Sumvariety1 = (decimal) dt2.Compute("SUM(Variety1)", string.Empty);
            decimal dt2Sumvariety2 = (decimal) dt2.Compute("SUM(Variety2)", string.Empty);
            decimal dt2Sumvariety3 = (decimal) dt2.Compute("SUM(Variety3)", string.Empty);
            decimal dt2Sumvariety4 = (decimal) dt2.Compute("SUM(Variety4)", string.Empty);

            dt2.Rows.Add("Total", dt2Sumvariety1, dt2Sumvariety2, dt2Sumvariety3, dt2Sumvariety4);

            dataGridView1.DataSource = dt1;
            dataGridView2.DataSource = dt2;

            


        }
        }
}
