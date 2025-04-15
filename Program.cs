using System;
using Algorithms.Sorting;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] unsortedArray = { 1, 5, 3, 2, 4 };
            Console.WriteLine("Sorted Array :" + string.Join(",",unsortedArray));
            QuickSort.Sort(unsortedArray);
            Console.WriteLine("QuickSorts Array :" + string.Join(",",unsortedArray));
            Console.ReadLine();
            
            
        }
    }
}


