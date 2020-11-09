using System;
using System.Collections.Generic;
using System.Text;
using SWE1_MTCG.Card;

namespace SWE1_MTCG
{
    public class Deck
    {
        public ICard _card1 { get; }
        public ICard _card2 { get; }
        public ICard _card3 { get; }
        public ICard _card4 { get; }

        public Deck(ICard card1, ICard card2, ICard card3, ICard card4)
        {
            this._card1 = card1;
            this._card2 = card2;
            this._card3 = card3;
            this._card4 = card4;
        }

    }
}
