using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Learn.Abstract
{
    internal class ShapeMath
    {
        public static double GetArea(string shape = "", double lenght1 = 0, double lenght2 = 0)
        {
            if (string.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return lenght1 * lenght2;
            }
            else if (string.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return lenght1 * lenght2;
            }
            else if (string.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14 * Math.Pow(lenght1, 2);
            }
            else
            {
                return -1;
            }
        }
    }
}
