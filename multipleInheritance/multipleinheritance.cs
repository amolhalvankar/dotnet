internal class multipleInheritance
{
    public interface A
    {
        void method();
    }

    public interface B
    {
        void method();
    }

    class C : A , B 
    {
        public void method()
        {
            Console.WriteLine("Method");
        }
    }
    private static void Main(string[] args)
    {
        C c = new C();
        c.method();
        Console.ReadLine();
        
    }
}