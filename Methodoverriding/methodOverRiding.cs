internal class methodOverRiding
{
    public class A
    {
        public virtual void method()
        {
            Console.WriteLine("Method of base class");
        }
    }

    public class B : A
    {
        public override void method()
        {
            Console.WriteLine("Method of derived class");
        }
    }
    private static void Main(string[] args)
    {
       B obj = new B();
       obj.method();
        Console.ReadLine();
    }
}









