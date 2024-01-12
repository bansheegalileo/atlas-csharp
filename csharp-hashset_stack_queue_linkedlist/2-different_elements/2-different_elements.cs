using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);

        List<int> differentElements = new List<int>();

        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                differentElements.Add(num);
            }
        }

        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                differentElements.Add(num);
            }
        }

        differentElements.Sort();

        return differentElements;
    }
}
