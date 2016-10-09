using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            double tip = Convert.ToDouble(Console.ReadLine());
            double tax = Convert.ToDouble(Console.ReadLine());

            tip = mealCost * tip / 100;
            tax = mealCost * tax / 100;

            mealCost = mealCost + tip + tax;
            mealCost = Math.Round(mealCost);

            Console.WriteLine($"The total meal cost is {mealCost} dollars." );

            Console.ReadLine();
        }
    }
}
