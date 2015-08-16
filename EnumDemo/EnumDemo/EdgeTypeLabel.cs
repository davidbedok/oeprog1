using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{
    public class EdgeTypeLabel
    {

        private Dictionary<SimpleEdgeType, String> map = new Dictionary<SimpleEdgeType, String>();

        public EdgeTypeLabel()
        {
            this.map = new Dictionary<SimpleEdgeType, String>();
            this.map.Add(SimpleEdgeType.NORMAL, "Normál él");
            this.map.Add(SimpleEdgeType.INHIBITOR, "Tiltó él");
            this.map.Add(SimpleEdgeType.RESET, "Reset él");
        }

        public String getLabel(SimpleEdgeType type)
        {
            return this.map[type];
        } 

    }
}
