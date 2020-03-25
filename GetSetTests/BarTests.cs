using System;
using GetSet;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetSetTests
{
    [TestClass]
    public class BarTests
    {
        [TestMethod]
        public void CallMethods()
        {
            Bar bar = new Bar();
            bar.BodyMethod();
            bar.ArrowMethod(true);
        }
    }
}
