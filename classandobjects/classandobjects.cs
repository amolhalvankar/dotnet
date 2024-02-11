internal class Program
{
    public class Student
    {
        int id;
        string name;

        public void get(int i , string s)
        {
            id = i;
            name = s;   
        }

        public void show()
        {
            Console.WriteLine("Id is : " + id + " Student name is :" + name);
        }
    }
    private static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student();
        s1.get(1, "Amol");
        s2.get(2, "Raj");
        s1.show();
        s2.show();
        Console.ReadLine();
    }
}