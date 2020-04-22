using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class DJDStack <T>
    {
        int index = 0;
        public int _size = 0;
        T [] stack;
         public DJDStack(int size)
        {
            _size = size;
            stack = new T [_size];
        }
        public DJDStack()
        {
            stack = new T [6];
        }

        public void Push(T add)
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
        public T Pop()
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
        public T Peek()
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

