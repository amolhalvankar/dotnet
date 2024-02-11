internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("GoTo Statement");

    lable1:
        Console.WriteLine("Number is less than 10");
        Console.WriteLine("Enter the Number");
        int i = Convert.ToInt32(Console.ReadLine());    
        if (i < 10)
        {
            goto lable1;
        }
        else
        {
            Console.WriteLine("Number is greater than 10");
        }

        Console.ReadLine();
    }
}