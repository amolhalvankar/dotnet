internal class Program
{
    class student
    {
        int i;
        student()
        {
            Console.WriteLine("This is defualt constructor..."+i);
        }


        private static void Main(string[] args)
        {
            student s = new student();
            Console.ReadLine();
        }
       
    }


      
}