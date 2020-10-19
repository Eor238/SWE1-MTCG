using System;
using System.Collections.Generic;
using System.Text;
using SWE1_MTCG.Card;
using SWE1_MTCG.User;

namespace SWE1_MTCG
{
    class Battle
    {
        private readonly MTCGUser _opponentA;
        private readonly MTCGUser _opponentB;
        private readonly Deck _opponentADeck;
        private readonly Deck _opponentBDeck;

        public Battle(MTCGUser opponentA, MTCGUser opponentB, Deck opponentADeck, Deck opponentBDeck)
        {
            this._opponentA = opponentA;
            this._opponentB = opponentB;
            this._opponentADeck = opponentADeck;
            this._opponentBDeck = opponentBDeck;
        }

        public void battleTurnMonsterOnly(ICard cardA, ICard cardB)
        {
            if (cardA.Attack > cardB.Attack)
            {
                Console.WriteLine("Player A won the round!");
            }
            else if (cardA.Attack < cardB.Attack)
            {
                Console.WriteLine("Player B won the round!");
            }
            else
            {
                Console.WriteLine("The round is a tie!");
            }
        }

    }
}
