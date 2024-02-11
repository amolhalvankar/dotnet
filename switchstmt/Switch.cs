internal class Switch
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int j = Convert.ToInt32(Console.ReadLine());

        int result = 0;

        Console.WriteLine("Enter the Operation to perform +,-,/,*");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = i + j;
                break;

            case '-':
                result = i - j;
                break;

            case '/':
                result = i / j;
                break;

            case '*':
                result = i * j;
                break;

            default:
                Console.WriteLine("You have entered wrong choice..");
                break;

        }
        Console.WriteLine("Result is = " + result);
        Console.ReadLine();
    }
}