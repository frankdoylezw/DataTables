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
            bool result = Helper.CompareColumns(_table1, _table2);
            Assert.IsTrue(result, "Column names are different");
        }

        [TestMethod]
        public void Compare_Values_In_Currency_Tables()
        {
            bool result = Helper.CompareRowContent(_table1, _table2);
            Assert.IsTrue(result, "Row content does not match");
        }

        [TestMethod]
        public void Compare_Row_Column_Count()
        {
            bool result = Helper.CompareRowColumnCount(_table1, _table2);
            Assert.IsTrue(result, "Column count does not match");
        }

        [TestMethod]
        public void Compare_Row_Content()
        {
            bool result = Helper.CompareRowContent(_table1, _table2);
            Assert.IsTrue(result, "Row content does not match");
        }
    }
}