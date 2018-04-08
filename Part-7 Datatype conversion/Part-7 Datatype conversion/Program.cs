using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_Datatype_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float j = i;
            Console.WriteLine("The value of float is ", j);

            //testing for float
            float a = 10.223F;
            int b = Convert.ToInt32(a);
            Console.WriteLine("this is float value {0}",b);

            //explicit conversion for string
            string num = "110DB";
            //int c = int.Parse(num);
            //incase of the incorrect formate we use tryparse
            int result;
            bool isConversionSuccessful = int.TryParse(num, out result);
            if (isConversionSuccessful)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadKey();


        }
    }
}

