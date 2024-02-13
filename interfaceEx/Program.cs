internal class Program
{

    public interface A
    {
        void method1();
    }

    class B : A 
    {
        public void method1()
        {
            Console.WriteLine("Method 1");
        }
    }
    private static void Main(string[] args)
    {
        B b = new B();
        b.method1();
        Console.ReadLine();
    }
}




