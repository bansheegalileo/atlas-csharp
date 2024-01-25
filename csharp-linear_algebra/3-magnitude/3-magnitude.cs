using System;

/// <summary>vectormath</summary>
class VectorMath
{
    /// <summary>calculates and returns length of given vector</summary>
    /// <param name="vector">vector</param>
    /// <returns>length rounded to nearest 100th</returns>
    public static double Magnitude(double[] vector){
        if (vector.Length != 3 && vector.Length != 2){
            return (-1);
        }
        double sum = 0;
        foreach (var elem in vector){
            sum += elem * elem;
        }
        return System.Math.Round(System.Math.Sqrt(sum), 2);
    }
}
