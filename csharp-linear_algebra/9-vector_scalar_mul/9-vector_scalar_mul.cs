using System;

/// <summary>vectormath</summary>
class VectorMath
{
    /// <summary>multiplies vector and scalar and returns processed vector</summary>
    /// <param name="vector">vct to multiply</param>
    /// <param name="scalar">multi number</param>
    /// <returns>resulting vct post-multi</returns>
    public static double[] Multiply(double[] vector, double scalar){
        if (vector.Length != 3 && vector.Length != 2){
                return (new Double[1]{-1});
        }
        var sum = new Double[vector.Length];
        for (int i = 0; i < vector.Length; i++){
            sum[i] = vector[i] * scalar;
        }
        return sum;
    }
}
