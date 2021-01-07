using System;

namespace ABC069B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();

            Console.WriteLine("{0}{1}{2}",array[0],array.Length-2,array[array.Length-1]);
        }
    }
}
