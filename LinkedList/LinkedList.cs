using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        internal Node head;
        public Node getLastNodeOfList()
        {
            Node L = head;
            while (L.next != null)
            {
                L = L.next;
            }
          
            return L;
        }
        internal void insert(int data)
        {
            if (head == null)
            {
                Node n = new Node(data);
                n.next = null;
                head = n;
            }
            else
            {
                Node L = getLastNodeOfList();
                L.next = new Node(data);
            }

        }

     

        private bool deleteHead(int key)
        {
            if (head is null || head.data != key)
            {
                return false;
            }

            head = head.next;
            return true;

        }

        private bool deleteAny(int key)
        {
            Node temp = head;
            while (temp.next != null && temp.next.data != key)
            {
                temp = temp.next;
            }
            
            temp.next = temp.next.next;
            return true;
        }

        internal bool delete(int key)
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

            Node n = head;
            while (n != null) 
            { 


                    Console.Write($"{n.data} -> ");
                    n = n.next;
                
                
            }
            Console.WriteLine("null");




        }


    }
    

}




