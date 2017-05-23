using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coder.Tests
{
    [TestClass()]
    public class BaseAnyNumberTests
    {
        [TestMethod()]
        public void BaseAnyNumberTest()
        {
            BaseAnyNumber b = new BaseAnyNumber(10);
            Assert.AreEqual("0", b.toString());
        }

        [TestMethod()]
        public void IncTest()
        {
            {
                BaseAnyNumber b = new BaseAnyNumber(2);
                Assert.AreEqual("0", b.toString());
                b.Inc();
                Assert.AreEqual("1", b.toString());
                b.Inc();
                Assert.AreEqual("10", b.toString());
                b.Inc();
                Assert.AreEqual("11", b.toString());
            }
            {
                BaseAnyNumber b = new BaseAnyNumber(3);
                Assert.AreEqual("0", b.toString());
                b.Inc();
                Assert.AreEqual("1", b.toString());
                b.Inc();
                Assert.AreEqual("2", b.toString());
                b.Inc();
                Assert.AreEqual("10", b.toString());
            }
        }
    }
}