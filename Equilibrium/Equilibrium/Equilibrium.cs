using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equilibrium
{
    public class Equilibrium
    {
        public static int equilibrium(int[] arr)
        {
            int ret = -1;
            int n = arr.Length;
            int leftsum = 0;
            int rightsum = 0;
            int sum = 0;
            int i;
            for (i = 0; i < n; ++i)
            {
                sum += arr[i];
            }
            i = 0;
            while ((i < n) && (ret == -1))
            {
                rightsum = sum - leftsum - arr[i];
                if (leftsum == rightsum)
                {
                    ret = i;
                }
                else
                {
                    leftsum += arr[i];
                    i++;
                }
            }
            return ret;
        }

        public static int equilibriumExpert(int[] arr)
        {
            int i;
            int sum = 0;
            for (i = 0; i < arr.Length; ++i)
            {
                sum += arr[i];
            }
            while (i-- > 0 && arr[i] != sum)
            {
                sum -= 2 * arr[i];
            }
            return i;
        }

    }
}
