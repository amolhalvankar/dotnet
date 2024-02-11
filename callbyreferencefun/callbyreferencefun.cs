internal class callbyreferencefun
{
    public void myfun(ref int val)
    {
        val = val + 10;
        Console.WriteLine("value in function : " + val);
    }
    private static void Main(string[] args)
    {
        callbyreferencefun obj = new callbyreferencefun();
        int val = 10;
        Console.WriteLine("value before calling function : " + val);
        obj.myfun(ref val);
        Console.WriteLine("value after calling function : " + val);
        Console.ReadLine();
    }
}