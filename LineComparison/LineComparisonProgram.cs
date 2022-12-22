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
            double[] arr1 = new double[4];
            for(int i = 0;i< arr1.Length;i++) 
            {
                Console.WriteLine("Enter value for x"+ (i + 1) +"= ");
                arr1[i]=Convert.ToDouble(Console.ReadLine());
            }

            double[] arr2 = new double[4];
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("Enter value for y" + (i + 1) + "= ");
                arr2[i] = Convert.ToDouble(Console.ReadLine());
            }

            double x1 = arr1[0], x2 = arr1[1], x3 = arr1[2], x4 = arr1[3];
            double y1 = arr2[0], y2 = arr2[1], y3 = arr2[2], y4 = arr2[3];

            double lengthOfLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double lengthOfLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            int status=lengthOfLine1.CompareTo(lengthOfLine2);
            if (status == 0)
            {
                Console.WriteLine("{0} is equal to {1}", lengthOfLine1, lengthOfLine2);
            }
            else if(status > 0)
            {
                Console.WriteLine("{0} is greater than to {1}", lengthOfLine1, lengthOfLine2);
            }
            else if(status < 0)
            {
                Console.WriteLine("{0} is less than to {1}", lengthOfLine1, lengthOfLine2);
            }
        }

    }
}
