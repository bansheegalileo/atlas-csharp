using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 0; number < 100; number++)
        {
            Console.Write($"{number:D2}{(number < 99 ? ", " : Environment.NewLine)}");
        }
    }
}
