using System;

namespace Algorithms.Searching
{
    public class BinarySearch
    {
        public static int binarySearch (int[] array , int target)
        {
            int left = 0;
            int rigth = array.Length - 1;

            while (left < right)
            {
                int mid = (left + rigth) / 2; //Calculate the midpoint 

                if (array[mid] == target)
                {
                    return mid; //Found target 
                } else if (array[mid] < target) 
                {
                    left = mid + 1;
                }
                else
                {
                    rigth = mid - 1;
                }
            }
            return -1; //Target not found
        }
    }
}