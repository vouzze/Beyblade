using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            int b = 10;
            double result = ConsoleApp1.Program.Square(a, b);
            Assert.AreEqual(188.4, result);
        }
    }
}
