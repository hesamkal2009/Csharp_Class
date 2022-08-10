using System;

public class Program
{
    public static void Main()
    {
        int number = 10;

        Console.WriteLine(number);
        Console.WriteLine(++number);

        Console.WriteLine("++++++++++++++++++++++++++++++++++");
        Console.WriteLine("++++++++++++++++++++++++++++++++++");
        Console.WriteLine("++++++++++++++++++++++++++++++++++");
        Console.WriteLine("++++++++++++++++++++++++++++++++++");

        number = 10;
        Console.WriteLine("Line 18:" + number++);
        Console.WriteLine("Line 19:" + number++);
    }
}