using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>(myDict.Keys);
        keys.Sort();

        foreach (var key in keys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
