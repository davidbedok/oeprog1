using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{
    public abstract class CustomEnum : ICloneable
    {

        protected readonly string name;
        protected readonly string value;

        public string Name
        {
            get { return this.name; }
        }

        public string Value
        {
            get { return this.value; }
        }

        protected CustomEnum(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public override string ToString()
        {
            return this.name;
        }

        public object Clone()
        {
            throw new CloneNotSupportedException();
        }

    }
}
