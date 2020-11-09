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

            Card.Card Acard1 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);
            Card.Card Acard2 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);
            Card.Card Acard3 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);
            Card.Card Acard4 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);

            Card.Card Bcard1 = new MonsterCard("Goblin", 1000, Element.Normal, MonsterTypes.Goblin);
            Card.Card Bcard2 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);
            Card.Card Bcard3 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);
            Card.Card Bcard4 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);

            Deck DeckA = new Deck(Acard1, Acard2, Acard3, Acard4);
            Deck DeckB = new Deck(Bcard1, Bcard2, Bcard3, Bcard4);

            Battle battle1 = new Battle(UserA, UserB, DeckA, DeckB);

            battle1.battleTurnMonsterOnly(DeckA._card1, DeckB._card1);
        }
    }
}
