internal class Program
{
    public class A
    {
        //Method Overloading with different parameter...
        public void method()
        {
            Console.WriteLine("Method with no paremeter :");
        }
        public void method(int i, int j)
        {
            Console.WriteLine("Method with parameter :" +(i + j));
            Console.WriteLine();
        }
    }

    public class B
    {
        //Method Overloading with different data members
        public void Method(int i) 
        {
            Console.WriteLine(i+ ": Method with int parameter");
        }

        public void Method(float j)
        {
            Console.WriteLine(j + ": Method with float parameter");
        }
    }
  
    private static void Main(string[] args)
    {
        A obj = new A(); // object creating of class A
        B obj1 = new B(); // object creating of class B

        obj.method();          
        obj.method(5, 6);

        obj1.Method(5);
        obj1.Method(3.6f);

        Console.ReadLine();
    }
}