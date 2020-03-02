using System;
using System.Collections.Generic;
using System.Text;

namespace APAIProjs
{
    class DJDStack
    {
        int index = 0;
        int _size = 0;
        int[] stack;
         public DJDStack(int size)
        {
            _size = size;
            stack = new int[_size];
        }
        public DJDStack()
        {
            stack = new int[6];
        }

        public void Push(int add)
        {
            if (index>= stack.Length)
            {
                Console.WriteLine("It's too big, it won't fit!");
            }
            else
            {
                index++;
                stack[index] = add;
            }

        }
        public int Pop()
        {
            if(index <= 0)
            {
                Console.WriteLine("Too small, can't even feel it.");
                return 0;
            }
            else
            {
                return stack[index--];
            }
        }
        public int Peek()
        {
            if (index <= 0)
            {
                Console.WriteLine("Nothing there anymore, mate, it's empty.");
                return 0;
            }
            else
            {
                return stack[index];
            }
        }
    }
}

