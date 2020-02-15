using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class LABA1tests
    {
        [TestMethod]
        public void TestMethod2()
        {
            int a = 3;
            int b = 10;
            double expected = 244.92;
            double actual = LAB1.Program.Volume(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
