using System;

namespace ABC157A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if(N%2==0)
            {
                Console.WriteLine(N / 2);
            }
            else
            {
                Console.WriteLine(N / 2 + 1);
            }
        }
    }
}
