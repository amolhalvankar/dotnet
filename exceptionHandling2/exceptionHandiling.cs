internal class exceptionHandling

{
    public class Notvalidage : Exception
    {
        public Notvalidage(string s) : base(s)
        {

        }
    }

    static void ckeckage(int age)
    {
        if (age < 18)
        {
            throw new Notvalidage("Age is not valid");
        }
        else
        {
            Console.WriteLine("You can vote");
        }
    }
    private static void Main(string[] args)
    {
        try
        {
            ckeckage(25);
        }
        catch(Notvalidage e)
        {
            Console.WriteLine(e);
        }
        Console.ReadLine();
    }
}