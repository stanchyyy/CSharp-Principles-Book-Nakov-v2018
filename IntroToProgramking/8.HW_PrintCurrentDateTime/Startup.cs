using System;

namespace _8.HW_PrintCurrentDateTime
{
    class Startup
    {
        static void Main(string[] args)
        {
            //Task:8. Write program that prints the cuurerent date and time;
            DateTime nowDateAndTime = DateTime.Now;
            Console.WriteLine(nowDateAndTime);
        }
    }
}
