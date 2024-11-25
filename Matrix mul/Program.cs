using System;

class Proram
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of the matrix: ");
        int matrix = Convert.ToInt32(Console.ReadLine());

        int[,]matrix1 = new int [matrix, matrix];
        int[,]matrix2 = new int [matrix, matrix];
        int[,] output = new int[matrix, matrix];

        Console.WriteLine("\nEnter elements of the matrix: ");
        for (int i = 0; i < matrix; i++)
        {
            for (int j = 0; j < matrix; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nEnter elements of the matrix; ");
        for (int i = 0; i < matrix; i++)
        {
            for (int j = 0; j < matrix; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for(int i = 0; i < matrix; i++)
        {
            for (int j = 0;j < matrix; j++)
            {
                for(int k = 0; k < matrix; k++)
                {
                    output[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        Console.WriteLine("\nResult:");
        for (int i = 0;i < matrix; i++)
        {
            for (int j = 0; j < matrix; j++)
            {
                Console.Write($"{output[i, j]} ");

            }
            Console.WriteLine();
        }

    }
}
