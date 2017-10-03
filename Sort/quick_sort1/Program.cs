using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件

            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時

            // 6 1 2 7 9 3 4 5 10 8
            //int[] num = { 6, 1, 2, 7, 9, 3, 4, 5, 10, 8 };
            int[] num = { 5, 3, 7, 1, 8, 20, 15, 13, 17, 16 };
            Console.WriteLine("Source");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine("\n");

            quickSort(num);

            Console.WriteLine("\nSort");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }

            sw.Stop();//碼錶停止
            Console.WriteLine();
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");
            Console.Read();
        }

        static void quickSort(int[] arr)
        {
            quickSort(arr, 0, arr.Length - 1);
        }

        static void quickSort(int[] arr, int left, int right)
        {
            if (left >= right) return; // 代表結束
            int L = left, R = right;
            int temp = arr[left]; // 以第一個數當基準
                                  //System.Console.WriteLine("Left:{0},Right:{1}",left,right);

            while (L < R)
            {
                while (arr[R] >= temp && L < R)
                    R--;
                while (arr[L] <= temp && L < R)
                    L++;

                swap(arr, L, R);

                for (int k = 0; k < arr.Length; k++)
                    Console.Write(arr[k] + " ");
                Console.Write("swap:{0},{1},{2}\n", arr[L], arr[R], temp);
            }
            //arr[left] = arr[L];
            //arr[L] = temp;
            swap(arr, left, L);

            quickSort(arr, left, L - 1); //遞迴
            quickSort(arr, L + 1, right);
        }

        static void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
