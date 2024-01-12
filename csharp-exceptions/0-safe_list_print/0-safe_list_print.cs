using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        try
        {
            int count = 0;
            foreach (int item in myList)
            {
                if (count < n)
                {
                    Console.WriteLine(item);
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
        catch (Exception)
        {
            return 0;
        }
    }
}
