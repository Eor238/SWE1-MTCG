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

            ICard Acard1 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);
            ICard Acard2 = new MonsterCard("Dragon 2", 1200, Element.Water, MonsterTypes.Dragon);
            ICard Acard3 = new MonsterCard("Dragon 3", 1900, Element.Normal, MonsterTypes.Dragon);
            ICard Acard4 = new MonsterCard("Dragon 4", 500, Element.Fire, MonsterTypes.Dragon);

            ICard Bcard1 = new MonsterCard("Goblin", 1000, Element.Normal, MonsterTypes.Goblin);
            ICard Bcard2 = new MonsterCard("Elf", 2000, Element.Fire, MonsterTypes.FireElf);
            ICard Bcard3 = new MonsterCard("Wizzard", 2000, Element.Water, MonsterTypes.Wizzard);
            ICard Bcard4 = new MonsterCard("Mega Dragon", 2000, Element.Fire, MonsterTypes.Dragon);

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
