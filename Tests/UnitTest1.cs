using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataTables;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareTables()
        {
            bool result = Helper.CompareRows(Tables.GetTable1(), Tables.GetTable2());
            Assert.IsTrue(result);
        }
    }
}