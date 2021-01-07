using System;

namespace ABC187B
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            float[] X = new float[1000];
            float[] Y = new float[1000];
            int num = 0;
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                X[i] = float.Parse(input[0]);
                Y[i] = float.Parse(input[1]);
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                    {
                        float k = (Y[j] - Y[i]) / (X[j] - X[i]);
                        if (-1.0 <= k && k <= 1.0)
                        {
                            num += 1;
                        }

                    }
                }
            }



            Console.WriteLine(num / 2);
        }
    }
}
