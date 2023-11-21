using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTraining.Algorithms
{
    public class BubbleSort
    {
        public void Run()
        {
            int[] unsorted = new int[] { 35, 2, 3, 6, 22, 18, 13, 12, 4, 9, 15, 16, 14, 1 };
            Console.WriteLine("Unsorted Array: " + string.Join(", ", unsorted));

            int[] sorted = SortRecursive(unsorted, 0, unsorted.Length, unsorted.Length);

            Console.WriteLine("Sorted Array: " + string.Join(", ", sorted));
        }

        public int[] SortRecursive(int[] unsorted, int index, int maxIndex, int passes)
        {
            if (index == maxIndex) {
                if(passes > 0)
                {
                    return SortRecursive(unsorted, 0, maxIndex - 1, passes - 1);
                }
                return unsorted;
            }

            if (index + 2 == maxIndex)
            {
                if (unsorted[index] > unsorted[index + 1])
                {
                    int temp = unsorted[index];
                    unsorted[index] = unsorted[index + 1];
                    unsorted[index + 1] = temp;
                }
            }

            if(index > 0)
            {
                if (unsorted[index] < unsorted[index - 1])
                {
                    int temp = unsorted[index];
                    unsorted[index] = unsorted[index - 1];
                    unsorted[index - 1] = temp;
                }
            }

            return SortRecursive(unsorted, index + 1, maxIndex, passes);
        }
    }
}
