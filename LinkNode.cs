using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_list
{
    public class LinkNode <T>
    {
        
        private T data;
        private LinkNode<T> next;
        public LinkNode(T x)
        {
            this.data = x;
            this.next = null;
        }

        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public LinkNode<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
