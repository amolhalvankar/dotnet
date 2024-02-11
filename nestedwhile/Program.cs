internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;
        while (i <= 3)
        {
            Console.WriteLine("i for j");

            int j = 1;
            while (j <= 4)
            {
                Console.WriteLine(i+ " " + j);
                j++;
            }
            i++;
        }
    }
}