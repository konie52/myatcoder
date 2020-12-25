using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC075_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);

            string[,] math = new string[H, W];
            for(int i=1;i<=H;i++)
            {
                string[,] Si = new string[1, W];
                Si = Console.ReadLine().Split(' ');
                for(int j=1;j<=W;j++)
                {

                }
            }
        }
    }
}
