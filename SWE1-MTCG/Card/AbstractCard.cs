﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SWE1_MTCG.Card
{
    public abstract class AbstractCard : ICard
    {
        public string Name { get; }
        public int Attack { get; }
        public Element Element { get; }
        public CardType CardType { get; }

        protected AbstractCard(string name, int attack, Element element, CardType cardtype)
        {
            this.Name = name;
            this.Attack = attack;
            //this.Defense = defense;
            this.Element = element;
            this.CardType = cardtype;
        }

    }
}
