using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = 0.7553;
        double currency = 98765.4321;
        Console.WriteLine("Percent: {0:P2} tip", percent);
        Console.WriteLine("Currency: {0:C}", currency);
    }
}
