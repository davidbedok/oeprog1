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

        public static string customToString(this SimpleEdgeType edgeType)
        {
            return "ET_" + edgeType.ToString();
        }

        public static int customCalculate(this SimpleEdgeType edgeType)
        {
            return ((int)edgeType * 5);
        }

        public static int customCalculate(this SimpleEdgeType edgeType, int param)
        {
            return ((int)edgeType * param);
        }

    }
}
