using System.Collections.Generic;
internal class List
{
    private static void Main(string[] args)
    {
      

        var student = new List<string>(); // List is created that can storing string elements..

        student.Add("Amol");
        student.Add("Raj");   
        student.Add("Sam");   
        student.Add("Yellesh");   
        student.Add("Mauli");   
        student.Add("Patya");
        student.Add("Mauli");

        foreach (var name in student) 
        {
            Console.WriteLine(name);
        }


        Console.ReadLine();
    }
}