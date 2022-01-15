using System;
using System.Collections.Generic;

namespace SelectionSort
{
    public class SelectionSort{
    public static List<int> Selection_Sort(IList<int> list)
    {
        var sortedList = new List<int>();
        Console.WriteLine("Unsorted List" +String.Join(",",list));
        while(list.Count >0)
        {
            int indexToMove = IndexOfMin(list);
            int min = list[indexToMove];
            list.RemoveAt(indexToMove);
            sortedList.Add(min);
        Console.WriteLine("Sorted List" +String.Join(",",sortedList));

        }
        return sortedList;
    }


    static int IndexOfMin(IList<int> list)
    {
        int minIndex= 0;
        for(int i=0;i<list.Count;i++)
        {
            if(list[i] <list[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }
}
}