namespace AlgorithmsTraining.Algorithms
{
    public class CombineOrderedArrays
    {
        public void Run()
        {
            int[] firstArray = new int[] { 1, 2, 3, 4, 5, 7, 9, 34, 35, 36 };
            Console.WriteLine("First array: " + string.Join(", ", firstArray));

            int[] secondArray = new int[] { 0, 0, 1, 2, 33 };
            Console.WriteLine("Second array: " + string.Join(", ", secondArray));

            int[] result = new int[firstArray.Length + secondArray.Length];

            int i = 0, j = 0, k = 0;

            while(i < result.Length)
            {
                if(j == firstArray.Length)
                {
                    GetRemainingItems(result, i, secondArray, k);
                    break;
                }
                else if(k == secondArray.Length)
                {
                    GetRemainingItems(result, i, firstArray, j);
                    break;
                }

                if (firstArray[j] > secondArray[k])
                {
                    result[i] = secondArray[k];
                    i++;
                    k++;
                }
                else
                {
                    result[i] = firstArray[j];
                    i++;
                    j++;
                }
            }

            Console.WriteLine("Result array: " + string.Join(", ", result));
        }

        public static int[] GetRemainingItems(int[] result, int resultIndex, int[] remainingItemsArray, int remainingItemsIndex)
        {
            for(int i = remainingItemsIndex; i <  remainingItemsArray.Length; i++)
            {
                result[resultIndex] = remainingItemsArray[i];
                resultIndex++;
            }

            return result;
        }
    }
}
