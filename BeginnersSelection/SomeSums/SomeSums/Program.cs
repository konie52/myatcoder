using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, A, B;
            string[] input = Console.ReadLine().Split(' ');

            N = int.Parse(input[0]);
            A = int.Parse(input[1]);
            B = int.Parse(input[2]);

            int ans = 0;
            
            for(int i=1;i<=N;i++)
            {
                int sum = 0;
                int num = i;
                while(num>0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if(sum>=A&&sum<=B)
                {
                    ans += i;
                }
            }

            Console.WriteLine(ans);
        }
    }
}
