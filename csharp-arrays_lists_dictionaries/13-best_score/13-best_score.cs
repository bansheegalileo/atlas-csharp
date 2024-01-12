using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }

        string bestStudent = "";
        int bestScore = int.MinValue;

        foreach (var entry in myList)
        {
            if (entry.Value > bestScore)
            {
                bestStudent = entry.Key;
                bestScore = entry.Value;
            }
        }

        return bestStudent;
    }
}
