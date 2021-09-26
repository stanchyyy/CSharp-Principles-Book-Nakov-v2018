using System;

namespace _11.HW_ConsoleWriteLineAngeAndAgeAfter10Years
{
    class Startup
    {
        static void Main(string[] args)
        {
            //Task 11: Write program that will read from the console your age annd will also print in the console your age after 10 years;
            int addYears = 10;
            Console.WriteLine("Enter your current age:");
            int currentAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Age after 10 years {  currentAge + addYears}");
        }
    }
}
