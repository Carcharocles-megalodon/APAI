using System;

namespace APAIProjs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Queue Q = new Queue(10);
            for(int i = 0; i < 10; i++)
            {
                Q.Enqueue(i);
            }
            Console.WriteLine(Q.Dequeue());
            Console.WriteLine(Q.Dequeue());
            Console.WriteLine(Q.Empty(0));
            Console.WriteLine(Q.Empty(1));
        }
    }
}
