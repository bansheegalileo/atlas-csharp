public class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = Math.Abs(number % 10);
        Console.WriteLine(lastDigit);
        return lastDigit;
    }
}
