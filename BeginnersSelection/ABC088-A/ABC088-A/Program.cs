using System;

namespace ABC088A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            int amari = N % 500;

            if(amari<=A)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
