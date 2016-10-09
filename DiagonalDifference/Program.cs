using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];

            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int reverse = 0;
            int straight = 0;

            for (int x = 0; x < n; x++)
            {
                reverse = reverse + a[x][n - x - 1];
                straight = straight + a[x][x];
            }

            Console.WriteLine(Math.Abs(straight-reverse));
        }
    }
}