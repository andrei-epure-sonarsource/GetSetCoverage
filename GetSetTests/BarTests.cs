using System;
using GetSet;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetSetTests
{
    [TestClass]
    public class BarTests
    {
        [TestMethod]
        public void TestSetter()
        {
            Bar bar = new Bar();
            Assert.AreEqual(0, bar.CoveredGet);
            bar.CoveredSet = 1;
        }
    }
}
