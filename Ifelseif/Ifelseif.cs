internal class Ifelseif
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter marks of Student");
        int i = Convert.ToInt32(Console.ReadLine());
        if (i >= 75)
        {
            Console.WriteLine("A Grade");

        }
        else if (i > 60 && i < 75)
        {

            Console.WriteLine("B Grade");
        }
        else
        {

            Console.WriteLine("C Grade");
        }

        Console.ReadLine();

    }
}