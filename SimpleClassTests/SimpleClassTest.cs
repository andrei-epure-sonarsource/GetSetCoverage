using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleClassTests
{
    [TestClass]
    public class SimpleClassTest
    {
        [TestMethod]
        public void Ten()
        {
            var underTest = new SimpleClass.SimpleClass();
            Assert.AreEqual("ten", underTest.SwitchExpression(10));
        }

        [TestMethod]
        public void Twenty()
        {
            var underTest = new SimpleClass.SimpleClass();
            Assert.AreEqual("twenty", underTest.SwitchExpression(20));
        }

        [TestMethod]
        public void IfTrue()
        {
            var underTest = new SimpleClass.SimpleClass();
            Assert.AreEqual("ten", underTest.IfElse(true));
        }
    }
}
