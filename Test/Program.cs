using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
namespace Solv
{ 
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int sum=0;
        Tree tree=new Tree();
        for (int i = 0; i < N; i++)
        {
            string telephone = Console.ReadLine();
            char[] a=telephone.ToCharArray();
            if(a[0]!=tree.Root) ;
            for(int i=1;i<telephone.Length; i++)
            {   
                tree.Add(x);
            }
        }


        // The number of elements (referencing a number) stored in the structure.
        //Console.WriteLine("number");
    }
}
class Tree
    {
        public Node Root;
        public Tree()
        {
            Root = null;
        }
        public void Add(int newValue)
        {
            if (Root == null)
            {
                Root = new Node(newValue);
            }
            else
            {
                Root.Add(newValue);
            }
        }
    }
class Node
    {
        private int value;
        public Node Left { get; private set; }
        public Node Right { get; private set; }
        public Node(int value)
        {
            this.value = value;
            Left = null;
            Right = null;
        }
        public void Add(int newValue)
        {
            if (value >= newValue)
            {
                if (Left == null) Left = new Node(newValue);
                else Left.Add(newValue);
            }
            else
            {
                if (Right == null) Right = new Node(newValue);
                else Right.Add(newValue);
            }
        }
    }
}
//=====================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Node
    {
        private int value;
        private Node back;
        public Node Next { get; private set; }
        public Node(int value)
        {
            this.value = value;
            Next = null;
            back = null;
        }
        public void Add(int newValue)
        {
            if (back==null)
            {
                back = new Node(newValue);
                Next = back;
            }
            else
            {
                back.Add(newValue);
            }
        }
        public List<int> GetList(List<int> answer)
        {
            answer.Add(value);
            Next?.GetList(answer);
            return answer;
        }
        public override String ToString() => string.Join(", ", GetList(new List<int>()));
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class QueueUI
    {
        private Node Root;
        public QueueUI()
        {
            Root = null;
        }
        public void Add(int newValue)
        {
            if (Root == null)
            {
                Root = new Node(newValue);
            }
            else
            {
                Root.Add(newValue);
            }
        }
        public override string ToString() => Root == null ? "No tree" : Root.ToString();
    }
}
