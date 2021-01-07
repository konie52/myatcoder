using System;

namespace ABC187C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] array = new string[200000];

            string ans = "satisfiable";

            for (int i = 0; i < N; i++)
            {
                array[i] = Console.ReadLine();
           
                for(int j=0;j<N;j++)
                {
                    array[j] = "!" + array[i];

                    if(array[i]==array[j])
                    {
                        ans = array[i];
                        Console.WriteLine(ans);
                        break;
                    }
                    
                }
               
            }
            Console.WriteLine(ans);
        }
    }
}
