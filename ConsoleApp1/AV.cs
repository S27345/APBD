using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AV
    {
        public static float getAverage(int[] intyy)
        {
            int sum = 0;

            for (int i = 0; i < intyy.Length; i++)
            {
                sum += intyy[i];
            }
            return sum / intyy.Length;
        }
    }
}
