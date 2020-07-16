using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace MyLinkedList
{
    class MyLinkedList
    {
        Node Head;
        int Nodecnt = 0;
        private Node holder;

        public MyLinkedList(Object Data)
        {
            Head = new Node(Data);
        }

        public int NodeCnt { get; private set; }

        public void Add(Object Data, int idx)
        {
            Node temp = Head;
            Node hoder;
            for (int i = 0; i < idx - 1 && temp.Next != null; i++)
            {
                temp = temp.Next;
            }
            hoder = temp.Next;
            temp.Next = new Node(Data);
            temp.Next.Next = holder;
            Nodecnt++;
        }
        public void AddFirst(Object Data)
        {
            Node temp = Head;
            Head = new Node(Data);
            Head.Next = temp;
            NodeCnt++;
        }
        public Node GetData(int idx)
        {
            Node temp = Head;
            for (int i = 0; i < idx; i++)
            {
                temp = temp.Next;
            }
            return temp;
        }
        public void PrintList()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
