internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Continue Statement");

        for(int i = 1; i <= 10; i++)
        {
            if (i == 5)
                continue;


                Console.WriteLine(i);
           
        }
        Console.WriteLine("After Loop");
        Console.ReadLine();

    }
}














