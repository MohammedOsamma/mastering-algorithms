using System;
using Algorithms.Sorting;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MergeSort.mergeSort()

            int[] array = { 9, 5, 1, 4 };
            Console.WriteLine(String.Join(",", array));
            MergeSort.mergeSort(array, 0, array.Length - 1);
            Console.WriteLine(String.Join(",", array));


        }
    }
}


