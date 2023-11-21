namespace AlgorithmsTraining.Algorithms
{
    public class FindDuplicatedItemInList
    {
        public void Run()
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            int[] myValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 10, 12 };

            Console.WriteLine("Values list: " + string.Join(',', myValues));

            for (int i = 0; i < myValues.Length; i++)
            {
                if (keyValuePairs.ContainsKey(myValues[i]))
                {
                    Console.WriteLine("Duplicated item is: " + myValues[i]);
                    return;
                }
                else
                {
                    keyValuePairs.Add(myValues[i], i);
                }
            }

            Console.WriteLine("No duplicates found!");
        }
    }
}
