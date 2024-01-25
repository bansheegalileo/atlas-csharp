using System;

/// <summary>matrixmath</summary>
class MatrixMath
{
    /// <summary>multiplies matrix and scalar</summary>
    /// <param name="matrix">mtx</param>
    /// <param name="scalar">multi number</param>
    /// <returns>post-multi mtx</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar){
        if (matrix.Length <= 1 ||
            matrix.GetLength(0) != matrix.GetLength(1)){
            return (new Double[,]{{-1}});
        }
        for (int y = 0; y < matrix.GetLength(0); y++){
            for (int x = 0; x < matrix.GetLength(1); x++){
                matrix[y,x] *= scalar;
            }
        }
        return matrix;
    }
}
