﻿using System;
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
            Console.WriteLine("Enter x1 ");
            double x1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x3 ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x4 ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y3 ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y4 ");
            double y4 = Convert.ToDouble(Console.ReadLine());


            double lengthOfLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double lengthOfLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            bool status=lengthOfLine1.Equals(lengthOfLine2);
            if (status)
            {
                Console.WriteLine("{0} is equal to {1}", lengthOfLine1, lengthOfLine2);
            }
            else
            {
                Console.WriteLine("{0} is not equal to {1}", lengthOfLine1, lengthOfLine2);
            }
        }

    }
}
