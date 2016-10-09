using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofLines = Convert.ToInt32(Console.ReadLine());
            string[] lineStrings = new string[numberofLines];

            for (int i = 0; i < numberofLines; i++)
            {
                lineStrings[i]  = Console.ReadLine();
            }

            foreach (string s in lineStrings)
            {
                var evens = s.Where((item, index) => index % 2 == 0).ToArray();
                var odds = s.Where((item, index) => index % 2 != 0).ToArray();

                Console.WriteLine($"{new string(evens)} {new string(odds)}");
            }
        }
    }
}
