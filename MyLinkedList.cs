using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_list
{
    public class SLinkedList<T>
    {
        
        LinkNode<T> head;
        private int count;

        public SLinkedList()
        {
            this.head = null;
            this.count = 0;
        }



        //indexer

        public T this[int index]
        {
            get { return this.Get(index); }
        }

        //get method for indexer
        private T Get(int index)
        {
            if (index < 0 || index > this.count)
                throw new ArgumentOutOfRangeException("index not in range -:"+ index) ;

            LinkNode<T> current = this.head;
            for (int i = 0; i < index; i++)
                current = current.Next;

            return current.Data;
        }
        
        
        
        ///ADD METHOD This method creates a new node adds an object in it and places it at the tail of the node

        public int Add(T data)
        {
            LinkNode<T> node = new LinkNode<T>(data);
            LinkNode<T> current = this.head;
            if (Empty)
            {
                this.head = node;
                node.Next = null;
            }
            else
            {
                for (int i = 0; i < this.count ; i++)
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
            
            this.count++;
            return this.count;
        }

        
        
        //remove first occurence
        public bool Remove(T data)
        {
            LinkNode<T> node = this.head;
            if (node.Data.ToString() == data.ToString())
            {
                this.head = node.Next;
                this.count--;
                return true;
            }
            else
            {
                if (Check(data))
                {
                    for (int i = 0; i < this.count; i++)
                    {
                        if (node.Next.Data.Equals(data))
                        {
                            node.Next = node.Next.Next;
                            this.count--;
                            return true;
                        }
                        node = node.Next;
                    }
                }
                else
                {
                    return false;
                }
            }return false;
            
        }
        

        
        
        /// this method loops through the list and returns true if the item is found or false if it isn't
        
        public bool Check(T data)
        {
            LinkNode<T> node = this.head;
            for(int i = 0; i < this.count; i++)
            {
                if(node.Data.Equals(data))
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        
        
        /// This Method returns the index of an object if it exists in the list or -1 if it doesn't   
        
        public int Index(T data)
        {
            LinkNode<T> node = this.head;
            for (int i = 0; i < this.count; i++)
            {
                if (node.Data.Equals(data))
                {
                    return i;
                }
                node = node.Next;
            }
            return -1;
        }








        /// <summary>
        /// This method prints out all the contents of the list
        /// </summary>
        public void Print()
        {
            LinkNode<T> runner = head;
            while (runner !=null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;
            }
        }

        /// <summary>
        /// this method returns true if the list is empty or false if its not
        /// </summary>
        public bool Empty
        {
            get { return this.count == 0;}
        }


        /// <summary>
        /// this method clears the whole list by setting the head to null 
        /// </summary>
        public void Clear()
        {
            this.head = null;
            count = 0;
        }

        /// <summary>
        /// this returns the total size of the list
        /// </summary>
        public int Count
        {
            get { return this.count;}
        }

        
       
    }
}
