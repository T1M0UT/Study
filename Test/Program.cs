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
