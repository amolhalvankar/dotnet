
internal class funwithparam
{
    public void fun1(int i , int j)
    {
        
        int res = i + j;
        Console.WriteLine("Addition of two number is :- " +res);
    }
    private static void Main(string[] args)
    {
        Console.Write("Enter the first number : ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int m = Convert.ToInt32(Console.ReadLine());

        funwithparam obj = new funwithparam();   // object created
        obj.fun1(k,m); // passing parameter to function
        Console.ReadLine();
    }
}