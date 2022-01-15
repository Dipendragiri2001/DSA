using System;
using System.Collections.Generic;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.Add(10);
            l.Add(2);
            l.Add(44);
            l.Add(15);
            l.Add(200);

            Console.WriteLine(l);
            var sortedLinkedList =new LinkedListMergeSort();
            
            var a = sortedLinkedList.MergeSort(l);
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
