using SafeApplication;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        Safe safe = new Safe();
        [TestMethod]
        public void TestMethod1()
        {
            safe.lockUnlock("187");
            safe.lockUnlock("384");

            bool result = safe.getlocked();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            safe.lockUnlock("18738");
            safe.lockUnlock("1");

            bool result = safe.getlocked();
            Assert.IsFalse(result);
        }
    }
}