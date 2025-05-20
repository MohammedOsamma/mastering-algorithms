using System;
using Algorithms.Sorting;
using Algorithms.Searching;
namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

         

            int[] array = { 9, 5, 1, 4 };
            int reasult = BinarySearch.binarySearch(array, 5);
            Console.WriteLine(reasult);
          


        }
    }
}


