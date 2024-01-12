using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> multipliedDict = new Dictionary<string, int>();

        foreach (var kvp in myDict)
        {
            multipliedDict[kvp.Key] = kvp.Value * 2;
        }

        return multipliedDict;
    }
}
