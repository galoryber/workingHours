using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        List<string> myStrings = new List<string>
        {
            "String 1",
            "String 2",
            "String 3",
            "String 4",
            "String 5"
        };

        foreach (string str in myStrings)
        {
            while (true)
            {
                if (IsWorkingTime())
                {
                    // Echo the string if it's working time
                    Console.WriteLine(str);
                    break; // Move to the next string in the list
                }
                else
                {
                    // Wait for a short interval before checking again
                    Thread.Sleep(60000); // Wait for 1 minute before checking again
                }
            }
        }
    }

    static bool IsWorkingTime()
    {
        DateTime now = DateTime.Now;

        // Check if the current day is between Monday (DayOfWeek.Monday) and Friday (DayOfWeek.Friday)
        bool isWeekday = now.DayOfWeek >= DayOfWeek.Monday && now.DayOfWeek <= DayOfWeek.Friday;

        // Check if the current time is between 8 AM and 5 PM
        bool isWorkingHours = now.TimeOfDay >= new TimeSpan(8, 0, 0) && now.TimeOfDay <= new TimeSpan(17, 0, 0);

        return isWeekday && isWorkingHours;
    }
}
