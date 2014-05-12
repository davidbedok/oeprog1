using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StampCatalog
{
    public class StampData
    {
        private const String UNIT = "mm";

        private readonly int width;
        private readonly int height;
        private readonly EdgeType type;

        public EdgeType Type
        {
            get { return this.type; }
        }

        public StampData(int width, int height, EdgeType type)
        {
            this.width = width;
            this.height = height;
            this.type = type;
        }

        public int getArea()
        {
            return this.width * this.height;
        }

        public override string ToString()
        {
            return "["+this.width+StampData.UNIT+" x "+this.height+StampData.UNIT+" ("+this.getArea()+StampData.UNIT+"2)] " + this.type;
        }

    }
}
