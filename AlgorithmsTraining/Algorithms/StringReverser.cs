namespace AlgorithmsTraining.Algorithms
{
    public class StringReverser
    {
        public void Run()
        {
            Console.WriteLine("Inside String Reverser");

            Console.WriteLine("Write a string to be reversed: ");

            string StringToBeReversed = Console.ReadLine() ?? "";

            var newString = "";

            for (int i = StringToBeReversed.Length - 1; i >= 0; i--)
            {
                newString += StringToBeReversed[i];
            }

            Console.WriteLine(newString);
        }
    }
}
