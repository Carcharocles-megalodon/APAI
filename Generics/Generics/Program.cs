using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int stackorqueuelength = 18;
            var StringStackDefault = new DJDStack<string>();
            var StringStackChosen = new DJDStack<string>(stackorqueuelength);
            var intstackD = new DJDStack<int>();
            var intstackC = new DJDStack<int>(stackorqueuelength);
            var queuestring = new Queue<string>(stackorqueuelength);

            try
            {
                for (int i = 0; i < stackorqueuelength; i++)
                {
                    if (i > StringStackDefault._size)
                    /*{
                        throw new InvalidOperationException("Stack Full");
                    }
                    StringStackDefault.Push(i + " ugly duckling ");*/
                    StringStackChosen.Push(i + " ugly duckling ");
                    queuestring.Enqueue(i + "ugly duckling");
                }
                StringStackDefault.Push("The ugly duckling");
                StringStackDefault.Peek();
                StringStackDefault.Pop();
                StringStackChosen.Peek();
                StringStackChosen.Pop();
                queuestring.Dequeue();
                queuestring.Peek();

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
