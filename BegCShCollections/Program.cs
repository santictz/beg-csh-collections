using System;

namespace BegCShCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize an array if you know the exact size of it
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //Best way to iterate arrays
            //foreach (string day in daysOfWeek)
            //{
            //    Console.WriteLine(day);
            //}
             
            Console.WriteLine("Which day do you want to display?");
            Console.WriteLine("(Monday = 1, etc.)");
            int iDay = int.Parse(Console.ReadLine());
            //Arrays are 0 index
            string chosenDay = daysOfWeek[iDay-1];
            Console.WriteLine($"The day is {chosenDay}");
        }
    }
}
