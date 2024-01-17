using System;

namespace Text
{
    /// <summary>str class</summary>
    public class Str
    {
        /// <summary>checks index of first non repeating char in str</summary>
        /// <param name="s">str to check</param>
        /// <returns>returns index of the first non repeating char of str</returns>

        public static int UniqueChar(string s)
        {
            if (s == null || s.Length == 0)
            {
                return -1;
            }

            int l = s.Length;
            int[] oct = new int[256]; // Assuming ASCII characters

            for (int silly = 0; silly < l; silly++)
            {
                oct[s[silly]]++;
            }

            for (int silly = 0; silly < l; silly++)
            {
                if (oct[s[silly]] == 1)
                {
                    return silly;
                }
            }

            return -1;
        }
    }
}
