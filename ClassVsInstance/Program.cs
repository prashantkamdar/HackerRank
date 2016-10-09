using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());

                Person p = new Person(age);

                p.amIOld();

                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }

                p.amIOld();

                Console.WriteLine();
            }
        }
    }

    class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                age = initialAge;
            }
        }

        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");   
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");

            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            age = age + 1;
        }
    }
}
