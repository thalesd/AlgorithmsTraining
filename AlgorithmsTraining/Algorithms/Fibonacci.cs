namespace AlgorithmsTraining.Algorithms
{
    public class Fibonacci
    {
        public void Run()
        {
            Console.WriteLine("Choose a number");

            long num = long.Parse(Console.ReadLine() ?? "1");

            long result = RecursiveFindFibonacciOf(num, new Dictionary<long, long>());

            Console.WriteLine($"Fibonacci of {num} is: " + result);
        }

        public long RecursiveFindFibonacciOf(long num, Dictionary<long, long> memoizedResults)
        {
            if(memoizedResults.TryGetValue(num, out long result))
            {
                Console.WriteLine(result);
                return result;
            }

            if (num < 2)
            {
                memoizedResults.TryAdd(num, num);
            }
            else
            {
                memoizedResults.TryAdd(num, RecursiveFindFibonacciOf(num - 1, memoizedResults) + RecursiveFindFibonacciOf(num - 2, memoizedResults));
            }

            return memoizedResults.GetValueOrDefault(num);
        }
    }
}
