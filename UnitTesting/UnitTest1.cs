using SafeApplication;
using System.Transactions;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        Safe safe = new Safe(new Safe.FakeUserInput());
        [TestMethod]
        public void TestMethod1()
        {
            safe.lockUnlock("187384");

            bool result = safe.getlocked();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            safe.lockUnlock("187381");

            bool result = safe.getlocked();
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Safe safe = new Safe(new Safe.FakeUserInput());
            Program program = new Program();
        }

        [TestMethod]
        public void TestMethod4()
        {
            safe.lockUnlockRand();
        }

        [TestMethod]
        public void TestMothod5()
        {
            safe.enterNum(new Safe.FakeUserInput());
        }
        [TestMethod]
        public void TestMothod6()
        {
            safe.lockUnlock("187384");
            safe.lockUnlock("187381");
            safe.lockUnlock("18187384");
            safe.lockUnlock("187384");
            safe.lockUnlock("187385");
            safe.lockUnlock("180385");
        }

        

    }
}