using System;
/// <summary>queue</summary>
/// <typeparam name="T">any type</typeparam>
public class Queue<T>
{
    /// <summary>checks generic class type</summary>
    /// <returns>type</returns>
    public String CheckType(){
        return typeof(T).ToString();
    }

}
