internal class funwithreturnstmt
{
    public int fun1(int i , int j)
    {
        int res = i + j;
        return res;
    }
    private static void Main(string[] args)
    {
        Console.Write("Enter the first number : ");
        int a = Convert.ToInt32 (Console.ReadLine());
        Console.Write("Enter the Second number : ");
        int b = Convert.ToInt32(Console.ReadLine());

        funwithreturnstmt obj = new funwithreturnstmt(); // creating object
        int ans = obj.fun1(a , b); // calling function
        Console.WriteLine("Your addition of two numbers :-  " + ans);
        Console.ReadLine();
    }
}