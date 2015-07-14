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
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            NumIsEvenIsOdd(num);
        }
         static  void NumIsEvenIsOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}
