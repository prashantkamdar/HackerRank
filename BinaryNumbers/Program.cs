using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(n, 2);

            string[] oneStrings = binary.Split('0');

            string longest = oneStrings.OrderByDescending(x => x.Length).First();
            Console.WriteLine(longest.Length);
        }
    }
}