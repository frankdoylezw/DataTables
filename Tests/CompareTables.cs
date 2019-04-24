using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataTables;

namespace Tests
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void Compare_Values_In_Currency_Tables()
        {
            bool result = Helper.CompareRows(Tables.GetTable1(), Tables.GetTable2());
            Assert.IsTrue(result);
        }
    }
}