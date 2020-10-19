using System;
using System.Collections.Generic;
using System.Text;

namespace SWE1_MTCG.Card
{
    public interface ICard
    {
        string Name { get; }
        int Attack { get; }
        Element Element { get; }
        CardType CardType { get; }
    }
}
