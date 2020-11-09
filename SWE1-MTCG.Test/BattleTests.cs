using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using SWE1_MTCG;
using SWE1_MTCG.Card;
using SWE1_MTCG.User;

namespace SWE1_MTCG.Test
{
    class BattleTests
    {
        [Test]
        public void SingleTurnTest()
        {
            MTCGUser UserA = new MTCGUser("Tester A", 1, 20);
            MTCGUser UserB = new MTCGUser("Tester B", 2, 20);

            Card.Card Acard1 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);
            Card.Card Acard2 = new MonsterCard("Dragon 2", 1200, Element.Water, MonsterTypes.Dragon);
            Card.Card Acard3 = new MonsterCard("Dragon 3", 1900, Element.Normal, MonsterTypes.Dragon);
            Card.Card Acard4 = new MonsterCard("Mega Goblin", 2500, Element.Fire, MonsterTypes.Goblin);

            Card.Card Bcard1 = new MonsterCard("Goblin", 1000, Element.Normal, MonsterTypes.Goblin);
            Card.Card Bcard2 = new MonsterCard("Elf", 2000, Element.Fire, MonsterTypes.FireElf);
            Card.Card Bcard3 = new MonsterCard("Wizzard", 2000, Element.Water, MonsterTypes.Wizzard);
            Card.Card Bcard4 = new MonsterCard("Mega Dragon", 2000, Element.Fire, MonsterTypes.Dragon);

            Deck DeckA = new Deck(Acard1, Acard2, Acard3, Acard4);
            Deck DeckB = new Deck(Bcard1, Bcard2, Bcard3, Bcard4);

            Battle battle1 = new Battle(UserA, UserB, DeckA, DeckB);

            battle1.battleTurnMonsterOnly(DeckA._card1, DeckB._card1);
            Assert.AreEqual(battle1.turnWinner, UserA);

            battle1.battleTurnMonsterOnly(DeckA._card3, DeckB._card3);
            Assert.AreEqual(battle1.turnWinner, UserB);
        }

    }
}
