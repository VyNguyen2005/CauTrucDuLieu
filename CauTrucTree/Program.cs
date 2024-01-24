using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucTree
{
    class TNode
    {
        public int Info;
        public TNode Left;
        public TNode Right;
        public TNode(int x)
        {
            Info = x;
            Left = null;
            Right = null;
        }
    }
    class BinarySearchTree
    {
        public TNode Root;
        public BinarySearchTree()
        {
            Root = null;
        }
        public void NLR(TNode root)
        {
            if(root != null)
            {
                Console.Write($"{root.Info} -> ");
                NLR(root.Left);
                NLR(root.Right);
            }
        }
        public void LNR(TNode root)
        {
            if(root != null)
            {
                LNR(root.Left);
                Console.Write($"{root.Info} -> ");
                LNR(root.Right);
            }
        }
        public void LRN(TNode root)
        {
            if(root != null)
            {
                LRN(root.Left);
                LRN(root.Right);
                Console.Write($"{root.Info} -> ");
            }
        }
        public void AddNode(ref TNode root, int x)
        {
            if(root == null)
            {
                TNode p = new TNode(x);
                root = p;
            }
            else if(root.Info > x)
            {
                AddNode(ref root.Left, x);
            }
            else if(root.Info < x)
            {
                AddNode(ref root.Right, x);
            }
        }
        public void CreateTree()
        {
            Console.Write("Cho biet so nut trong cay: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n; i++)
            {
                Console.Write($"Gia tri node thu {i}: ");
                int x = int.Parse(Console.ReadLine());
                AddNode(ref Root, x);
            }
        }
        public TNode SearchNode(TNode root, int x)
        {
            TNode kq = null;
            if (kq != null)
            {
                if(root.Info == x)
                {
                    kq = root;
                }
                else if(x < root.Info)
                {
                    kq = SearchNode(root.Left, x);
                }
                else
                {
                    kq = SearchNode(root.Right, x);
                }
            }
            return kq;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.CreateTree();

            Console.WriteLine("Ket qua duyet cay: ");
            Console.Write("LNR: ");

            tree.LNR(tree.Root);

            Console.Write("\nNhap gia tri node can tim: ");
            int x = int.Parse(Console.ReadLine());
            TNode kq = tree.SearchNode(tree.Root, x);
            if(kq == null)
            {
                Console.WriteLine($"{x} khong xuat hien trong tree");
            }
            else
            {
                Console.WriteLine($"{x} co xuat hien trong tree");
            }
            Console.ReadLine();
        }
    }
}
