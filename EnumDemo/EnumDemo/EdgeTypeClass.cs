using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{
    public sealed class EdgeTypeClass : ICloneable
    {

        public static readonly EdgeTypeClass NORMAL = new EdgeTypeClass("NORMAL", "Normal el");
        public static readonly EdgeTypeClass INHIBITOR = new EdgeTypeClass("INHIBITOR", "Tilto el");
        public static readonly EdgeTypeClass RESET = new EdgeTypeClass("RESET", "Reset el");

        private static List<EdgeTypeClass> values;

        private readonly String name;
        private readonly String label;

        public static EdgeTypeClass[] Values
        {
            get
            {
                return values.ToArray();
            }
        }

        public String Name
        {
            get { return this.name; }
        }

        public String Label
        {
            get { return this.label; }
        }

        private EdgeTypeClass(String name, String label)
        {
            this.name = name;
            this.label = label;
            add(this);
        }

        private static void add(EdgeTypeClass item)
        {
            if (values == null)
            {
                values = new List<EdgeTypeClass>();
            }
            values.Add(item);
        }

        public int GetOrdinal()
        {
            return values.IndexOf(this);
        }

        public static EdgeTypeClass Parse(String name)
        {
            EdgeTypeClass ret = EdgeTypeClass.NORMAL;
            EdgeTypeClass[] items = EdgeTypeClass.Values;
            bool find = false;
            int i = 0;
            while ((i < items.Length) && (!find))
            {
                if (items[i].name.Equals(name))
                {
                    ret = items[i];
                    find = true;
                }
                ++i;
            }
            return ret;
        }

        public static EdgeTypeClass getDefault()
        {
            return NORMAL;
        }

        public override String ToString()
        {
            return this.name;
        }

        public Object Clone()
        {
            throw new CloneNotSupportedException();
        }

    }
}
