using System;

namespace EnumConversion
{
    class Program
    {
        //create a enum
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            //convert day to int
            int dayNum = (int)WeekDays.Friday;
            Console.WriteLine(dayNum);

            // Convert int to day
            var day = (WeekDays) 6;
            Console.WriteLine(day);
            
        }
    }
}
