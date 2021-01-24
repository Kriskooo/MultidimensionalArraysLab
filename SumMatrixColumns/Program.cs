﻿using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowCow[0];
            int cols = rowCow[1];

            int sumOfColums = 0;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int cow = 0; cow < cols; cow++)
                {
                    matrix[row, cow] = input[cow];
                }
                for (int numCows = 0; numCows < matrix.GetLength(1); numCows++)
                {
                    for (int numRows = 0; numRows < matrix.GetLength(0); numRows++)
                    {
                        sumOfColums += matrix[numRows, numCows];
                    }
                    Console.WriteLine(sumOfColums);
                    sumOfColums = 0;

                }
            }
        }
    }
}