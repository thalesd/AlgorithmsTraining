using AlgorithmsTraining.Algorithms;

internal class Program
{
    public enum ImplementedAlgorithms
    {
        StringReverser = 1,
        CombineOrderedArrays,
        FindDuplicateItemInList,
        ReverseLinkedList,
        Factorial,
        Fibonacci,
        BubbleSort,
        SelectionSort,
        InsertionSort,
        MergeSort
    }

    private static void Main(string[] args)
    {
        ImplementedAlgorithms algorithmChosen = 0;

        while (algorithmChosen == 0)
        {
            Console.WriteLine("----- Algorithms -----");
            Console.WriteLine("1 - String Reverser");
            Console.WriteLine("2 - Combine Ordered Arrays");
            Console.WriteLine("3 - Find Duplicate Item In List");
            Console.WriteLine("4 - Reverse Linked List");
            Console.WriteLine("5 - Factorial");
            Console.WriteLine("6 - Fibonacci");
            Console.WriteLine("7 - Bubble Sort");
            Console.WriteLine("8 - Selection Sort");
            Console.WriteLine("9 - Insertion Sort");
            Console.WriteLine("10 - Merge Sort");
            Console.WriteLine("");
            Console.WriteLine("Coose the algorithm to be ran [1...N]:");
            algorithmChosen = (ImplementedAlgorithms)int.Parse(Console.ReadLine() ?? "0");
        }

        switch (algorithmChosen)
        {
            case ImplementedAlgorithms.StringReverser:
                Console.WriteLine("String Reverser");
                new StringReverser().Run();
                break;
            case ImplementedAlgorithms.CombineOrderedArrays:
                Console.WriteLine("Combine Ordered Arrays");
                new CombineOrderedArrays().Run();
                break;
            case ImplementedAlgorithms.FindDuplicateItemInList:
                Console.WriteLine("Find Duplicate Item In List");
                new FindDuplicatedItemInList().Run();
                break;
            case ImplementedAlgorithms.ReverseLinkedList:
                Console.WriteLine("Reverse Linked List");
                new ReverseLinkedList().Run();
                break;
            case ImplementedAlgorithms.Factorial:
                Console.WriteLine("Factorial");
                new Factorial().Run();
                break;
            case ImplementedAlgorithms.Fibonacci:
                Console.WriteLine("Fibonacci");
                new Fibonacci().Run();
                break;
            case ImplementedAlgorithms.BubbleSort:
                Console.WriteLine("Bubble Sort");
                new BubbleSort().Run();
                break;
            case ImplementedAlgorithms.SelectionSort:
                Console.WriteLine("Selection Sort");
                new SelectionSort().Run();
                break;
            case ImplementedAlgorithms.InsertionSort:
                Console.WriteLine("Insertion Sort");
                new InsertionSort().Run();
                break;
            case ImplementedAlgorithms.MergeSort:
                Console.WriteLine("Merge Sort");
                new MergeSort().Run();
                break;
            default:
                break;
        }
    }
}