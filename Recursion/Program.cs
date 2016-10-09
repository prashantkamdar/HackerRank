using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            int factorialNumber = factorial(baseNumber);
            Console.WriteLine(factorialNumber);
            Console.ReadLine();
        }

        public static int factorial(int x)
        {
            int calc = 1;

            if (x > 1)
            {
                calc = x * factorial(x - 1);
            }

            return calc;
        }
    }
}
