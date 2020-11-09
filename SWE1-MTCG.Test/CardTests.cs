using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using SWE1_MTCG;
using SWE1_MTCG.Card;

namespace SWE1_MTCG.Test
{
    class CardTests
    {
        [Test]
        public void TestIsMonsterCard()
        {
            ICard card = new MonsterCard("Test", 1500, Element.Fire);
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
    }
}
