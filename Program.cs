using Algorithms.Sorting;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = { 1, 5, 3, 2, 4 };
            SelectionSort.Sort(unsortedArray);
            Console.WriteLine("Sorted Array :" + string.Join(",",unsortedArray));
        }
    }
}


