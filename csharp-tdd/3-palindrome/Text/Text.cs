using System;
using System.Text.RegularExpressions;
using System.Text; 

namespace Text
{
    /// <summary>str class</summary>
    public class Str
    {
        /// <summary>checks str for palindrome</summary>
        /// <param name="s">str 2 check</param>
        /// <returns>true if palindrome false if not</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
            {
                return false;
            }

            if (s.Length == 0)
            {
                return true;
            }

            int l = s.Length;
            StringBuilder rvrSbld = new StringBuilder(l);

            for (int i = l - 1; i >= 0; i--)
            {
                rvrSbld.Append(s[i]);
            }

            string rvrS = Regex.Replace(rvrSbld.ToString(), @"\W|_", string.Empty);
            s = Regex.Replace(s, @"\W|_", string.Empty);

            return rvrS.Equals(s, StringComparison.OrdinalIgnoreCase);
        }
    }
}
