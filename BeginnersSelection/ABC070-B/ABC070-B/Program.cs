using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC070_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //入力
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);
            int D = int.Parse(input[3]);

            //重なり方によって６つに場合分け

            if(B<=C)
            {
                Console.WriteLine(0);
            }
            else if(A<=C && C<B && B<=D)
            {
                Console.WriteLine(B - C);
            }
            else if(A<=C && D<B)
            {
                Console.WriteLine(D - C);
            }
            else if(C<=A && A<D && D<=B)
            {
                Console.WriteLine(D - A);
            }
            else if(D<A)
            {
                Console.WriteLine(0);
            }
            else if(C<=A && B<=D)
            {
                Console.WriteLine(B - A);
            }
        }
    }
}
