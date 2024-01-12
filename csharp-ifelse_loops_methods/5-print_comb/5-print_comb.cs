using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 0; number < 100; number++)
        {
            Console.Write($"{number:D2}");

            if (number < 99)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}
