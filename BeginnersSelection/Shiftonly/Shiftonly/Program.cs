using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiftonly
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');
            int[] A = new int[210];
            int count = 0;

            for(int i=0;i<N;i++)
            {
                A[i] = int.Parse(input[i]);
            }

            do
            {
                for (int i = 0; i < N; i++)
                {
                    if (A[i] % 2 == 1)
                    {
                        Console.WriteLine("奇数だぜ");
                        break;
                    }
                    else
                    {
                        A[i] = A[i] / 2;
                        Console.WriteLine(A[i]);
                    }
                }
                count += 1;

            }
            while (true);
               
            Console.WriteLine(count);


        }
    }
}
