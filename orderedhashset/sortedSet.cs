using System.Collections.Generic;
internal class sortedSet
{
    private static void Main(string[] args)
    {
        SortedSet<string> student = new SortedSet<string>(); // SortedSet maintaining ascending order...
        student.Add("Amol");
        student.Add("Raj");
        student.Add("Abhi");
        student.Add("Sam");
        student.Add("Rahul");
        student.Add("Amol"); //Duplicate are not allow in HashSet

        foreach (string sname in student)
        {
            Console.WriteLine(sname);
        }

        Console.WriteLine("Enter element for deleting from set");
        string name= Console.ReadLine();
        student.Remove(name);

        Console.WriteLine("After Delition");

        foreach (string sname in student)
        {
            Console.WriteLine(sname);
        }



    }
}