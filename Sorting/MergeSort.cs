using System;

namespace Algorithms.Sorting
{

    public class MergeSort
    {



        static public void mergeSort(int[] array, int start, int end)
        {
            if (end <= start) //Base Case to exit from recursion 
            {
                int midpoint = (start + end) / 2; //calculate the midpoint 

                //Call itself tiwce 
                mergeSort(array, start, midpoint);
                mergeSort(array, midpoint + 1, end);

                //Call merge function 
                merge(array, start, midpoint, end);
            }
        }

        static public void merge(int[] array, int start, int midpoint, int end)
        {
            //This var for looping on array i for left , j , for right array , k for orignal array 
            int i, j, k;

            //Create two arrays with length
            int left_length = midpoint - start + 1;
            int right_length = end - midpoint;

            int[] left_array = new int[left_length];
            int[] right_array = new int[right_length];

            //fill two arrays 
            for (i = 0; i < left_length; i++)
            {
                left_array[i] = array[start + i];
            }
            for (j = 0; j < right_length; j++)
            {
                right_array[j] = array[midpoint + 1 + j];
            }

            i = 0;
            j = 0;
            k = start;

            //Compare and Sort 
            while (i < left_length && j < right_length)
            {
                if (left_array[i] <= right_array[j])
                {
                    array[k] = left_array[i];
                    i++;
                }
                else
                {
                    array[k] = right_array[j];
                    j++;
                }
                k++;
            }

            //move  it remain 
            while (i < left_length)
            {
                array[k] = left_array[i];
                i++;
                k++;
            }
            while (j < right_length)
            {
                array[k] = right_array[j];
                j++;
                k++;
            }
        }
    }
}   