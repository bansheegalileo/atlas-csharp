using System;

class Program
{
    static void Main(string[] args)
    {
        string alphabet = "";

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (letter != 'q' && letter != 'e')
                alphabet += letter;
        }

        Console.Write(alphabet + "\n");
    }
}
