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
    class CardTests
    {
        [Test]
        public void TestIsMonsterCard()
        {
            ICard card = new MonsterCard("Test", 1500, Element.Fire, MonsterTypes.Ork);
            var actual = card.CardType;
            Assert.AreEqual(CardType.Monster, actual);
        }

        [Test]
        public void TestIsSpellCard()
        {
            ICard card = new SpellCard("Test", 1500, Element.Fire);
            var actual = card.CardType;
            Assert.AreEqual(CardType.Spell, actual);
        }

        [Test]
        public void TestIsRightType()
        {
            MonsterCard card = new MonsterCard("Ork", 1500, Element.Fire, MonsterTypes.Ork);
            MonsterCard card2 = new MonsterCard("Dragon", 1500, Element.Fire, MonsterTypes.Dragon);
            MonsterCard card3 = new MonsterCard("Fire Elf", 1500, Element.Fire, MonsterTypes.FireElf);
            Assert.AreEqual(card.monstertype, MonsterTypes.Ork);
            Assert.AreEqual(card2.monstertype, MonsterTypes.Dragon);
            Assert.AreEqual(card3.monstertype, MonsterTypes.FireElf);
        }

        [Test]
        public void TestIsInDeck()
        {
            MTCGUser UserA = new MTCGUser("Tester A", 1, 20);
            MTCGUser UserB = new MTCGUser("Tester B", 2, 20);

            ICard Acard1 = new MonsterCard("Dragon", 2000, Element.Fire, MonsterTypes.Dragon);
            ICard Acard2 = new MonsterCard("Dragon 2", 1200, Element.Water, MonsterTypes.Dragon);
            ICard Acard3 = new MonsterCard("Dragon 3", 2000, Element.Normal, MonsterTypes.Dragon);
            ICard Acard4 = new MonsterCard("Dragon 4", 500, Element.Fire, MonsterTypes.Dragon);

            ICard Bcard1 = new MonsterCard("Goblin", 1000, Element.Normal, MonsterTypes.Goblin);
            ICard Bcard2 = new MonsterCard("Elf", 2000, Element.Fire, MonsterTypes.FireElf);
            ICard Bcard3 = new MonsterCard("Wizzard", 2000, Element.Water, MonsterTypes.Wizzard);
            ICard Bcard4 = new MonsterCard("Mega Dragon", 2000, Element.Fire, MonsterTypes.Dragon);

            Deck DeckA = new Deck(Acard1, Acard2, Acard3, Acard4);
            Deck DeckB = new Deck(Bcard1, Bcard2, Bcard3, Bcard4);

            Assert.AreEqual(Acard1, DeckA._card1);
            Assert.AreEqual(Acard3, DeckA._card3);
            Assert.AreEqual(Bcard2, DeckB._card2);
            Assert.AreEqual(Acard4, DeckA._card4);
        }

    }
}
