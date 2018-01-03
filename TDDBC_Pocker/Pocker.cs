﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDBC_Pocker
{
    /// <summary>
    /// トランプの数字一覧を列挙化
    /// </summary>
    public enum RANK
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    /// <summary>
    /// トランプのマークを列挙化
    /// </summary>
    public enum SUIT
    {
        Spade,
        Heart,
        Club,
        Diamond
    }

    /// <summary>
    /// 文字列変換を行うクラスは全カード共通のため、1つのクラスとして抽出
    /// プライベートなシングルトンとして用意する
    /// </summary>
    class CardNotation
    {
        public Dictionary<SUIT, string> str_suit_;
        public Dictionary<RANK, string> str_rank_;

        public static CardNotation Signleton = new CardNotation();

        public CardNotation()
        {
            /// カードの数値と文字列の辞書型のメモリを作成
            str_rank_ = new Dictionary<RANK, string>();
            str_rank_.Add(RANK.Ace, "A");
            str_rank_.Add(RANK.King, "K");
            str_rank_.Add(RANK.Queen, "Q");
            str_rank_.Add(RANK.Jack, "J");

            for (int i = 2; i <= 10; i++)
            {
                str_rank_.Add((RANK)i, i.ToString());
            }

            /// カードのマークと文字列の辞書型のメモリを作成
            str_suit_ = new Dictionary<SUIT, string>();
            str_suit_.Add(SUIT.Club, "♣");
            str_suit_.Add(SUIT.Heart, "♥");
            str_suit_.Add(SUIT.Diamond, "♦");
            str_suit_.Add(SUIT.Spade, "♠");
        }
    }

    public class Card
    {
        public RANK Rank { get; }
        public SUIT Suit { get; }

        public Card(SUIT suit, RANK rank)
        {
            this.Suit = suit;
            this.Rank = rank;    
        }
 
        /// <summary>
        /// デフォルトの文字列変換を関数オーバーライドして使用する
        /// 結果を作成する際は静的なシングルトンから作成する
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return CardNotation.Signleton.str_rank_[this.Rank] + CardNotation.Signleton.str_suit_[this.Suit];
        }
    }

    public class Pocker
    {
    }
}
