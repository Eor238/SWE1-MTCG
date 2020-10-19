using System;
using System.Collections.Generic;
using System.Text;

namespace SWE1_MTCG.Card
{
    public class SpellCard : AbstractCard
    {
        public SpellCard(string name, int attack, Element element) : base(name, attack, element, CardType.Spell)
        {
        }
    }
}
