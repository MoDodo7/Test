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
    internal void DeleteNode(int key)
    {
      
        if (head == null)
        {
            return;
        }
        
        Node temp = head;
        Node prev = null; 
        if(temp.data==key)
        {
            temp = null;
        }
        while(temp != null&&temp.data!=key)
        {
            prev = temp;
            temp = temp.next;

        }

        prev.next = temp.next;
        temp = null;
    }


}
    
   

