using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{
    public static class CustomExtensions
    {

        public static SimpleEdgeType getDefault(this SimpleEdgeType edgeType)
        {
            return SimpleEdgeType.NORMAL;
        }

        public static String getLabel(this SimpleEdgeType edgeType)
        {
            return new EdgeTypeLabel().getLabel(edgeType);
        }

        public static int getCustomOrdinal(this SimpleEdgeType edgeType, int param)
        {
            return ((int)edgeType * param);
        }

    }
}
