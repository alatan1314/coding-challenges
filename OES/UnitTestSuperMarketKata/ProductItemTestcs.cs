using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OES.SuperMarketKata;

namespace UnitTestSuperMarketKata
{
    [TestClass]
    public class ProductItemTestcs
    {
        [TestMethod]
        public void GetAmount()
        {
            SampleDB myDB = new SampleDB();

            ProductItem item = new ProductItem("A", myDB);

            Assert.AreEqual(50, item.GetAmount());

            item.Quantity = 4;
            Assert.AreEqual(180, item.GetAmount());

            item.Quantity = 7;
            Assert.AreEqual(310, item.GetAmount());

        }
    }
}
