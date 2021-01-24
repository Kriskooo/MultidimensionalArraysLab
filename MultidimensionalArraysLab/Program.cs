using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int colums = matrixSize[1];

            int[,] matrix = new int[rows, colums];
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                    sum += input[col];
                }

            }
            Console.WriteLine(rows);
            Console.WriteLine(colums);
            Console.WriteLine(sum);
        }
    }
}
