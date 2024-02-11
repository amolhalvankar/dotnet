internal class callbyvaluefun1
{
    public void myfun(int val)
    {
        val = val + 10;
        Console.WriteLine("Value in function : " +val);
    }
    private static void Main(string[] args)
    {
        callbyvaluefun1 obj = new callbyvaluefun1(); // crwating object of class

        int val = 10;
        Console.WriteLine("value before calling function : " + val);
        obj.myfun(val);
        Console.WriteLine("Value after calling function : " + val);
        Console.ReadLine();
    }
}




