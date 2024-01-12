using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        try
        {
            for (int i = 0; i < listLength; i++)
            {
                int value1 = i < list1.Count ? list1[i] : 0;
                int value2 = i < list2.Count ? list2[i] : 0;

                if (value2 == 0)
                {
                    throw new DivideByZeroException();
                }

                result.Add(value1 / value2);
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            result.Clear();
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range");
            result.Clear();
        }

        return result;
    }
}
