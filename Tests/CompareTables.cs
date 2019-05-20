using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataTables;

namespace Tests
{
    [TestClass]
    public class CurrencyTablesTests
    {
        readonly DataTable _table1 = Tables.GetTable1();
        readonly DataTable _table2 = Tables.GetTable2();

        [TestMethod]
        public void Compare_Column_Names()
        {
            bool compareColumnResult = Helper.CompareColumns(_table1, _table2);
            Assert.IsTrue(compareColumnResult);
        }

        [TestMethod]
        public void Compare_Row_Column_Count()
        {
            bool rowColumnCountResult = Helper.CompareRowColumnCount(_table1, _table2);
            Assert.IsTrue(rowColumnCountResult, "Column count does not match");
        }

        [TestMethod]
        public void Compare_Row_Content()
        {
            bool rowContentResult = Helper.CompareRowContent(_table1, _table2);
            Assert.IsTrue(rowContentResult, "Row content does not match");
        }
    }
}