internal class Program
{
    private static void Main(string[] args)
    {
        int n = 5;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1;j <= n-i;j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" "+i);
                
            }
            Console.WriteLine();
        }
       
    }
}






