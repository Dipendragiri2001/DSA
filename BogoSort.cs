using System;
using System.Collections.Generic;
namespace BogoSort
{
    public class Bogo
    {
    public static void Bogo_Sort(IList<int> list) 
    {
        var attempt  = 1;
        while(!IsSorted(list))
        {
            Console.WriteLine($"Attempt {attempt}");
            list.Shuffle();
            attempt++;
        }
    }

    static bool IsSorted(IList<int> list)
    {
        for(int i = 1; i<list.Count;i++)
        {
            if(list[i]<list[i-1])
            {
                return false;
            }
        }
        return true;
    }
    }
    static class IListExtensions
    {
        static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n>1)
            {
                 n--;
                 int k = rng.Next(n+1);
                 T value = list[k];
                 list[k] = list[n];
                 list[n] = value;
            }
        }
    }
}
