using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacingMarbles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);
            
            int count= 0;

            if (a == 1) count += 1;
            if (b == 1) count += 1;
            if (c == 1) count += 1;
           
            Console.WriteLine(count);
        }
    }
}
