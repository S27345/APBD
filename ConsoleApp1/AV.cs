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
        public static float getAverage(int[] inty)
        {
            int sum = 0;

            for (int i = 0; i < inty.Length; i++)
            {
                sum += inty[i];
            }
            return sum / inty.Length;
        }
    }
}
