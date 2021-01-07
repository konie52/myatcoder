using System;

namespace ABC187
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            int sumA;
            int sumB;

            int a1 = A % 10;//１の位
            int a10 = (A/10) % 10;//10の位
            int a100 = ((A/10)/10) % 10;//100の位

            sumA = a100 + a10 + a1;

            int b1 = B %10;
            int b10 = (B/10) % 10;
            int b100 = ((B/10)/10) % 10;
            
            

            sumB = b100 + b10 + b1;

            if(sumA>=sumB)
            {
                Console.WriteLine(sumA);
            }
            else
            {
                Console.WriteLine(sumB);
            }
           

        }
    }
}
