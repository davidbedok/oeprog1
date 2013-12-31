using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HunCard.CardEnum
{
    public enum CardRank /* : short */
    {
        r7 = 7,
        r8 = 8,
        r9 = 9,
        r10 = 10,
        Under = 15, // Also
        Over = 20, // Felso
        King = 30, // Kiraly
        Ace = 50 // Asz
    }
}
