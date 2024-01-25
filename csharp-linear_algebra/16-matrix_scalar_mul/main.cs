using System;

class Program
{
    static void Main()
    {
        // Create a sample matrix
        double[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Display the original matrix
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        // Define a scalar value
        double scalar = 2.5;

        // Multiply the matrix by the scalar
        double[,] resultMatrix = MatrixMath.MultiplyScalar(matrix, scalar);

        // Display the result matrix
        Console.WriteLine($"\nMatrix after multiplying by {scalar}:");
        PrintMatrix(resultMatrix);
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int y = 0; y < matrix.GetLength(0); y++)
        {
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
                Console.Write(matrix[y, x] + "\t");
            }
            Console.WriteLine();
        }
    }
}
