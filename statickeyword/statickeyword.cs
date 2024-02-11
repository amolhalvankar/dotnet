internal class statickeyword
{
    static int count = 0;

    void add()
    {
        count ++;
        Console.WriteLine("Student of Class :" + count);
    }
    private static void Main(string[] args)
    {
        statickeyword s1 = new statickeyword();
        statickeyword s2 = new statickeyword(); 

        s1.add();
        s2.add();

        Console.ReadLine();
    }
}