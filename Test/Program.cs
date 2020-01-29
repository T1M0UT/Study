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
        int y=0;
        Tree tree=new Tree();
        tree.Add(0);
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string telephone = Console.ReadLine();
            foreach(char x in telephone)
            {
                tree.Add(x);
                y=tree.Count();
                Console.WriteLine(y);
            }
        }
    }
}
class Tree
    {
        private Node Root;
        
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
       public int Count()=>Root.Counter(Root);
    }
class Node
    {
        private int value;
        public Node One { get; private set; }
        public Node Two { get; private set; }
        public Node Three { get; private set; }
        public Node Four { get; private set; }
        public Node Five { get; private set; }
        public Node Six { get; private set; }
        public Node Seven { get; private set; }
        public Node Eight { get; private set; }
        public Node Nine { get; private set; }
        public Node O { get; private set; }
        public Node(int value)
        {
            this.value = value;
            One = null;
            Two = null;
            Three = null;
            Four = null;
            Five = null;
            Six = null;
            Seven = null;
            Eight = null;
            Nine = null;
            O = null;
        }
        public void Add(int newValue)
        {
            switch(newValue){
                case 1:
                    if (One == null) {One = new Node(newValue);};                    
                    break;
                case 2:
                    if (Two == null) {Two = new Node(newValue);}
                    break;
                case 3:
                    if (Three == null) {Three = new Node(newValue);}
                    break;
                case 4:
                    if (Four == null) {Four = new Node(newValue);}
                    break;
                case 5:
                    if (Five == null) {Five = new Node(newValue);}
                    break;
                case 6:
                    if (Six==null) {Six = new Node(newValue);}
                    break;
                case 7:
                    if (Seven == null) {Seven = new Node(newValue);}
                    break;
                case 8:
                    if (Eight == null) {Eight = new Node(newValue);}
                    break;
                case 9:
                    if (Nine == null) {Nine = new Node(newValue);}
                    break;
                case 0:
                    if (O == null) {O = new Node(newValue);}
                    break;
                default:
                    Console.WriteLine("ERR");
                    break;
            }
        }
        public int Counter(Node node){
            int result=0;
            if(node.One!=null) Counter(node.One()); 
            if(node.Two!=null) Counter(node.Two()); 
            if(node.Three!=null) Counter(node.Three()); 
            if(node.Four!=null) Counter(node.Four()); 
            if(node.Five!=null) Counter(node.Five()); 
            if(node.Six!=null) Counter(node.Six()); 
            if(node.Seven!=null) Counter(node.Seven()); 
            if(node.Eight!=null) Counter(node.Eight()); 
            if(node.Nine!=null) Counter(node.Nine()); 
            if(node.O!=null) Counter(node.O()); 
            else result++;
            return result;
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
