﻿using System;
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
        [TestCase(SUIT.Spade, RANK.Ace)]
        [TestCase(SUIT.Spade, RANK.Two)]
        [TestCase(SUIT.Spade, RANK.Three)]
        [TestCase(SUIT.Spade, RANK.Four)]
        [TestCase(SUIT.Spade, RANK.Five)]
        [TestCase(SUIT.Spade, RANK.Six)]
        [TestCase(SUIT.Spade, RANK.Seven)]
        [TestCase(SUIT.Spade, RANK.Eight)]
        [TestCase(SUIT.Spade, RANK.Nine)]
        [TestCase(SUIT.Spade, RANK.Ten)]
        [TestCase(SUIT.Spade, RANK.Jack)]
        [TestCase(SUIT.Spade, RANK.Queen)]
        [TestCase(SUIT.Spade, RANK.King)]
        [TestCase(SUIT.Diamond, RANK.Ace)]
        [TestCase(SUIT.Diamond, RANK.Two)]
        [TestCase(SUIT.Diamond, RANK.Three)]
        [TestCase(SUIT.Diamond, RANK.Four)]
        [TestCase(SUIT.Diamond, RANK.Five)]
        [TestCase(SUIT.Diamond, RANK.Six)]
        [TestCase(SUIT.Diamond, RANK.Seven)]
        [TestCase(SUIT.Diamond, RANK.Eight)]
        [TestCase(SUIT.Diamond, RANK.Nine)]
        [TestCase(SUIT.Diamond, RANK.Ten)]
        [TestCase(SUIT.Diamond, RANK.Jack)]
        [TestCase(SUIT.Diamond, RANK.Queen)]
        [TestCase(SUIT.Diamond, RANK.King)]
        [TestCase(SUIT.Heart, RANK.Ace)]
        [TestCase(SUIT.Heart, RANK.Two)]
        [TestCase(SUIT.Heart, RANK.Three)]
        [TestCase(SUIT.Heart, RANK.Four)]
        [TestCase(SUIT.Heart, RANK.Five)]
        [TestCase(SUIT.Heart, RANK.Six)]
        [TestCase(SUIT.Heart, RANK.Seven)]
        [TestCase(SUIT.Heart, RANK.Eight)]
        [TestCase(SUIT.Heart, RANK.Nine)]
        [TestCase(SUIT.Heart, RANK.Ten)]
        [TestCase(SUIT.Heart, RANK.Jack)]
        [TestCase(SUIT.Heart, RANK.Queen)]
        [TestCase(SUIT.Heart, RANK.King)]
        [TestCase(SUIT.Club, RANK.Ace)]
        [TestCase(SUIT.Club, RANK.Two)]
        [TestCase(SUIT.Club, RANK.Three)]
        [TestCase(SUIT.Club, RANK.Four)]
        [TestCase(SUIT.Club, RANK.Five)]
        [TestCase(SUIT.Club, RANK.Six)]
        [TestCase(SUIT.Club, RANK.Seven)]
        [TestCase(SUIT.Club, RANK.Eight)]
        [TestCase(SUIT.Club, RANK.Nine)]
        [TestCase(SUIT.Club, RANK.Ten)]
        [TestCase(SUIT.Club, RANK.Jack)]
        [TestCase(SUIT.Club, RANK.Queen)]
        [TestCase(SUIT.Club, RANK.King)]
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
        [TestCase(SUIT.Spade, RANK.Ace, "A♠")]
        [TestCase(SUIT.Spade, RANK.Two, "2♠")]
        [TestCase(SUIT.Spade, RANK.Three, "3♠")]
        [TestCase(SUIT.Spade, RANK.Four, "4♠")]
        [TestCase(SUIT.Spade, RANK.Five, "5♠")]
        [TestCase(SUIT.Spade, RANK.Six, "6♠")]
        [TestCase(SUIT.Spade, RANK.Seven, "7♠")]
        [TestCase(SUIT.Spade, RANK.Eight, "8♠")]
        [TestCase(SUIT.Spade, RANK.Nine, "9♠")]
        [TestCase(SUIT.Spade, RANK.Ten, "10♠")]
        [TestCase(SUIT.Spade, RANK.Jack, "J♠")]
        [TestCase(SUIT.Spade, RANK.Queen, "Q♠")]
        [TestCase(SUIT.Spade, RANK.King, "K♠")]
        [TestCase(SUIT.Diamond, RANK.Ace, "A♦")]
        [TestCase(SUIT.Diamond, RANK.Two, "2♦")]
        [TestCase(SUIT.Diamond, RANK.Three, "3♦")]
        [TestCase(SUIT.Diamond, RANK.Four, "4♦")]
        [TestCase(SUIT.Diamond, RANK.Five, "5♦")]
        [TestCase(SUIT.Diamond, RANK.Six, "6♦")]
        [TestCase(SUIT.Diamond, RANK.Seven, "7♦")]
        [TestCase(SUIT.Diamond, RANK.Eight, "8♦")]
        [TestCase(SUIT.Diamond, RANK.Nine, "9♦")]
        [TestCase(SUIT.Diamond, RANK.Ten, "10♦")]
        [TestCase(SUIT.Diamond, RANK.Jack, "J♦")]
        [TestCase(SUIT.Diamond, RANK.Queen, "Q♦")]
        [TestCase(SUIT.Diamond, RANK.King, "K♦")]
        [TestCase(SUIT.Heart, RANK.Ace, "A♥")]
        [TestCase(SUIT.Heart, RANK.Two, "2♥")]
        [TestCase(SUIT.Heart, RANK.Three, "3♥")]
        [TestCase(SUIT.Heart, RANK.Four, "4♥")]
        [TestCase(SUIT.Heart, RANK.Five, "5♥")]
        [TestCase(SUIT.Heart, RANK.Six, "6♥")]
        [TestCase(SUIT.Heart, RANK.Seven, "7♥")]
        [TestCase(SUIT.Heart, RANK.Eight, "8♥")]
        [TestCase(SUIT.Heart, RANK.Nine, "9♥")]
        [TestCase(SUIT.Heart, RANK.Ten, "10♥")]
        [TestCase(SUIT.Heart, RANK.Jack, "J♥")]
        [TestCase(SUIT.Heart, RANK.Queen, "Q♥")]
        [TestCase(SUIT.Heart, RANK.King, "K♥")]
        [TestCase(SUIT.Club, RANK.Ace, "A♣")]
        [TestCase(SUIT.Club, RANK.Two, "2♣")]
        [TestCase(SUIT.Club, RANK.Three, "3♣")]
        [TestCase(SUIT.Club, RANK.Four, "4♣")]
        [TestCase(SUIT.Club, RANK.Five, "5♣")]
        [TestCase(SUIT.Club, RANK.Six, "6♣")]
        [TestCase(SUIT.Club, RANK.Seven, "7♣")]
        [TestCase(SUIT.Club, RANK.Eight, "8♣")]
        [TestCase(SUIT.Club, RANK.Nine, "9♣")]
        [TestCase(SUIT.Club, RANK.Ten, "10♣")]
        [TestCase(SUIT.Club, RANK.Jack, "J♣")]
        [TestCase(SUIT.Club, RANK.Queen, "Q♣")]
        [TestCase(SUIT.Club, RANK.King, "K♣")]
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
