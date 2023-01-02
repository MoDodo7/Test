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
      
          
        }
    internal void deleteNode(int key)
    {
      
        if (head == null)
        {
            return;
        }
        Node prev = head;
        Node Current = head.next;
      
        while(Current != null&&Current.data!=key)
        {
            prev = Current;
            Current = Current.next;

        }
        if(Current.data==key)
        {
            prev.next = Current.next;
           
        }
        
    }

    internal void deleteHead()
    {
        if (head == null)
        { return;}
           
        Node n = head;
        head = n.next;
        n = null;
    }

    internal void deleteTail()
    {
        if (head == null)
        { return; }
       else if(head.next==null)
        { head = null; 
        }
        else
        { Node N = head;
        while(N.next.next!=null)
            {
                N = N.next;

            }
            N.next = null;
           }

    }
}
    
   

