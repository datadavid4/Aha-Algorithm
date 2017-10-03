using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    class Program
    {
        //這邊不採用陣列0，方便檢測
        static int[] ans = new int[10];
        static int[] book = new int[10];
        static int n;
        static void Main(string[] args)
        {
            Console.WriteLine("數的全排列，輸入1~9");

            n = int.Parse(Console.ReadLine());

            dfs(1); // 從第一個開始
            
            Console.Read();
        }

        // step代表在第幾個
        static void dfs(int step)
        {
            // 代表以達最大搜索範圍，印出結果，結束這個節點的遞迴
            if (step == n + 1)
            {
                for (int i = 1; i <= n; i++)
                    Console.Write(ans[i]);
                Console.Write("\n");
                return;
            }

            // i 即為我們要填入的值，可用查表等方式替換
            for (int i = 1; i <= n; i++)
            {
                // 判斷 i 這個數字是否被使用過
                if (book[i] == 0)
                {
                    ans[step] = i;

                    book[i] = 1;
                    dfs(step + 1);
                    book[i] = 0;
                }
            }
            return;
        }
    }
}
