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
            int day = (int)WeekDays.Friday;
            Console.WriteLine(day);
            
        }
    }
}
