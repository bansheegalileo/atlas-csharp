using System;

class Program
{
    static void Main(string[] args)
    {
        for (int tens = 0; tens < 9; tens++)
        {
            for (int ones = tens + 1; ones < 10; ones++)
            {
                Console.Write($"{tens}{ones:D1}{(tens < 8 ? ", " : Environment.NewLine)}");
            }
        }
    }
}
