using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
             int[,] matrix = 
            {
                {12, 8, 21, 65, 3},
                {13, 7, 10, 56, 31},
                {99, 23, 55, 33, 98}
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
             for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {

                        Console.WriteLine(matrix[i, j]);
                    }
             }
             }
        }
    }
}
