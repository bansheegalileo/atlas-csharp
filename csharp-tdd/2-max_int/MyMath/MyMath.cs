using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>ops class</summary>
    public class Operations
    {
        /// <summary>gets max int </summary>
        /// <param name="nums">int list</param>
        /// <returns>max int in list</returns>
        public static int Max(List<int> nums){
            int max = 0;
            try{
                max = nums[0];
            }
            catch{
                return 0;
            }
            foreach(var elem in nums)
                max = elem > max ? elem : max;
            return max;
        }
    }
}
