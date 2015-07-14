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
            int[] Array = { 1, 2, 3, 4, 6, 12, 10, 11, 9, 21 };
            Console.WriteLine("The numbers of the current array are: 1, 2, 3, 4, 6, 12, 10, 11, 9, 21");
            Console.WriteLine("Please type one of the numbers:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == n)
            Console.WriteLine("The index of the number in this array is: " + i);
            }
        }
    }
}
