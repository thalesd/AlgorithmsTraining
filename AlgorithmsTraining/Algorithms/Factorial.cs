using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTraining.Algorithms
{
    public class Factorial
    {
        public void Run()
        {
            Console.WriteLine("Choose a factorial number: ");

            int factorial = int.Parse(Console.ReadLine() ?? "0");

            int result = FindFactorialRecursive(factorial);

            Console.WriteLine($"Factorial of {factorial} is {result}");
        }

        public int FindFactorialRecursive(int factorial)
        {
            if(factorial == 1)
            {
                return 1;
            }

            return factorial * FindFactorialRecursive(factorial - 1);
        }
    }
}
