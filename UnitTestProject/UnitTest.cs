using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDBC_Pocker;
using Moq;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        public TestContext TestContext { set; get; }

        [TestMethod]
        [TestCase(1,2,3)]
        public void SampleTestMethod()
        {
            TestContext.Run((int x, int y, int z) =>
            {
                // Assert.AreEqual(x + y, z);
                (x + y).Is(z);
            });
        }
    }
}
