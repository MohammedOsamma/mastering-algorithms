using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public class ExponentialSearch
    {

        public static int Search(int [] array , int target)
        {
            if (array.Length == 0)
                return -1;

            if (array[0] == target)
                return 0;

            int bound = 1;
            while (bound < array.Length && array[bound] <= target)
            {
                bound *= 2;
            }


            return Binarysearch(array, target, bound / 2, Math.Min(bound, array.Length - 1));
        }


        private static int Binarysearch(int[] array, int target, int left, int right)
        {
            while (left <= right)
            {
                int mid = ( right - left ) / 2;

                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
                return -1;
            }
        }
    }
}
