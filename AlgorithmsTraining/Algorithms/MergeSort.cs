using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTraining.Algorithms
{
    internal class MergeSort
    {
        public void Run()
        {
            int[] unsorted = new int[] { 35, 2, 3, 6, 22, 18, 13, 12, 4, 9, 15, 16, 14, 1 };

            Console.WriteLine("Unsorted Array: " + string.Join(", ", unsorted));

            SortRecursive(unsorted, 0, unsorted.Length - 1);

            //Console.WriteLine("Loop Sorted Array: " + string.Join(", ", SortLoop(unsorted)));
            Console.WriteLine("Recursive Sorted Array: " + string.Join(", ", unsorted));
        }

        public void SortRecursive(int[] unsorted, int left, int right)
        {
            if(right > left)
            {
                int middle = (right + left) / 2;
                SortRecursive(unsorted, left, middle);
                SortRecursive(unsorted, right, middle);

                Merge(unsorted, left, middle, right);
            }
        }

        public void Merge(int[] unsorted, int left, int middle, int right)
        {
            int arrayLeftSize = middle - left + 1;
            int arrayRightSize = right - middle;

            int[] newLeft = new int[arrayLeftSize];
            int[] newRight = new int[arrayRightSize];

            int i, j;

            for(i = 0; i<arrayLeftSize; i++)
            {
                newLeft[i] = unsorted[left+i];
            }

            for (j = 0; j < arrayRightSize; j++)
            {
                newLeft[j] = unsorted[middle + 1 + j];
            }

            i = 0;
            j = 0;

            int k = left;
            while(i < arrayLeftSize && j < arrayRightSize)
            {
                if (newLeft[i] <= newRight[j])
                {
                    unsorted[k] = newLeft[i];
                    i++;
                }
                else
                {
                    unsorted[k] = newRight[j];
                    j++;
                }
                k++;
            }

            while(i < arrayLeftSize)
            {
                unsorted[k] = newLeft[i];
                i++;
                k++;
            }

            while(j < arrayRightSize)
            {
                unsorted[k] = newRight[j];
                j++;
                k++;
            }
        }
    }
}
