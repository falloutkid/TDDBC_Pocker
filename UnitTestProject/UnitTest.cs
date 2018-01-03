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

        [Ignore]
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

        [TestMethod]
        public void Cardを定義してインスタンスを作成する()
        {
            Card target = new Card(SUIT.Diamond, RANK.Ace);

            Assert.AreEqual(target.Suit, SUIT.Diamond);
            Assert.AreEqual(target.Rank, RANK.Ace);
        }
    }
}
