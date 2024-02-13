using System.Collections;
internal class linkedList
{
    private static void Main(string[] args)
    {
       var student = new LinkedList<string>();

        student.AddLast("a");
        student.AddLast("b");
        student.AddFirst("c");

        LinkedListNode<string> node = student.Find("b");
        student.AddBefore(node, "k");
        student.AddAfter(node, "m");

        foreach (string sname in student)
        {
            Console.WriteLine(sname);
        }
        
        Console.ReadLine();
    }
}