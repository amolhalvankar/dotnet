internal class exceptionHandling
{
    private static void Main(string[] args)
    {
        int i = 25;
        Console.Write("Enter the number for dividing value of i : ");
        int j = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        try
        {
            result = i / j;
        }catch(Exception ex)
        {
            Console.WriteLine("Divide by zero is not allowed");
        }

        finally
        {
            Console.WriteLine("This is finally block");
        }
      
        Console.WriteLine("Result is :" +result);
        Console.ReadLine();

       
    }
}