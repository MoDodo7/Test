using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
          for(int i = 0; i < 11; i++)
            {
                L.insert(i);
            }
           
            L.printList();
            L.delete(1);
            Console.WriteLine("//////////////////////////////////");
            L.printList();
            Console.ReadLine();
        }
    }
}
