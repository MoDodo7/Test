using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node<T>
    { 
        internal T data;
        internal Node<T> next;
        public Node(T data)
        {
            this.data = data;
            next = null;
        }

        public override string ToString()
        {
            return $"{data.ToString()} -> ";
        }


    }
}
