using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue\n");

            //手動設定資料
            string str = "6,3,1,7,5,8,9,2,4";
            string[] n_str = str.Split(',');

            //初始化佇列
            queue q;
            q.head = 0;
            q.tail = 0;
            q.data = new int[100];

            Console.WriteLine("Source");
            for (int i = 0; i < n_str.Length; i++)
            {
                Console.Write(n_str[i]);
                //新增資料
                q.data[i] = int.Parse(n_str[i]);
                //將佇列尾往後移動
                q.tail++;
            }
            Console.WriteLine("\nAns");
            while (q.head < q.tail)
            {
                Console.Write(q.data[q.head]);
                //移除第一筆資料
                q.head++;
                //將新佇列首移到佇列尾
                q.data[q.tail] = q.data[q.head];
                q.tail++;
                //然後再將新佇列首移除
                q.head++;
            }

            Console.Read();
        }
        struct queue
        {
            public int head;
            public int tail;
            public int[] data;
        };
    }
}
