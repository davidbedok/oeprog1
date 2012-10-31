using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOInto
{
    public class Hair
    {

        private HairType type;
        private String color;

        public Hair(HairType type)
        {
            this.type = type;
        }

        public HairType getType()
        {
            return this.type;
        }

        public void setType(HairType type)
        {
            this.type = type;
        }

        public String getColor()
        {
            return this.color;
        }

        public void setColor(String color)
        {
            this.color = color;
        }

        /*
        public override String ToString()
        {
            return (this.color != null ? this.color + " and " : "") + this.type;
        }*/

    }
}
