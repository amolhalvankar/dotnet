internal class Program
{
    private static void Main(string[] args)
    {
        int i = 2;
        do { 
            Console.WriteLine(i);
            i = i + 2; 
        }while (i <= 20);
        Console.ReadLine();
    }
}