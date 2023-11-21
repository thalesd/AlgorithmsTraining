using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTraining.Algorithms
{
    internal class InsertionSort
    {
        public void Run()
        {
            int[] unsorted = new int[] { 35, 2, 3, 6, 22, 18, 13, 12, 4, 9, 15, 16, 14, 1 };

            Console.WriteLine("Unsorted Array: " + string.Join(", ", unsorted));

            Console.WriteLine("Loop Sorted Array: " + string.Join(", ", SortLoop(unsorted)));
            Console.WriteLine("Recursive Sorted Array: " + string.Join(", ", SortRecursive(unsorted, unsorted[1])));

        }

        public int[] SortLoop(int[] unsortedArray)
        {
            for (int i = 1; i < unsortedArray.Length; i++)
            {
                int target = unsortedArray[i];
                int j = i - 1;

                while(j >= 0 && unsortedArray[j] > target)
                {
                    unsortedArray[j+1] = unsortedArray[j];
                    j--;
                }
                unsortedArray[j + 1] = target;
            }

            return unsortedArray;
        }

        public int[] SortRecursive(int[] unsortedArray, int target, int indexOuter = 1, int indexInner = 0)
        {
            if (indexInner >= 0 && unsortedArray[indexInner] > target)
            {
                unsortedArray[indexInner + 1] = unsortedArray[indexInner];
                return SortRecursive(unsortedArray, target, indexOuter, indexInner - 1);
            }

            unsortedArray[indexInner + 1] = target;

            if(indexOuter+1 == unsortedArray.Length)
            {
                return unsortedArray;
            }

            int nextIndex = indexOuter + 1;

            return SortRecursive(unsortedArray, unsortedArray[nextIndex], nextIndex, nextIndex-1);
        }
    }
}
