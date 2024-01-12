using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueIntegers = new HashSet<int>(myList);

        int sum = 0;
        foreach (int uniqueNum in uniqueIntegers)
        {
            sum += uniqueNum;
        }

        return sum;
    }
}
