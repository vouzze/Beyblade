﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
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
