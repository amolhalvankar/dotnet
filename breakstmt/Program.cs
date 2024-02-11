internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Break Statement");

        for (int i = 1; i <= 10 ; i++)
        {
            Console.WriteLine(i);
            if (i == 5)
                break;
            
           
        }
        Console.WriteLine("Program executed after loop breaking");
        Console.ReadLine();
    }
}