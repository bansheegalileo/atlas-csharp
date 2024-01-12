using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);
        int[,] resultMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }

        return resultMatrix;
    }

    static void Main()
    {
        int[,] originalMatrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] squaredMatrix = Square(originalMatrix);

        Console.WriteLine("Original Matrix:");
        PrintMatrix(originalMatrix);

        Console.WriteLine();

        Console.WriteLine("Squared Matrix:");
        PrintMatrix(squaredMatrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
