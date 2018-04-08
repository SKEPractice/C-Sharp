using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_11___Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int userNumber = int.Parse(Console.ReadLine());
            switch (userNumber)
            {
                //binding all the cases
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("User input is {0}", userNumber);
                    break;
                default:
                    Console.WriteLine("No any case matches");
                    break;
            }
            Console.ReadKey();
        }
    }
}
