using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
             int[,] matrix = 
            {
                {1, 2, 3, 4, 5, 6},
                {7, 8, 9, 10, 11, 12},
                {13, 14, 15, 16, 17, 18,},
                {19, 20, 21, 22, 23, 24,},
                {25, 26, 27, 28, 29, 30}
            };
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] matrix2 = new int[rows,cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix2[rows - i - 1, cols - j - 1] = matrix[i, j];
                }
            }
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {

                    Console.Write(" " + matrix2[i, j]);

                }
                Console.WriteLine();
            }
        }
    }
}
