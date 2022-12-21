using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineComparisonProgram
    {
        public static void CalculateLine()
        {
            int x1 = 3;
            int y1 = 4;
            int x2 = 4;
            int y2 = 3;
            
            double lengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Lenth of Line is: " + lengthOfLine);
        }
    }
}
