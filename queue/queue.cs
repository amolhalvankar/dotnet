internal class queue
{
    private static void Main(string[] args)
    {
       Queue<int> Q = new Queue<int>();  // Creating Queue 
        Q.Enqueue(1);  // Adding element in queue using Enqueue Method
        Q.Enqueue(2);
        Q.Enqueue(3);
        Q.Enqueue(4);
        Q.Enqueue(5);

        foreach (int data in Q)  // forEach loop for retriving all elements....
        {
            Console.WriteLine(data);
        }
        

        Q.Dequeue(); // Removing element form queue.
        Q.Dequeue();
        Console.WriteLine("Elements in queue after Dequeue method calling");

        foreach (int data in Q)  // forEach loop for retriving all elements after Dequeue.
        {
            Console.WriteLine(data);
        }

        Console.ReadLine();

    }

}