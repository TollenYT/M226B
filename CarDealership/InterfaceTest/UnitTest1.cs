using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_SubstractMethod()
        {
            IPerson test = new PersonStub();
            int res = test.AgeCalculate(0, 0);
            Assert.AreEqual(res, 5);
        }
    }
}
    