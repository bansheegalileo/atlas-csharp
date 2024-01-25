using System;

/// <summary>matrixmath</summary>
class MatrixMath
{
    /// <summary>calcs determ. of 2d matrix</summary>
    /// <param name="matrix">mtx</param>
    /// <returns>determinant</returns>
    public static double Determinant2D(double[,] matrix){
        return (Math.Round((matrix[0,0] * matrix[1,1]) - (matrix[0,1] * matrix[1, 0]), 2));
    }
    /// <summary>calcs determ. of matrix</summary>
    /// <param name="matrix">mtx</param>
    /// <returns>determinant</returns>
    public static double Determinant(double[,] matrix){
        if (matrix.GetLength(1) > 3 || 
            matrix.GetLength(1) != matrix.GetLength(0)){
            return (-1);
        }
        if (matrix.GetLength(1) == 2){
            return (Determinant2D(matrix));
        }
        var matrixA = new Double[,]{{matrix[1,1], matrix[1,2]},{matrix[2,1], matrix[2,2]}};
        var matrixB = new Double[,]{{matrix[1,0], matrix[1,2]},{matrix[2,0], matrix[2,2]}};
        var matrixC = new Double[,]{{matrix[1,0], matrix[1,1]},{matrix[2,0], matrix[2,1]}};
        var res = ((matrix[0,0] * Determinant2D(matrixA)) - (matrix[0,1] * Determinant2D(matrixB))) + matrix[0,2] * Determinant2D(matrixC);
        return Math.Round(res, 2);
    }
}
