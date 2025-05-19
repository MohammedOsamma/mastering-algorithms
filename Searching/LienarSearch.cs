using System;

namespace Algorithms.Searching
{
    public class LinearSearch
    {
        public static int linearSearch(int[]array , int target)
        {
            for (int i = 0; i <array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; //Found the target at index i
                }
            }
            return -1; //Target not found 
        }
    }
}