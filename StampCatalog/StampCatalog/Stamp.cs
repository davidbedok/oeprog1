using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StampCatalog
{
    public class Stamp
    {
        private const String UNIT = "Forint";

        private readonly String name;
        private readonly String seriesName;
        private readonly int issueYear;
        private readonly StampData data;
        private readonly int faceValue;
        private readonly double multiplier;

        public String Name
        {
            get { return this.name; }
        }

        public StampData Data
        {
            get { return this.data; }
        }

        public String Series
        {
            get { return this.seriesName; }
        }

        public double Multiplier
        {
            get { return this.multiplier; }
        }

        public Stamp(String name, String seriesName, int issueYear, int width, int height, EdgeType type, int faceValue, double multiplier)
        {
            this.name = name;
            this.seriesName = seriesName;
            this.issueYear = issueYear;
            this.data = new StampData(width, height, type);
            this.faceValue = faceValue;
            this.multiplier = multiplier;
        }

        public double getValue()
        {
            return this.multiplier * this.faceValue;
        }

        public int getAge()
        {
            return DateTime.Now.Year - this.issueYear;
        }

        public override string ToString()
        {
            return this.name + " " + this.faceValue + " "+Stamp.UNIT+" ( " + this.seriesName+", " + this.issueYear + " ) " + this.data + " | value: " + this.getValue();
        }


    }
}
