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
        [TestCase(SUIT.Diamond, RANK.Ace)]
        [TestCase(SUIT.Spade, RANK.Jack)]
        [TestCase(SUIT.Heart, RANK.King)]
        [TestCase(SUIT.Club, RANK.Seven)]
        public void Cardを定義してインスタンスを作成する()
        {
            TestContext.Run((SUIT suit, RANK rank) =>
            {
                Card target = new Card(suit, rank);
                Assert.AreEqual(target.Suit, suit);
                Assert.AreEqual(target.Rank, rank);
            });
        }

        [TestMethod]
        public void Cardのインスタンスから文字列表記を取得する1()
        {
            Card target = new Card(SUIT.Diamond, RANK.Ace);
            Assert.AreEqual(target.ToString(), "A♦");
        }

        [TestMethod]
        [TestCase(SUIT.Diamond, RANK.Ace, "A♦")]
        [TestCase(SUIT.Spade, RANK.Jack, "J♠")]
        [TestCase(SUIT.Heart, RANK.King, "K♥")]
        [TestCase(SUIT.Club, RANK.Seven, "7♣")]
        public void Cardのインスタンスから文字列表記を取得する2()
        {
            TestContext.Run((SUIT suit, RANK rank, string expect) =>
            {
                Card target = new Card(suit, rank);
                Assert.AreEqual(target.ToString(), expect);
            });
        }
    }
}
