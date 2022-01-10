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
            Iasdf bm = new PersonStub();
            int res = bm.Calculate(0, 0);
            Assert.AreEqual(res, 5);
        }
    }
}
