using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{

    public enum SimpleEdgeType /* : int */
    {
        NORMAL /* = -3 */,
        INHIBITOR,
        RESET
    }

    public enum SimpleEdgeType2 : uint
    {
        NORMAL,
        INHIBITOR,
        RESET
    }

}
