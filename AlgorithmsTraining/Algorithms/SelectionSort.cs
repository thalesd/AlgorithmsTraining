using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTraining.Algorithms
{
    public class SelectionSort
    {
        public void Run()
        {
            int[] unsorted = new int[] { 35, 2, 3, 6, 22, 18, 13, 12, 4, 9, 15, 16, 14, 1 };
            Console.WriteLine("Unsorted Array: " + string.Join(", ", unsorted));

            int[] sorted = SortRecursive(unsorted, 0, 0, 0);

            Console.WriteLine("Sorted Array: " + string.Join(", ", sorted));
        }

        public int[] SortRecursive(int[] unsorted, int index, int startingIndex, int smallestIndex)
        {
            if (index == unsorted.Length)
            {
                int temp = unsorted[startingIndex];
                unsorted[startingIndex] = unsorted[smallestIndex];
                unsorted[smallestIndex] = temp;

                int nextStartingIndex = startingIndex + 1;

                if (nextStartingIndex < unsorted.Length)
                {
                    return SortRecursive(unsorted, nextStartingIndex, nextStartingIndex, nextStartingIndex);
                }

                return unsorted;
            }

            if (unsorted[index] < unsorted[smallestIndex])
            {
                return SortRecursive(unsorted, index + 1, startingIndex, index);
            }

            return SortRecursive(unsorted, index + 1, startingIndex, smallestIndex);
        }
    }
}
