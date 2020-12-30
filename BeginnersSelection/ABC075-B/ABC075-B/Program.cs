using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC075_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //H,Wの入力
            string[] input = Console.ReadLine().Split(' ');
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);

            //２次配列の定義
            string[,] Map = new string[H, W];

            //８方向調査のための配列（順番はどうでもOK)
            int[] dy = new int[8] { 1, 0, -1, 0, 1, -1, -1, 1 };
            int[] dx=new int[8] { 0, 1, 0, -1, 1, 1, -1, -1 };
            

            for(int i=0;i<H;i++)
            {
                //各行ごとに文字列を読み込む
                string[] S = Console.ReadLine().Split(' ');

                for(int j=0;j<W;j++)
                {
                    //各列の文字を二次配列に格納
                    Map[i, j] = S[j];

                    if(Map[i,j]=="#")
                    {
                        continue;
                    }

                    //"."だった時に計算
                    else
                    {
                        int num = 0;

                        //８方向調べて"#"があったら+1
                        for(int d=0;d<8;d++)
                        {
                            int ni = i + dy[d];
                            int nj = j + dx[d];

                            if(ni<0||H<ni)
                            {
                                continue;
                            }
                            else if(nj<0||W<nj)
                            {
                                continue;
                            }
                            else if(Map[ni,nj] =="#")
                            {
                                num += 1;
                            }
                        }
                        Map[i, j] = num.ToString();
                    }

                    Console.WriteLine(Map[i, j]);
                }
            }
        }
    }
}
