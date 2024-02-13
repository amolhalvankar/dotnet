using System.Collections.Generic;
using System.Collections;
internal class stack
{
    private static void Main(string[] args)
    {
        Stack <int> st = new Stack<int>();
        st.Push(1);
        st.Push(2);
        st.Push(3);
        st.Push(4);
        st.Push(5);

        foreach(int Value in st)
        {
            Console.WriteLine(Value);   
        }


        Console.WriteLine("Value in stack after pop method");

        st.Pop();
        st.Pop();

        foreach (int Value in st)
        {
            Console.WriteLine(Value);
        }

        Console.ReadLine();

    }

}