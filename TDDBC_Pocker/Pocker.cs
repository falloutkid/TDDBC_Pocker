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
            return "1♦";
        }
    }

    public class Pocker
    {
    }
}
