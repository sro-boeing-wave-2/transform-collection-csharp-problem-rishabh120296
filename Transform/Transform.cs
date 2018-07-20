using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static int[] Map(this int[] x, Func<int, int> map)
        {
            for (int i =0; i<x.Length; i++)
            {
                x[i] = map(x[i]);
            }
            return x;
        }
    }
}
