internal class Program
{
    // single level inheritance ex

    public class A
    {
       public  int a = 10;
      
       
    }

    public class B : A
    {
        int b = 20;

        public void fun()
        {
            int res =  a + b;
            Console.WriteLine("Addtion of two numbers :" +res);
        }
    }
    private static void Main(string[] args)
    {
        B obj = new B();
        obj.fun();
        Console.ReadLine();
    }
}