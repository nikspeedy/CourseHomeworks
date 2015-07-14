using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a card");
            string card =(Console.ReadLine());
            switch (card)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "j":
                case "Q":
                case "q":
                case "K":
                case "k":
                case "A":
                case "a":
                    Console.WriteLine("Valid card!");
                    break;
                default:
                    Console.WriteLine("Invalid card!");
                    break;
            }
        }
    }
}
