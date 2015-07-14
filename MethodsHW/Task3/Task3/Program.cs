using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the number b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the number c = ");
            int c = int.Parse(Console.ReadLine());
            int result1 = Multiplication(a, b, c);
            Console.Write("The result of multiplication is:");
            Console.WriteLine(result1);
        }

        private static int Multiplication(int num1, int num2, int num3)
        {
            int result = num1 * num2 * num3;
            return result;
        }
    }
}
