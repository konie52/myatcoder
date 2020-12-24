using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KagamiMochi
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var input = new int[N];

            for(int i=0;i<N;i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(input[i]);
            }

        }
    }
}
