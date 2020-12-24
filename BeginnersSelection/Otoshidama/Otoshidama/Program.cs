using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otoshidama
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int Y = int.Parse(input[1]);

            int x = -1;
            int y = -1;
            int z = -1;

            for(int i=0;i<=N;i++)
            {
                for(int j=0;j<=N-i;j++)
                {
                   int k = N - i - j;
                   int total = 10000 * i + 5000 * j + 1000 * k;
                   if (total==Y)
                    {
                        x = i;
                        y = j;
                        z = k;

                      
                    }

                }
            }

            Console.WriteLine($"{x} {y} {z}");
        }
    }
}
