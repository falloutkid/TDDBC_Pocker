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

        public Card(SUIT suit, RANK rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public override string ToString()
        {
            string result = "";

            switch (this.Rank)
            {
                case RANK.Ace:
                    result += "A";
                    break;
                case RANK.Jack:
                    result += "J";
                    break;
                case RANK.Queen:
                    result += "Q";
                    break;
                case RANK.King:
                    result += "K";
                    break;
                default:
                    var int_rank = (int)this.Rank;
                    result += int_rank.ToString();
                    break;
            }

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
