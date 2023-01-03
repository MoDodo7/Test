using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    internal class LinkedList<T>
    { 
        internal Node<T> head;
        public Node<T> getLastNodeOfList()
        {
            Node<T> L = head;
            while (L.next != null)
            {
                L = L.next;
            }
          
            return L;
        }
        internal void insert(T data)
        {
            if (head == null)
            {
                Node<T> n = new Node<T>(data);
                n.next = null;
                head = n;
            }
            else
            {
                Node<T> L = getLastNodeOfList();
                L.next = new Node<T>(data);
            }

        }

     

        private bool deleteHead(T key)
        {
            if (head is null || head.data)
            {
                return false;
            }

            head = head.next;
            return true;

        }

        private bool deleteAny(T key)
        {
            Node<T> temp = head;
            while (temp.next != null && temp.next.data.CompareTo(key))
            {
                temp = temp.next;
            }
            if (temp.next is null)
            {
                return false;
            }

            temp.next = temp.next.next;
         
            return true;
        }

        internal bool delete(T key)
        {
            if(deleteHead(key)||deleteAny(key))
            {
                Console.WriteLine("Element Deleted");
                return true;
            }
            else
            {
                Console.WriteLine("Element Not Found");
                return false;
            }
        }

        internal void printList()
        {

            Node<T> n = head;
            while (n != null) 
            { 


                    Console.Write($"{n.data} -> ");
                    n = n.next;
                
                
            }
            Console.WriteLine("null");


        }
        internal int Length()
        {
        Node<T> temp=head;
            var count = 0;
                 while (temp!=null)
                    {
                        count++;
                        temp = temp.next;
                     }
                 return count;
  
        }
       

    }
    

}




