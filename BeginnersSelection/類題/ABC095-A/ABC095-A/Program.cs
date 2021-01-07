using System;

namespace ABC095A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            int pay = 700;
            for(int i=0;i<3;i++)
            {
                if(array[i]== 'o')
                {
                    pay += 100;
                }
               
            }

         Console.WriteLine(pay);
        }
    }
}
