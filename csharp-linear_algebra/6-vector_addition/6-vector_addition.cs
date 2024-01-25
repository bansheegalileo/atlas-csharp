using System;

/// <summary>vectormath</summary>
class VectorMath
{
    /// <summary>adds 2 vectors</summary>
    /// <param name="vector1">vct a</param>
    /// <param name="vector2">vct b</param>
    /// <returns>a+b sum</returns>
    public static double[] Add(double[] vector1, double[] vector2){
        if (vector1.Length != vector2.Length ||
            vector1.Length != 3 && vector1.Length != 2 || 
            vector2.Length != 3 && vector2.Length != 2){
                return (new Double[1]{-1});
        }
        var sum = new Double[3];
        for (int i = 0; i < vector1.Length; i++){
            sum[i] = vector1[i] + vector2[i];
        }
        return sum;
    }
}
