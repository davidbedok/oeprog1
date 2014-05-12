using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StampCatalog
{
    public class StampCatalog
    {

        private const int MAX_NUMBER_OF_STAMPS = 100;

        private readonly Stamp[] stamps;
        private int index;

        public StampCatalog()
        {
            this.stamps = new Stamp[StampCatalog.MAX_NUMBER_OF_STAMPS];
            this.index = 0;
        }

        public void add(String name, String seriesName, int issueYear, int width, int height, EdgeType type, int faceValue, double multiplier)
        {
            if (this.index < StampCatalog.MAX_NUMBER_OF_STAMPS)
            {
                this.stamps[this.index++] = new Stamp(name, seriesName, issueYear, width, height, type, faceValue, multiplier);
            }
        }

        public double getTotalCatalogValue()
        {
            double ret = 0;
            for (int i = 0; i < this.index; i++)
            {
                ret += this.stamps[i].getValue();
            }
            return ret;
        }

        public int getTotalArea(String seriesName)
        {
            int ret = 0;
            for (int i = 0; i < this.index; i++)
            {
                if (this.stamps[i].Series != null && this.stamps[i].Series.Equals(seriesName))
                {
                    ret += this.stamps[i].Data.getArea();
                }
            }
            return ret;
        }

        public int getTotalAreaMod(String seriesName)
        {
            int ret = 0;
            if (seriesName != null)
            {
                for (int i = 0; i < this.index; i++)
                {
                    if (seriesName.Equals(this.stamps[i].Series))
                    {
                        ret += this.stamps[i].Data.getArea();
                    }
                }
            }
            return ret;
        }

        public Stamp[] getStamps(EdgeType type)
        {
            int numberOfStamps = this.count(type);
            Stamp[] result = new Stamp[numberOfStamps];
            int index = 0;
            for (int i = 0; i < this.index; i++)
            {
                if (this.stamps[i].Data.Type == type)
                {
                    result[index++] = this.stamps[i]; 
                }
            }
            return result;
        }

        private int count(EdgeType type)
        {
            int count = 0;
            for (int i = 0; i < this.index; i++ )
            {
                if (this.stamps[i].Data.Type == type)
                {
                    count++;
                }
            }
            return count;
        }

        public String[] getPreciousStampNames()
        {
            String[] result = new String[this.countPreciousStampNames()];
            int index = 0;
            for (int i = 0; i < this.index; i++)
            {
                if (this.stamps[i].Multiplier * 10 > this.stamps[i].getAge() )
                {
                    result[index++] = this.stamps[i].Name; 
                }
            }
            return result;
        }

        private int countPreciousStampNames()
        {
            int count = 0;
            for (int i = 0; i < this.index; i++)
            {
                if (this.stamps[i].Multiplier * 10 > this.stamps[i].getAge())
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder(100);
            info.AppendLine("<<<<< StampCatalog >>>>>");
            for (int i = 0; i < this.index; i++)
            {
                info.AppendLine(this.stamps[i].ToString());
            }
            return info.ToString();
        }

    }
}
