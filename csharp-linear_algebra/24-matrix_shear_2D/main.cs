using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the Multiply method
        double[,] matrix1 = {
            {1, 2},
            {3, 4}
        };

        double[,] matrix2 = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nMatrix 2:");
        PrintMatrix(matrix2);

        double[,] productMatrix = MatrixMath.Multiply(matrix1, matrix2);

        Console.WriteLine("\nMatrix after multiplication:");
        PrintMatrix(productMatrix);

        // Test the Shear2D method
        double[,] originalMatrix = {
            {1, 2},
            {3, 4}
        };

        char shearDirection = 'x'; // Shear along the x-axis
        double shearFactor = 2;

        Console.WriteLine($"\nOriginal Matrix before shearing along {shearDirection}-axis:");
        PrintMatrix(originalMatrix);

        double[,] shearedMatrix = MatrixMath.Shear2D(originalMatrix, shearDirection, shearFactor);

        Console.WriteLine($"\nMatrix after shearing along {shearDirection}-axis with factor {shearFactor}:");
        PrintMatrix(shearedMatrix);
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
        Console.WriteLine();
    }
}
