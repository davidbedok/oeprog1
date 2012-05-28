using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{
    [System.AttributeUsage(System.AttributeTargets.Field)]
    public sealed class EdgeTypeAttribute : Attribute
    {
        private readonly string name;
        private readonly string value;

        public string Name
        {
            get { return this.name; }
        }

        public string Value
        {
            get { return this.value; }
        }

        public EdgeTypeAttribute(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
