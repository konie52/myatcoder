using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数配列の入力
            string[] str = Console.ReadLine().Split(' ');


            var a = int.Parse(str[0]);
            var b = int.Parse(str[1]);


            if ((a*b)%2==0)
            {
                Console.WriteLine("Even");
            }

            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
