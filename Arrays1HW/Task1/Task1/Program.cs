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
            int[] Array = { 1, 6, 9, 12, 22, 7 };
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                    sum = Array[i] + sum;
            }
            Console.WriteLine(sum);
        }
    }
}
