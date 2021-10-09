using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public class LinearSearch
    {
        public int Linear_Search(List<int> list, int target)
        {
            foreach (int i in Enumerable.Range(0, list.Count()))
            {
                if (list[i] == target)
                {
                    return i;
                }
            }
            return 0;

        }

        //returnstheindex position if target is found


    }
}