using System;

/// <summary>matrixmath</summary>
class MatrixMath
{
    /// <summary>multis 2 matrices</summary>
    /// <param name="matrix1">1st mtx</param>
    /// <param name="matrix2">2nd mtx</param>
    /// <returns>post-process mtx</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2){
        if (matrix1.Length == 0 ||
            matrix2.Length == 0 ||
            matrix1.GetLength(1) != matrix2.GetLength(0)){
            return (new double[,]{{-1}});
        }
        var res = new double[matrix1.GetLength(0),matrix2.GetLength(1)];
        double sum = 0.0;
        for (int y = 0; y < matrix1.GetLength(0); y++){
            for (int x2 = 0; x2 < matrix2.GetLength(1); x2++){
                sum = 0;
                for (int x = 0; x < matrix1.GetLength(1); x++){
                    sum += matrix1[y,x] * matrix2[x, x2];
                }
                res[y, x2] = sum;
            }
        }
        return res;  
    }
}
