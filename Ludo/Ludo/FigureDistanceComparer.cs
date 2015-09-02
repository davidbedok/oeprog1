using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    public class FigureDistanceComparer : IComparer<Figure>
    {
        public int Compare(Figure figure1, Figure figure2)
        {
            return figure2.Distance - figure1.Distance;
        }
    }
}
