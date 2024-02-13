internal class abstractMethod
{
    public abstract class A
    {
        public abstract void method1();
     

        public void method2()
        {
            Console.WriteLine("Method 2");
        }
    }

    class B : A
    {
        public override void method1()
        {
            Console.WriteLine("Method 1");
        }
    }

    private static void Main(string[] args)
    {
        A b = new B();

        b.method1();
        b.method2();

        Console.ReadLine();
        
    }
}