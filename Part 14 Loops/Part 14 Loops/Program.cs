using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_14_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // A coffee shopping application using loop

            string more;
            int totalPrice=0;
            do
            {
                Console.WriteLine("please select your choice");
                Console.WriteLine("1-Large\n2-Medium\n3-Small");
                int value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        totalPrice = totalPrice + 100;
                        break;
                    case 2:
                        totalPrice = totalPrice + 80;
                        break;
                    case 3:
                        totalPrice = totalPrice + 50;
                        break;
                    default:
                        Console.WriteLine("Your input is invalid");
                        break;
                }
                Console.WriteLine("If you want to purchase more coffee type YES Or type NO");
                more = Console.ReadLine().ToUpper();
                switch (more)
                {
                    case "YES":
                        more = "YES";
                        break;
                    case "NO":
                        more = "NO";
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                        break;
                }
            } while (more=="YES");
            Console.WriteLine("Your total amount is {0}", totalPrice);
            Console.ReadKey();
        }
    }
}
