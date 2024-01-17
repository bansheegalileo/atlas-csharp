using System;
using System.Collections.Generic;

/// <summary>class obj</summary>
class Obj
{
    /// <summary>checks if obj is type int</summary>
    /// <param name="obj">obj to check</param>
    /// <returns>true if int false if not</returns>
    public static bool IsOfTypeInt(object obj){
        if (obj.GetType() == typeof(int)){
            return true;
        }
        return false;
    }
}