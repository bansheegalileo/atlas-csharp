using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 0; number <= 98; number++)
        {
            Console.Write($"{number} = 0x{number:X}\n");
        }
    }
}
