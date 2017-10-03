using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL平衡二元樹
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AVL平衡二元樹");

            Node n = new Node(2);
            n.left = new Node(1);
            n.right = new Node(4);
            n.right.left = new Node(3);
            n.right.right = new Node(5);

            L_Rotate(ref n);


            Console.Read();
        }

        static void R_Rotate(ref Node p)
        {
            Node L = p.left;
            p.left = L.right;
            L.right = p;

            p = L;
        }
        static void L_Rotate(ref Node p)
        {
            Node R = p.right;
            p.right = R.left;
            R.left = p;

            p = R;
        }


        


        static List<Node> inOrderTraverse(Node n)
        {
            List<Node> result = new List<Node>();
            inOrder(n, result);

            return result;
        }
        static void inOrder(Node n, List<Node> list)
        {
            if (n != null)
            {
                inOrder(n.left, list);
                list.Add(n);
                inOrder(n.right, list);
            }
        }
    }

    public class Node
    {
        public int data;
        public int bf;
        public Node left;
        public Node right;        

        public Node(int data)
        {
            this.data = data;
        }
    }
}
