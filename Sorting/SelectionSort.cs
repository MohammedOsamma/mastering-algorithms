using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] array)
        {
            int n = array.Length;
            for (int i =0;i<n-1; i++)
            {
                int minIndex = i;

                for (int j =i+1; j< n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex= array[j];
                    }
                }

                if(minIndex != i )
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
    }
}
