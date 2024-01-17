using System;

namespace Text
{
     /// <summary>str class</summary>
    public class Str
    {
        /// <summary>how many words are in a str</summary>
        /// <param name="s">str2check.</param>
        /// <returns>number of words in s</returns>
    public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int wc = 0;

            foreach (var character in s)
            {
                if (char.IsUpper(character))
                {
                    wc++;
                }
            }

            return wc;
        }
    }
}
