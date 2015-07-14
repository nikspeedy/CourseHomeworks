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
            Console.WriteLine ("Please enter number -a- and number -b-.The result will show you all the numbers from -a- to -b- that partition of 3");
            Console.WriteLine("a =   ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b =   ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
