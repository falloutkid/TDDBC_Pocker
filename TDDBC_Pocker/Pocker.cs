using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDBC_Pocker
{
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

    public enum SUIT
    {
        Spade,
        Heart,
        Club,
        Diamond
    }

    public class Card
    {
        public RANK Rank { get; }
        public SUIT Suit { get; }

        private Dictionary<SUIT, string> str_suit_;
        private Dictionary<RANK, string> str_rank_;

        public Card(SUIT suit, RANK rank)
        {
            this.Suit = suit;
            this.Rank = rank;

            str_rank_ = new Dictionary<RANK, string>();
            str_rank_.Add(RANK.Ace, "A");
            str_rank_.Add(RANK.King, "K");
            str_rank_.Add(RANK.Queen, "Q");
            str_rank_.Add(RANK.Jack, "J");

            for(int i = 2;i <= 10; i++)
            {
                str_rank_.Add((RANK)i, i.ToString());
            }

            str_suit_ = new Dictionary<SUIT, string>();
            str_suit_.Add(SUIT.Club, "♣");
            str_suit_.Add(SUIT.Heart, "♥");
            str_suit_.Add(SUIT.Diamond, "♦");
            str_suit_.Add(SUIT.Spade, "♠");
        }

        

        public override string ToString()
        {
            string result = "";

            result += str_rank_[this.Rank];

            switch (this.Suit)
            {
                case SUIT.Club:
                    result += "♣";
                    break;
                case SUIT.Heart:
                    result += "♥";
                    break;
                case SUIT.Diamond:
                    result += "♦";
                    break;
                case SUIT.Spade:
                    result += "♠";
                    break;
            }

            return result;
        }
    }

    public class Pocker
    {
    }
}
