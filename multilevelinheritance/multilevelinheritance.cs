internal class multilevelinheritance
{
    public class A  // Base class
    {
     public A() 
        {
            Console.WriteLine("---Multilevel inheritance----");
        }
      public void fun1()
        {
            Console.WriteLine("Function of class A ");
        }

    }
    public class B : A  // Inheriting properties of class A
    {
        public void fun2()
        {
            Console.WriteLine("Function of class B");
        }
    }
    public class C : B // Inheriting properties of class B
    {
        public void fun3()
        {
            Console.WriteLine("Function of class C");
        }
    }  
    private static void Main(string[] args)
    {
       C obj = new C(); // Creating object of class C

        obj.fun1();
        obj.fun2();
        obj.fun3();
        Console.ReadLine();
    }
}