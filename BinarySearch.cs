using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public class BinarySearch
    {
        // Takes Constant Space O(1) /
        //Because any list of data passed inside the function  
        //We can find the solution using the list which is location in a single memory
        //It is called constant time because it uses the same list storage to perform the operation
        public int Binary_Search(List<int> list, int target)
        {
            int first = 0;
            int last = list.Count() - 1;

            while (first <= last)
            {
                int midPoint = (first + last) / 2;

                if (list[midPoint] == target) return midPoint;

                else if (list[midPoint] < target) first = midPoint + 1;

                else last = midPoint - 1;
            }
            return 0;
        }
    }
}