using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OES.SuperMarketKata;
using System.Data;

namespace UnitTestSuperMarketKata
{
    [TestClass]
    public class SampleDBTest
    {
        [TestMethod]
        public void GetSampleDBUnitPrice()
        {
            SampleDB myDB = new SampleDB();

            DataRow[] found = myDB.GetSKUDetail("A");

            Assert.AreEqual(50, int.Parse(found[0]["UnitPrice"].ToString()));

        }
    }
}
