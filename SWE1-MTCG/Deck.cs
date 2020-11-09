using System;
using System.Collections.Generic;
using System.Text;
using SWE1_MTCG.Card;

namespace SWE1_MTCG
{
    public class Deck
    {
        public Card.Card _card1 { get; }
        public Card.Card _card2 { get; }
        public Card.Card _card3 { get; }
        public Card.Card _card4 { get; }

        public Deck(Card.Card card1, Card.Card card2, Card.Card card3, Card.Card card4)
        {
            this._card1 = card1;
            this._card2 = card2;
            this._card3 = card3;
            this._card4 = card4;
        }

    }
}
