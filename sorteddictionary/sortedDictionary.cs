internal class Program
{
    private static void Main(string[] args)
    {
        SortedDictionary<int, string> student = new SortedDictionary<int, string>();
        student.Add(2, "Amol");
        student.Add(1, "Babalu");
        student.Add(5, "Ram");
        student.Add(3, "Kedar");
        student.Add(4, "Raj");


        foreach (KeyValuePair<int, string> kv in student)
        {
            Console.WriteLine(kv.Key + "  " + kv.Value);
        }



        Console.WriteLine("Enter key for searching student");
        int i = Convert.ToInt32(Console.ReadLine());
        if (student.ContainsKey(i))
        {
            Console.WriteLine("Student name found is " + student[i]);
        }
        else
        {
            Console.WriteLine("Student name is not found");
        }


        student.Remove(i);

        Console.WriteLine("After removing student");
        foreach (KeyValuePair<int, string> kv in student)
        {
            Console.WriteLine(kv.Key + "  " + kv.Value);
        }



        Console.ReadLine();


    }
}