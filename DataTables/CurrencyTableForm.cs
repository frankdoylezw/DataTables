using System.Windows.Forms;

namespace DataTables
{
    public partial class CurrencyTables : Form
    {
        public CurrencyTables()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = Tables.GetTable1();
            dataGridView2.DataSource = Tables.GetTable2();
        }
    }
}