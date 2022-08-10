using System;

namespace BirthDayNotifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Mohammad";
            p.LastName = "Fallahi";
            p.BirthDay = new BirthDay()
            {
                Day = 16,
                Month = 5,
                Year = 1371
            };
            Console.WriteLine(
                $"{p.FirstName} {p.LastName} dar tarikhe {p.BirthDay.Year} - {p.BirthDay.Month} - {p.BirthDay.Day} chashm be jahan goshood.");
        }
    }
}
