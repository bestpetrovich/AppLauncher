using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppLauncher;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tt = new Class1();

            Assert.IsNotNull(tt);
        }
    }
}
