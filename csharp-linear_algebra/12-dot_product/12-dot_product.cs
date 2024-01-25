using System;

/// <summary>vectormath</summary>
class VectorMath
{
    /// <summary>calcs dot product of 2 vcts</summary>
    /// <param name="vector1">1st vct</param>
    /// <param name="vector2">2nd vct</param>
    /// <returns>dot product of 2 vcts</returns>
    public static double DotProduct(double[] vector1, double[] vector2){
        if (vector1.Length != vector2.Length ||
            vector1.Length != 3 && vector1.Length != 2 || 
            vector2.Length != 3 && vector2.Length != 2){
                return (-1);
        }
        double sum = 0;
        for (int x = 0; x < vector1.Length; x++){
            sum += vector1[x] * vector2[x];
        }
        return sum;
    }
}
