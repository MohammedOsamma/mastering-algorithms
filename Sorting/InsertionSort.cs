using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        public static void Sort(int[] array)
        {
            int key=0;
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                key = array[i];
                int j;
                for ( j = i - 1;j >= 0 ; j--)
                {
                    if ( key < array[j])
                    {
                        array[j + 1] = array[j];
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = key;
            }
        }
    }
}
