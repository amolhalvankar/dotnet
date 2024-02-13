internal class trycatchblock
{
    private static void Main(string[] args)
    {
        int i = 20;
        int j = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        try
        {
           result = i / j;
        }catch(DivideByZeroException e)
        {
            Console.WriteLine("Devide by Zero is not allowed");
        }
       Console.WriteLine("Result is = " +result);  
       Console.ReadLine();
    }
}