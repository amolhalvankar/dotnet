internal class funwithreturnstmt1
{
    public int myfun(int x , int y)
    {
        int result = x * y;
        return result;
    }
    private static void Main(string[] args)
    {
        Console.Write("Enter the first number : ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number : ");
        int b = Convert.ToInt32(Console.ReadLine());

        funwithreturnstmt1 obj = new funwithreturnstmt1(); // creating object of class
        int mul = obj.myfun(a , b); // calling function using object 

        Console.WriteLine("Multiplication of two numbers : " + mul);
        Console.ReadLine();
    }
}