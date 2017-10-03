using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qsort
{
    class Program
    {
        static int[] input = new int[] { 5, 3, 7, 1, 2, 20, 15, 13, 17, 16 };
        static void Main(string[] args)
        {
            QuickSort(input, 0, input.Length - 1);

            foreach (var i in input) Console.Write(i + " ");


            Console.Read();
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            int L = left,
                R = right;
            int temp = arr[(left + right) / 2];


            while (true)
            {
                while (arr[R] > temp) R--;
                while (arr[L] < temp) L++;

                if (L >= R) break;
                swap(arr, L, R);
            }


            QuickSort(arr, left, L - 1);
            QuickSort(arr, L + 1, right);
        }
        static void swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
