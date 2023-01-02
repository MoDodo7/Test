using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            L.insert(3);
            L.insert(2);
            L.insert(1);
            L.insert(-3);
            L.insert(8);
            L.insert(11);
            L.insert(14);
            L.insert(17);


            L.printList();
          
            Console.WriteLine("//////////////////////////////////");
            L.sortList();
            L.printList();

            Console.ReadLine();
        }
    }
}
