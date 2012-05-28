using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace EnumDemo
{
    public class CustomHelpers
    {

        public static EdgeTypeAttribute getAttribute(EdgeTypeWithAttribute edgeTyoe)
        {
            return (EdgeTypeAttribute)Attribute.GetCustomAttribute(ForValue(edgeTyoe), typeof(EdgeTypeAttribute));
        }

        public static MemberInfo ForValue(EdgeTypeWithAttribute edgeType)
        {
            return typeof(EdgeTypeWithAttribute).GetField(Enum.GetName(typeof(EdgeTypeWithAttribute), edgeType));
        }

    }
}
