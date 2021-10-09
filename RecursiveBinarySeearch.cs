using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public class RecursiveBinarySeearch
    {
        //O(log n)

        //In recursive binary search we create new List(new memory location) each time we call the recursive function
        //so memory occupied by the function depends on scenario of the target data
        //which means it occupies more memory when target is harder to find(IN WORST CASE SCENARIO)
        public bool RecursiveBinaryNumber(List<int> list, int target)
        {
            int midPoint = list.Count() / 2;

            if (list.Count() == 0)
            {
                return false;
            }
            else if (list[midPoint] == target)
            {
                return true;
            }
            else if (list[midPoint] < target)
            {
                var newList = list.Where(x => x > list[midPoint]).ToList();
                return RecursiveBinaryNumber(newList, target);
            }
            else
            {
                var newList = list.Where(x => x < list[midPoint]).ToList();
                return RecursiveBinaryNumber(list, target);
            }
        }
    }
}