using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{
    public sealed class EdgeType : CustomEnum
    {

        public static readonly EdgeType NORMAL = new EdgeType("Normal arc", "NORMAL");
        public static readonly EdgeType INHIBITOR = new EdgeType("Inhibitor arc", "INHIBITOR");
        public static readonly EdgeType RESET = new EdgeType("Reset arc", "RESET");

        private static List<EdgeType> values;

        public static EdgeType[] Values
        {
            get {
                return EdgeType.values.ToArray();
            }
        }

        private EdgeType(string name, string value) : base(name, value)
        {
            EdgeType.addNewItem(this);
        }

        public static EdgeType getDefault()
        {
            return EdgeType.NORMAL;
        }

        public static EdgeType getEnumByValue(string value)
        {
            EdgeType ret = EdgeType.getDefault();
            EdgeType[] items = EdgeType.Values;
            bool find = false;
            int i = 0;
            while ((i < items.Length) && (!find))
            {
                if (items[i].value.Equals(value.ToUpper()))
                {
                    ret = items[i];
                    find = true;
                }
                ++i;
            }
            return ret;
        }

        private static void addNewItem(EdgeType item)
        {
            if (EdgeType.values == null)
            {
                EdgeType.values = new List<EdgeType>();
            }
            EdgeType.values.Add(item);
        }

    }
}
