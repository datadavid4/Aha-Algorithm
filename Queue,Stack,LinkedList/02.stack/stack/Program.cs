using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //迴文解密 ahaha,oppo
            Console.Write("Stack\n\nInput:");

            stack s;
            s.top = 0;
            s.data = new char[100];

            string str = Console.ReadLine();

            int mid = str.Length / 2;
            Console.WriteLine("mid:\t{0}", mid);
            Console.WriteLine("length:\t{0}", str.Length);
            //Console.WriteLine("type:\t{0}",str[0].GetType());

            Console.WriteLine("\ndata/top");
            for (int i = 0; i < mid; i++)
            {
                s.top++;
                s.data[s.top] = str[i];
                Console.WriteLine("{0}\t{1}", s.data[s.top], s.top);
            }
            //判斷此字串長度為基or偶
            int next = (str.Length % 2 == 0 ? mid : mid + 1);
            Console.WriteLine("next:\t{0}", next);
            Console.WriteLine("\nstr,i\tdata,top");
            for (int i = next; i < str.Length; i++)
            {
                Console.WriteLine("{0},{1}\t{2},{3}", str[i], i, s.data[s.top], s.top);
                if (str[i] == s.data[s.top])
                    s.top--;

            }

            if (s.top == 0)
                Console.WriteLine("Y");
            else
                Console.WriteLine("N");

            Console.Read();
        }

        struct stack
        {
            public int top;
            public char[] data;
        };
    }
}
