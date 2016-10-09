using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[] endHeight = new int[t];
            int tempHeight = 1;

            for (int a0 = 0; a0 < t; a0++)
            {
                tempHeight = 1;

                int n = Convert.ToInt32(Console.ReadLine());

                for (int x = 0+2; x < n+2; x++)
                {
                    if (x % 2 == 0)
                    {
                        tempHeight = tempHeight * 2;
                    }
                    else
                    {
                        tempHeight++;
                    }
                }

                endHeight[a0] = tempHeight;
            }

            foreach (var height in endHeight)
            {
                Console.WriteLine(height);
            }
        }
    }
}
