internal static class ExponentialSearchHelpers
{


    private static int Binarysearch(int[] array, int target, int left, int right)
    {
        while (left <= right)
        {
            int mid = (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
            return -1;
        }
    }
}