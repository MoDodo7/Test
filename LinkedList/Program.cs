using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> L = new LinkedList<int>();
            L.insert(3);
            L.insert(4);
            L.insert(5);
            L.insert(6);
            L.insert(7);
            Console.WriteLine(L.Length());
                
          
        }
    }
}
