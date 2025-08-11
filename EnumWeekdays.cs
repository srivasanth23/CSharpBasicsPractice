using System;

//Defining an enum for weekdays
enum Weekday
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

namespace CSharpBasicsPractice
{
    class EnumWeekdays
    {
        public void DisplayToday(Weekday today)
        {
            // Using enum in switch statement
            switch (today)
            {
                case Weekday.Sunday:
                    Console.WriteLine("It's Sunday");
                    break;
                case Weekday.Monday:
                    Console.WriteLine("It's Monday.");
                    break;
                case Weekday.Tuesday:
                    Console.WriteLine("It's Tuesday.");
                    break;
                case Weekday.Wednesday:
                    Console.WriteLine("It's Wednesday.");
                    break;
                case Weekday.Thursday:
                    Console.WriteLine("It's Thursday.");
                    break;
                case Weekday.Friday:
                    Console.WriteLine("It's Friday.");
                    break;
                case Weekday.Saturday:
                    Console.WriteLine("It's Saturday.");
                    break;
            }
        }
    }
}
