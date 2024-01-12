using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);

        int lastDigit = Math.Abs(number) % 10 * (Math.Sign(number));

        Console.Write($"The last digit of {number} is {lastDigit} and ");

        if (lastDigit > 5)
        {
            Console.WriteLine($"is greater than 5");
        }
        else if (lastDigit == 0)
        {
            Console.WriteLine($"is 0");
        }
        else
        {
            Console.WriteLine($"is less than 6 and not 0");
        }
    }
}
