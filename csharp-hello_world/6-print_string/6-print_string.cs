using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        Console.WriteLine($"{str}{str}{str}");
        Console.WriteLine($"{str.Substring(0, 9)}");
    }
}
