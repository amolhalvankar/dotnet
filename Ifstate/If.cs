internal class If
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number for Test");
        int i = Convert.ToInt32(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.WriteLine("Number is Even");
            Console.ReadLine();
        }
    }
}


