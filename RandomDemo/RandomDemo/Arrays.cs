using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomDemo
{
    public class Arrays
    {

        public static string toString(int[] data)
        {
            StringBuilder sb = new StringBuilder(50);
            sb.Append("[");
            if (data != null && data.Length > 0)
            {
                int i = 0;
                for (i = 0; i < data.Length - 1; i++)
                {
                    sb.Append(data[i]).Append(", ");
                }
                sb.Append(data[i]);
            }
            sb.Append("]");
            return sb.ToString();
        }

    }
}
