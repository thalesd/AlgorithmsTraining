using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTraining.Algorithms
{
    public class BinarySearch
    {
        public void Run()
        {
            var sortedList = new List<int> { 1, 2, 3, 4, 8, 10, 12, 22, 23, 25, 44, 50 };

            Console.WriteLine(string.Join(", ", sortedList));
            Console.WriteLine("Choose a number to find.");
            int numberToFind = int.Parse(Console.ReadLine() ?? "0");

            int indexOfNumber = DivideAndConquerRecursive(sortedList, numberToFind, sortedList.Count);

            if (indexOfNumber >=0 )
                Console.WriteLine($"Found number at index {indexOfNumber} with value {sortedList[indexOfNumber]}");
            else Console.WriteLine("Desired number was not found.");
        }

        public int DivideAndConquerRecursive(List<int> sortedList, int target, int maxIndex, int minIndex = 0)
        {
            if (minIndex > maxIndex) return -1;

            int midIndex = (minIndex + maxIndex) / 2;
            if(target == sortedList[midIndex])
                return midIndex;
            else if(target > sortedList[midIndex])
                return DivideAndConquerRecursive(sortedList, target, maxIndex, midIndex+1);
            else
                return DivideAndConquerRecursive(sortedList, target, midIndex-1, minIndex);
        }
    }
}
