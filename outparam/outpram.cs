internal class outpram
{
    public void myfun(out int i)
    {
        i = 10;
        i = i + 5;
    }
    private static void Main(string[] args)
    {
        int i = 5;
        outpram obj = new outpram();
        Console.WriteLine("Before calling the function :"+i);
        obj.myfun(out i);
        Console.WriteLine("After calling the function :" + i);
        Console.ReadLine();

        
    }
}