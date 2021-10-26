using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_list
{
    class SQueue<T>
    {
        private LinkNode<T> head;
        private int count;

        public SQueue()
        {
            this.head = null;
            this.count = 0;
        }

        //IsEmpty -: this returns true if the Queue is empty;
        public bool IsEmpty()
        {
            return count == 0;
        }

        //Size -: this returns the size of the Queue
        public int Size()
        {
            return this.count;
        }

        //Enqueue -: this adds or queues an item behind the head
        public void Enqueue(T data)
        {
            LinkNode<T> node = new LinkNode<T>(data);
            LinkNode<T> current = this.head;
            if (IsEmpty()||count==0)
            {
                this.head = node;
                node.Next = null;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (current.Next == null)
                    {
                        current.Next = node;
                    }
                    else
                    {
                        current = current.Next;
                    }

                }
            }
            count++;
        }

        //DeQueue -: this removes and returns an item at the front or head of the queue
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException("Cannot Dequeue() an empty Queue");
            }
            else
            {
                LinkNode<T> node = this.head;
                this.head = this.head.Next;
                count--;
                return node.Data;
            }
            
        }


        //print
        public void Print()
        {
            LinkNode<T> runner = this.head;
            while (runner != null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;
            }
        }
    }
}
