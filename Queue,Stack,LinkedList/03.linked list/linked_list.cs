using System;

public class LinkedList
{
    static void Main(string[] arg)
    {
        Console.WriteLine("LinkedList\n");

        int[] data = new int[100];
        int[] right = new int[100];
        int len,t; // t:走訪串列標記
        string[] str;

        //讀取資料
        Console.Write("資料(,):");
        str = Console.ReadLine().Split(',');
        Console.Write("\nInput:");
        for(int i = 1;i <= str.Length;i++)
        {
            data[i] = int.Parse(str[i-1]);        
            Console.Write("{0} ",data[i]);
        }
        len = str.Length;

        //初始化right
        Console.Write("\nRight:");
        for(int i = 1;i <= len;i++)
        {
            if(i!=len)
                right[i] = i+1;
            else
                right[i] = 0;
            Console.Write("{0} ",right[i]);
        }

        //加入資料
        len++;
        Console.Write("\n插入:");
        data[len] = int.Parse(Console.ReadLine());

        //開始走訪串列並更新資料
        t = 1;
        for(;t>0;)
        {
            //如果串列中下個位置 > 插入資料
            if(data[right[t]] > data[len])
            {
                right[len] = right[t];
                right[t] = len;
                break;
            }
            t = right[t];
        }

        //列出
        t = 1;
        Console.Write("new data:");
        for(;t>0;)
        {
            Console.Write("{0} ",data[t]);
            t = right[t]; // 取得右邊資料
        }
        Console.Write("\nnew right");
        for(int i = 1;i <= len;i++)
            Console.Write("{0} ",right[i]);


        Console.Read();
    }
}