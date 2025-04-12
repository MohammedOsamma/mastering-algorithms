using Algorithms.Sorting;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] UnsortedArray= { 1, 4, 3, 9, 2 };


            BubbleSort.Sort(UnsortedArray);
            Console.WriteLine("Sorted Array Frist Try:" + string.Join(",",UnsortedArray));

            int[] SortedArray = { 1,2,3,4,5 };


            BubbleSort.Sort(SortedArray);
            Console.WriteLine("Sorted Array Second Try :" + string.Join(",", SortedArray));
        }
    }
}
