using System;
using System.Collections.Generic;
using System.Text;

namespace SWE1_MTCG.Card
{
    public class MonsterCard : AbstractCard
    {
        public MonsterCard(string name, int attack, Element element) : base(name, attack, element, CardType.Monster)
        {
        }
    }
}
