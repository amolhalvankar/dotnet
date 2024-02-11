internal class destructor
{
    destructor()
    {
        Console.WriteLine("Default ");
    }
    ~destructor()
    {
        Console.WriteLine("Destructor");
        Console.ReadLine();
    }
    public static void Main(string[] args)
    {
        destructor c1 = new destructor();
        Console.ReadLine();
    }
}