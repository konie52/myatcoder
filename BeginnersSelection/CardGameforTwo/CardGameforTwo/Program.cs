using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameforTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] A = new int[100];

            for(int i=0;i<N;i++)
            {
                A[i] = int.Parse(input[i]);
               
            }
            Array.Sort(A);
            Array.Reverse(A);

            int alice = 0;
            int bob = 0;

            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    alice += A[i];
                }
                else
                {
                    bob += A[i];
                }
            }
            Console.WriteLine(alice - bob);
        }
    }
}
