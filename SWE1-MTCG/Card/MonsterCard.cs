using System;
using System.Collections.Generic;
using System.Text;

namespace SWE1_MTCG.Card
{
    public class MonsterCard : AbstractCard
    {
        public MonsterTypes monstertype { get; }
        public MonsterCard(string name, int attack, Element element, MonsterTypes mType) : base(name, attack, element, CardType.Monster)
        {
            this.monstertype = mType;
        }

    }
}
