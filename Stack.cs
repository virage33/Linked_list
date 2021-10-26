using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_list
{
    public class SStack<T>
    {
        LinkNode<T> peak;
        private int count;

        public SStack()
        {
            this.peak = null;
            this.count = 0;
        }

        //isEmpty -: Returns true if the stack is empty
        public bool IsEmpty()
        {
            return count == 0; 
        }

        //Size -: Returns the size of the stack
        public int Size()
        {
            return this.count; 
        }

        //Push -: pushes an item ontop of the stack and makes it the new head
        public void Push(T data)
        {
            LinkNode<T> node = new LinkNode<T>(data);
            node.Next = peak;
            this.peak = node;
            
            this.count++;
        }

        //pop -: this removes and returns the last data to be added in

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException("Cannot Pop() an empty stack");
            }
            else
            {
                LinkNode<T> node = this.peak;
                this.peak = this.peak.Next;
                this.count--;
                return node.Data;
            }
        }


        //Peek() -: this returns the last item added to the list
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Cannot Peek() an empty stack");
            }
            else
            {
                return this.peak.Data;
            }
            
        }


        //
        //print
        public void Print()
        {
            LinkNode<T> runner = this.peak;
            while (runner != null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;
            }
        }
    }
}
