    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            double y = 4.0d;
            double ss = 4.0d;
            string z = "";

            //x = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToDouble(Console.ReadLine());
            //z = Console.ReadLine();

            Console.WriteLine(x);
            Console.WriteLine((ss+y).ToString("0.0###"));
            Console.WriteLine(z);
        }
    }
}