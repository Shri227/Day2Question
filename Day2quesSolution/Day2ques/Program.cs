using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ques
{
    class Program
    {
        static void Main(string[] args)
        {


            int a, b, i, j, flag;
  
            Console.WriteLine("Enter lower bound of the range: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter upper bound of the range: ");
            b = int.Parse(Console.ReadLine());

            for (i = a; i <= b; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                    Console.WriteLine(i);
            }


            Console.WriteLine("Name is Sneha K");

            Console.ReadKey();
        }
    }
}
