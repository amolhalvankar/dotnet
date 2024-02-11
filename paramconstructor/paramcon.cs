
internal class paramcon
{
    
        paramcon(int i , int j)
        {
            Console.WriteLine(i + j);
        }

        private static void Main(string[] args)
        {
            paramcon pc = new paramcon(1, 2);
            Console.ReadLine();
        }
    
    
}