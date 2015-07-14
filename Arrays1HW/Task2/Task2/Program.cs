using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];
            Array[0] = 1;
            Array[1] = 1;

            for (int i = 2; i < Array.Length; i++)
            {
                Array[i] = Array[i - 1] +  Array[i - 2];

            }
            foreach (int element in Array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
