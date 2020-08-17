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
            Assert.AreEqual(0, bar.BodyMethod());
            Assert.AreEqual(0, bar.ArrowMethod(true));
        }

        [TestMethod]
        public void CallBarViaFoo()
        {
            FooCallsBar fooCallsBar = new FooCallsBar();
            fooCallsBar.CallBar(new Bar());
        }
    }
}
