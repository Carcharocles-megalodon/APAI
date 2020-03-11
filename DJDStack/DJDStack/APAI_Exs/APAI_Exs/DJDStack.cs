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
            if (index>= stack.Length-1)
            {
                throw new IndexOutOfRangeException("Stack too big;");
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
                throw new InvalidOperationException ("Already empty.");
            }
            else
            {
                return stack[index--];
            }
        }
        public int Peek()
        {
            if (index < 0)
            {
                index = 0;
                throw new InvalidOperationException("Empty stack mate.");
            }
            else
            {
                return stack[index];
            }
        }
    }
}

