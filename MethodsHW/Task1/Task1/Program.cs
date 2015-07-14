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
            Console.Write("Please enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third number:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("The max number is:");
            Console.WriteLine(MaxNumber(MaxNumber(a, b), c));
        }

        private static int MaxNumber(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
    }
}
