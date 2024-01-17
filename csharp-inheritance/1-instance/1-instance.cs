using System;
using System.Collections.Generic;

/// <summary>represents class obj</summary>
class Obj
{
    /// <summary>checks instance of obj</summary>
    /// <param name="obj">obj to check</param>
    /// <returns> if instance of or class inhr. of array true, otherwise false</returns>
    public static bool IsInstanceOfArray(object obj){
        if (obj.GetType() == typeof(Array) || obj is Array)
            return true;
        return false;
    }
}
