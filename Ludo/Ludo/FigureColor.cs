using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    public class FigureColor
    {

        public static readonly FigureColor Blue = new FigureColor('O');
        public static readonly FigureColor Red = new FigureColor('X');
        public static readonly FigureColor Green = new FigureColor('@');
        public static readonly FigureColor Yellow = new FigureColor('#');

        private static List<FigureColor> values;

        private readonly char sign;

        public static FigureColor[] Values
        {
            get
            {
                return values.ToArray();
            }
        }

        public char Sign
        {
            get { return this.sign; }
        }

        private FigureColor(char sign)
        {
            this.sign = sign;
            Add(this);
        }

        private static void Add(FigureColor item)
        {
            if (values == null)
            {
                values = new List<FigureColor>();
            }
            values.Add(item);
        }

        public override String ToString()
        {
            return "" + this.sign;
        }

    }
}
