using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{

    public enum EdgeTypeWithAttribute
    {
        [EdgeType("Normal arc", "NORMAL")]NORMAL,
        [EdgeType("Inhibitor arc", "INHIBITOR")]INHIBITOR,
        [EdgeType("Reset arc", "RESET")]RESET
    }

}
