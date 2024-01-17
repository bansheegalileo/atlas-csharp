using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>represents class obj</summary>
class Obj
{
    /// <summary> prints names and properties of an obj</summary>
    /// <param name="myObj">object to get info from</param>
    public static void Print(object myObj){
        string cType = myObj.GetType().Name;
        Type t = myObj.GetType();
        Console.WriteLine("{0} Properties:", cType);
        foreach (var p in t.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", cType);
        foreach (var m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}
