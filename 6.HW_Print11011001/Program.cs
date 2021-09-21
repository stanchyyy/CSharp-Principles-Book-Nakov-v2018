using System;
using System.Collections.Generic;

namespace _6.HW_Print11011001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 7: Write program that prints the numbers 1,101,1001 each on new line.
            int maxNumber = 1001;
            int multiplyer = 10;
            int one = 1;
            Console.WriteLine(one);
            do
            {

                multiplyer *= 10;
                Console.WriteLine(one + multiplyer);
            }
            while (one + multiplyer < maxNumber);

        }
    }
}
