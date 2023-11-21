namespace AlgorithmsTraining.Algorithms
{
    public class ReverseLinkedList
    {
        public void Run()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.AddLast(1);
            myLinkedList.AddLast(2);
            myLinkedList.AddLast(3);
            myLinkedList.AddLast(4);
            myLinkedList.AddLast(5);
            myLinkedList.AddLast(6);
            myLinkedList.AddLast(7);
            myLinkedList.AddLast(8);
            myLinkedList.AddLast(9);

            Console.WriteLine("Linked list to be reversed: " + string.Join(',', myLinkedList));

            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (int item in myLinkedList)
            {
                reversedList.AddFirst(item);
            }

            Console.WriteLine("Linked list reversed: " + string.Join(',', reversedList));
        }
    }
}
