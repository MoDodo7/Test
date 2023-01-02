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

        internal void deleteNode(int key)
        {

            Node prev = head;
            Node Current = head.next;

            while (Current != null && Current.data != key)
            {
                prev = Current;
                Current = Current.next;

            }
            if (Current.data == key)
            {
                prev.next = Current.next;

            }

        }

        internal bool deleteHead(int key)
        {
            if (head is null || head.data != key)
            {
                return false;
            }

            head = head.next;
            return true;

        }

        internal bool delete(int key)
        {
            Node temp = head;
            while (temp.next != null && temp.data == key)
            {
                temp = temp.next;
            }
            temp = temp.next.next;
            return true;
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




