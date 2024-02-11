internal class conoverloading
{
    conoverloading()
    {
        Console.WriteLine("This is defualt constructor..");
    }

    conoverloading(int i , int j)
    {
        Console.WriteLine("Parameterized Constructor :" + (i+j));
    }
    private static void Main(string[] args)
    {
        conoverloading con1 = new conoverloading();
        conoverloading con2 = new conoverloading(5,8);
        Console.ReadLine();
     
    }
}