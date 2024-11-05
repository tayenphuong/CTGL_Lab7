using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class ArrayQueue
    {
        int[] qArray;
        int qMax;
        int qFront;
        int qRear;

        public ArrayQueue(int MaxItem)
        {
            qArray = new int[MaxItem];
            qMax = MaxItem;
            qFront = qRear = -1;
        }

        public int[] QArray { get => qArray; set => qArray = value; }
        public int QMax { get => qMax; set => qMax = value; }
        public int QFront { get => qFront; set => qFront = value; }
        public int QRear { get => qRear; set => qRear = value; }

        public bool IsEmpty => qFront == -1;
        public bool IsFull => (qRear + 1) % qMax == qFront;

        public bool EnQueue(int newitem)
        {
            if (IsFull) return false;
            if (IsEmpty) qFront = qRear = 0;
            else
                qRear = (qRear + 1) % qMax;
            qArray[qRear] = newitem;
            return true;
        }
        public bool DeQueue(out int itemOut)
        {
            itemOut = 0;
            if (IsEmpty) return false;
            itemOut = qArray[qFront];
            if (qFront == qRear)
                qFront = qRear = -1;
            else
                qFront = (qFront + 1) % qMax;
            return true;
        }
        public bool GetFront(out int item)
        {
            item = 0;
            if (IsEmpty) return false;
            item = qArray[qFront];
            return true;
        }
        public bool GetRear(out int item)
        {
            item = 0;
            if (IsEmpty) return false;
            item = qArray[qRear];
            return true;
        }

    }


    class IntNode
    {
        private int data;
        private IntNode next;

        public int Data { get => data; set => data = value; }
        internal IntNode Next { get => next; set => next = value; }
        public IntNode(int x = 0)
        {
            data = x;
            next = null;
        }

    }


    class MyList
    {
        private IntNode qFront;
        private IntNode qRear;
        private int count;
        public IntNode QFront
        {
            get { return qFront; }
            set { qFront = value; }
        }
        public IntNode QRear
        {
            get { return qRear; }
            set { qRear = value; }
        }
        public int Count 
        {
            get { return count; }
        }


        public MyList() 
        {
            qFront = null; 
            qRear = null;
            count = 0;
        }
        public bool IsEmpty()
        {
            return qFront == null;
        }
        public bool EnQueue(IntNode newNode)
        {
            if (IsEmpty())
                qFront = qRear = newNode;
            else
            {
                qRear.Next = newNode;
                qRear = newNode;
            }
            count++;
            return true;
        }
       
        public void ShowList()
        {
            int x;
            while (!IsEmpty()) 
            {
                DeQueue(out x);
                Console.Write($"{x,5}");
            }
            Console.WriteLine();
        }

      
        public bool DeQueue(out int item)
        {
            item = 0;
            if (IsEmpty()) return false;
            item = qFront.Data;
            IntNode pDel = qFront;
            qFront = qFront.Next;
            pDel.Next = null;
            pDel = null;
            return true;
        }
        public bool GetFront(out int outItem)
        {
            outItem = 0;
            if (IsEmpty()) return false;
            outItem = qFront.Data;
            return true;
        }
        public bool GetRear(out int outItem)
        {
            outItem = 0;
            if (IsEmpty()) return false;
            outItem = qRear.Data;
            return true;
        }
    }

}
