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

        #region 課題1-1
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
        #endregion

        #region 課題1-2
        [TestMethod]
        public void もう1枚のカードと同じスートを持つかT()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card king_of_diamond = new Card(SUIT.Diamond, RANK.King);

            Assert.IsTrue(ace_of_diamond.hasSameSuit(king_of_diamond));
        }

        [TestMethod]
        public void もう1枚のカードと同じスートを持つかF()
        {
            Card ace_of_club = new Card(SUIT.Club, RANK.Ace);
            Card king_of_diamond = new Card(SUIT.Diamond, RANK.King);

            Assert.IsFalse(ace_of_club.hasSameSuit(king_of_diamond));
        }

        [TestMethod]
        public void もう1枚のカードと同じランクを持つかT()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card ace_of_club = new Card(SUIT.Club, RANK.Ace);

            Assert.IsTrue(ace_of_diamond.hasSameRank(ace_of_club));
        }

        [TestMethod]
        public void もう1枚のカードと同じランクを持つかF()
        {
            Card ace_of_club = new Card(SUIT.Club, RANK.Ace);
            Card king_of_diamond = new Card(SUIT.Diamond, RANK.King);

            Assert.IsFalse(ace_of_club.hasSameRank(king_of_diamond));
        }
        #endregion

        #region 課題2-1
        [TestMethod]
        public void カードが2枚保持できること()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card king_of_diamond = new Card(SUIT.Diamond, RANK.King);

            TwoCardPocker target = new TwoCardPocker(ace_of_diamond, king_of_diamond);

            Assert.AreEqual(target.FirstCard, ace_of_diamond);
            Assert.AreEqual(target.SecondCard, king_of_diamond);
        }

        [TestMethod]
        public void ペアが判定できることT()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card ace_of_club = new Card(SUIT.Club, RANK.Ace);

            TwoCardPocker target = new TwoCardPocker(ace_of_diamond, ace_of_club);

            Assert.IsTrue(target.isPair());
        }

        [TestMethod]
        public void ペアが判定できることF()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card king_of_club = new Card(SUIT.Club, RANK.King);

            TwoCardPocker target = new TwoCardPocker(ace_of_diamond, king_of_club);

            Assert.IsFalse(target.isPair());
        }

        [TestMethod]
        public void フラッシュが判定できることF()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card ace_of_club = new Card(SUIT.Club, RANK.Ace);

            TwoCardPocker target = new TwoCardPocker(ace_of_diamond, ace_of_club);

            Assert.IsFalse(target.isFlash());
        }

        [TestMethod]
        public void フラッシュが判定できることT()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card king_of_diamond = new Card(SUIT.Diamond, RANK.King);

            TwoCardPocker target = new TwoCardPocker(ace_of_diamond, king_of_diamond);

            Assert.IsTrue(target.isFlash());
            
        }

        [TestMethod]
        public void ハイカードが判定できることT()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card seven_of_club = new Card(SUIT.Club, RANK.Seven);

            TwoCardPocker target = new TwoCardPocker(ace_of_diamond, seven_of_club);

            Assert.IsTrue(target.isHighCard());
        }

        [TestMethod]
        public void ハイカードが判定できることF1()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card king_of_diamond = new Card(SUIT.Diamond, RANK.King);

            TwoCardPocker target = new TwoCardPocker(ace_of_diamond, king_of_diamond);

            Assert.IsFalse(target.isHighCard());

        }

        [TestMethod]
        public void ハイカードが判定できることF2()
        {
            Card ace_of_diamond = new Card(SUIT.Diamond, RANK.Ace);
            Card ace_of_club = new Card(SUIT.Club, RANK.Ace);

            TwoCardPocker target = new TwoCardPocker(ace_of_diamond, ace_of_club);

            Assert.IsFalse(target.isHighCard());

        }
        #endregion
    }
}
