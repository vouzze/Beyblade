using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class LABA1test
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            int b = 10;
            double result = LAB1.Program.Square(a, b);
            Assert.AreEqual(188.4, result);
        }
    }
}
