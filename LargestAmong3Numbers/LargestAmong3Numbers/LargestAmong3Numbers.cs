using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LargestAmong3Numbers
{
    internal class LargestAmong3Numbers
    {
        public static void DisplayLargestAmong3Numbers() 
        {
            int num1, num2, num3;

            Console.WriteLine("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("{0} is the largest number.", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("{0} is the largest number.", num2);
            }
            else
            {
                Console.WriteLine("{0} is the largest number.", num3);
            }
        }
    }
}
