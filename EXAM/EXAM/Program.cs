using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter random 9 numbers from 2 to 9");
            int n = int.Parse(Console.ReadLine());
            int[,] array1 = new int[n,n];

           for (int i = 0; i < array1.GetLength(0);i++)
			{
			 for (int j = 0; j < array1.GetLength(1); j++)
			{
                 array1 [i,j] = int.Parse(Console.ReadLine());
			}
			}
            int counter = 0;
            int[]array2 = new int[n*n];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array2[counter++] = array1[j, i];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}
