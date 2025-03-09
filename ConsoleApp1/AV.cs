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
        public static float getAverage(int[] intss)
        {
            int sum = 0;

            for (int i = 0; i < intss.Length; i++)
            {
                sum += intss[i];
            }
            return sum / intss.Length;
        }
    }
}
