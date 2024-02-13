internal class throwException
{

   public class notvalidage : Exception
    {
        public notvalidage(string s) : base(s) { }
    }



    static void checkage(int age)
    {
        if (age < 18)
        {
            throw new notvalidage("Age is not valid");
        }
        else
        {
            Console.WriteLine("Age is valid. You can Vote");
        }
    }



    public static void main(string[] args)
    {
        try
        {
            checkage(25);
        }
        catch(notvalidage ne)
        {
            Console.WriteLine(ne);
        }

        Console.ReadLine();
    }
}