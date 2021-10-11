using System;
using System.Collections.Generic;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            Node N1 = new(10);
            l._head = N1;
            l.Add(5);
            l.Add(18);
            Console.WriteLine(l.InsertAt(1, 50)._data);
            Console.WriteLine(l.Search(50));
        }

        public static void Verify(bool index)
        {
            if (index)
            {
                Console.WriteLine("Target Found");
            }
            else
            {
                Console.WriteLine("Target not found");
            }
        }
    }
}
