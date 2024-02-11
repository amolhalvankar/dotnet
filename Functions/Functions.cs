internal class Program
{
    public void fun1()
    {
        Console.WriteLine("This is fun1");
    } 
    public static void mian(String[] args)
    {
        Program obj1 = new Program(); // creating object of class
        obj1.fun1(); // calling the function using object
        Console.ReadLine();
        
    }
}