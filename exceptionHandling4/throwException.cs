internal class throwException
{
    public class Notvalidage : Exception
    {
        public Notvalidage(string s): base(s) { }
    }

    static void checkage(int age)
    {
        if (age < 18) 
        {
            throw new Notvalidage("Age is not valid");
        }
        else
        {
            Console.WriteLine("Age is valid. You can vote!");
        }
    }
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            checkage(age);
        }
        catch(Notvalidage ne)
        {
            Console.WriteLine(ne);
        }

        Console.ReadLine();
    }
}















