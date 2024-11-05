using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class ArrayStack
    {

        private int[] stkArray;
        private int stkMax;
        private int stkTop;

        public int[] StkArray { get => stkArray; set => stkArray = value; }
        public int StkMax { get => stkMax; set => stkMax = value; }
        public int StkTop { get => stkTop; set => stkTop = value; }

        public ArrayStack(int max = 0)
        {
            stkMax = max;
            stkArray = new int[max];
            stkTop = -1;
        }

        public bool IsEmpty => stkTop == -1;

        public bool IsFull => stkTop == stkMax - 1;
        public bool Push(int x)
        {
            if (IsFull == true) return false;
            stkTop++;
            stkArray[stkTop] = x;
            return true;
        }
        public bool Pop(out int outItem)
        {
            outItem = default;
            if (IsEmpty == true) return false;
            outItem = stkArray[stkTop];
            stkTop--;
            return true;
        }
        public bool GetTop(out int outItem)
        {
            outItem = 0;
            if (IsEmpty == true) return false;
            outItem = stkArray[stkTop];
            return true;
        }

    }

    class Node
    {
        private int data;
        private Node next;
        public int Data { get => data; set => data = value; }
        internal Node Next { get => next; set => next = value; }
        public Node(int x = 0)
        {
            data = x;
            next = null;
        }

    }
    class ListStack
    {
        Node top;
        internal Node Top { get => top; set => top = value; }

        public ListStack()
        {
            top = null;
        }

        public bool IsEmpty => top == null;

        public bool Push(int x)
        {
            Node newNode = new Node(x);
            if (IsEmpty) top = newNode;
            else
            {
                newNode.Next = top;
                top = newNode;
            }
            return true;
        }
        public bool Pop(out int outItem)
        {
            outItem = 0;
            if (IsEmpty) return false;
            outItem = top.Data;
            Node pDel = top;
            top = top.Next;
            pDel.Next = null;
            pDel = null;
            return true;
        }
        public bool GetTop(out int outItem)
        {
            outItem = 0;
            if (IsEmpty) return false;
            outItem = top.Data;
            return true;
        }
    }


}
