using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 5, 1, 7, 3, 9, 11, 22, 33, 55, 44, 99, 88 };

            Console.WriteLine("原本排序");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("{0} ", x[i]);
            }

            QuickSort1(x,0,x.Length-1);
            Console.WriteLine("\r\n整理排序");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("{0} ", x[i]);
            }
            Console.ReadKey();   
        }
        public static void QuickSort1(int[] array, int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right + 1;
                while (true)
                {
                    while (i + 1 < array.Length && array[++i] < array[left]) ;
                    while (j - 1 > -1 && array[--j] > array[left]) ;
                    if (i >= j)
                        break;
                   Swap(array, i, j);
                }
                Swap(array, left, j);
                QuickSort1(array, left, j - 1);
                QuickSort1(array, j + 1, right);
            }
        }
        public static void Swap(int[] array, int indexA, int indexB)
        {
            int tmp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = tmp;
        }

        
    }
}
