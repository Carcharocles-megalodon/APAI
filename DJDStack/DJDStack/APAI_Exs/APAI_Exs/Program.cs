using System;

namespace APAIProjs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            DJDStack stack = new DJDStack(10);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    stack.Push(r.Next(0, 100));
                }

                stack.Peek();
                stack.Pop();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
        }
    }
}
