using Algorithms.Sorting;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 3, 9, 2 };


            BubbleSort.Sort(numbers);
            Console.WriteLine("Sorted Array :" + string.Join(",",numbers));
        }
    }
}
