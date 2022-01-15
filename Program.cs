using System;
using System.Collections.Generic;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            // --> Linked list merge sort
            // LinkedList l = new LinkedList();
            // l.Add(10);
            // l.Add(2);
            // l.Add(44);
            // l.Add(15);
            // l.Add(200);

            // Console.WriteLine(l);
            // var sortedLinkedList =new LinkedListMergeSort();
            
            // var a = sortedLinkedList.MergeSort(l);

            //-->BogoSort
            // var list = new List<int>() { 29, 100, 1, 2, 57 };
            // BogoSort.Bogo.Bogo_Sort(list);
            // Console.WriteLine(String.Join(",",list));

            //--> Selection Sort
            var list = new List<int>() { 29, 100, 1, 2, 57 };
            var sortedList = SelectionSort.SelectionSort.Selection_Sort(list);
            Console.WriteLine(String.Join(",", sortedList));
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
