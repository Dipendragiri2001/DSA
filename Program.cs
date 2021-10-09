using System;
using System.Collections.Generic;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            RecursiveBinarySeearch s = new();
            bool result = s.RecursiveBinaryNumber(list, 8);
            Verify(result);

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
