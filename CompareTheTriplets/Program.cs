using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int alicePoints = 0;
            int bobPoints = 0;

            string aliceTriplet = Console.ReadLine();
            string bobTriplet = Console.ReadLine();

            string[] aliceSet = aliceTriplet.Split(' ');
            string[] bobSet = bobTriplet.Split(' ');

            for (int i = 0; i < 3; i++)
            {
                if (Convert.ToInt32(aliceSet[i]) > Convert.ToInt32(bobSet[i]))
                {
                    alicePoints++;
                }
                else if (Convert.ToInt32(aliceSet[i]) < Convert.ToInt32(bobSet[i]))
                {
                    bobPoints++;
                }
            }

            Console.WriteLine(alicePoints + " " + bobPoints);
        }
    }
}
