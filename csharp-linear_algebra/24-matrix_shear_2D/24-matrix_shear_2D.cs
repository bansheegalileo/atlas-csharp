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
    /// <summary>sheards 2d matrix by given shear factor</summary>
    /// <param name="matrix">mtx</param>
    /// <param name="direction">shear direction</param>
    /// <param name="factor">shear amt</param>
    /// <returns>sheared mtx</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor){
         if (matrix.Length == 0 ||
             matrix.GetLength(1) != 2 ||
            matrix.GetLength(1) != matrix.GetLength(0)){
            return (new double[,]{{-1}});
        }
        var s = new double[2,2];
        if (Char.ToLower(direction).Equals('x')){
           s = new double[2,2]{{1, factor},{0,1}};
        }
        else if (Char.ToLower(direction).Equals('y')){
           s = new double[2,2]{{1, 0},{factor,1}};
        }
        else{
            return (new double[,]{{-1}});
        }
        matrix = new Double[2,2]{{matrix[0,0], matrix[1,0]},{matrix[0,1], matrix[1,1]}};
        matrix = Multiply(s, matrix);
        matrix = new Double[2,2]{{matrix[0,0], matrix[1,0]},{matrix[0,1], matrix[1,1]}};
        return matrix;
    }
}
