using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b, c, x;

            a = int.Parse(Console.ReadLine()); 
            b = int.Parse(Console.ReadLine()); 
            c = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());

            int ans = 0;

            for(int i=0;i<=a;i++)
            {
               for(int j=0;j<=b;j++)
                {
                    for(int k=0;k<=c;k++)
                    {
                        if(500*i+100*j+50*k==x)
                        {
                            ans += 1;
                        }
                    }
                }
            }

            Console.WriteLine(ans);
        }
    }
}
