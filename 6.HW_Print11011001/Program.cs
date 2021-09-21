using System;
using System.Collections.Generic;

namespace _6.HW_Print11011001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> { 1, 101, 1001 };
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
