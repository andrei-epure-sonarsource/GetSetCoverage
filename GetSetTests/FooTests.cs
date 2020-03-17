using System;
using GetSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetSetTests
{
    [TestClass]
    public class FooTests
    {
        [TestMethod]
        public void Method_WithTrue()
        {
            Foo f = new Foo();
            Assert.IsTrue(f.Method(true));
        }

        [TestMethod]
        public void Method_WithFalse()
        {
            Foo f = new Foo();
            Assert.IsFalse(f.Method(false));
        }
    }
}
