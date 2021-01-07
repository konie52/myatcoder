using System;

namespace ABC085A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();

            for(int i=0;i<array.Length;i++)
            {
                if(i==3)
                {
                    array[i] = '8';
                }
                Console.Write(array[i]);
            }
        }
    }
}
