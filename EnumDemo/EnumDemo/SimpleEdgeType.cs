using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{

    public enum SimpleEdgeType /* : int */
    {
        NORMAL = -1,
        INHIBITOR,
        RESET
    }

    public enum SimpleUnsignedEdgeType : uint
    {
        NORMAL,
        INHIBITOR,
        RESET
    }

}
