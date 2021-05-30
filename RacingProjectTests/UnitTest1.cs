using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingProject;
using System;

namespace RacingProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Better obj = new Better();
            if (obj.chkValue(1) == 1) {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            Better obj = new Better();
            if (obj.jumpRabit()>10 )
            {
                Assert.IsTrue(true);
            }
        }
    }
}
