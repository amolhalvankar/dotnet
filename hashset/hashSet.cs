internal class hashSet
{
    private static void Main(string[] args)
    {
       HashSet<string> student = new HashSet<string>(); // Creating HashSet for student
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

        
        Console.WriteLine("Enter name to remove from set");
        string s = Console.ReadLine();
        student.Remove(s);

        Console.WriteLine("After Delition");
        foreach (string sname in student)
        {
            Console.WriteLine(sname);
        }


        Console.ReadLine();



    }
}