using System;
using SWE1_MTCG.Card;
using SWE1_MTCG.User;

namespace SWE1_MTCG
{
    class Program
    {
        static void Main(string[] args)
        {
            MTCGUser UserA = new MTCGUser("Tester A", 1, 20);
            MTCGUser UserB = new MTCGUser("Tester B", 2, 20);

            ICard Acard1 = new MonsterCard("Dragon", 2000, Element.Fire);
            ICard Acard2 = new MonsterCard("Dragon", 2000, Element.Fire);
            ICard Acard3 = new MonsterCard("Dragon", 2000, Element.Fire);
            ICard Acard4 = new MonsterCard("Dragon", 2000, Element.Fire);

            ICard Bcard1 = new MonsterCard("Goblin", 1000, Element.Normal);
            ICard Bcard2 = new MonsterCard("Dragon", 2000, Element.Fire);
            ICard Bcard3 = new MonsterCard("Dragon", 2000, Element.Fire);
            ICard Bcard4 = new MonsterCard("Dragon", 2000, Element.Fire);

            Deck DeckA = new Deck(Acard1, Acard2, Acard3, Acard4);
            Deck DeckB = new Deck(Bcard1, Bcard2, Bcard3, Bcard4);

            Battle battle1 = new Battle(UserA, UserB, DeckA, DeckB);

            battle1.battleTurnMonsterOnly(DeckA.GetCard1(), DeckB.GetCard1());
        }
    }
}
