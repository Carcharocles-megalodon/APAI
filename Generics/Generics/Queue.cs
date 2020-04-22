using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{

    class Queue<T>
    {
        T [] storage;
        int indexplus = 0;
        int indexminus;
        
        public Queue()
        {
            storage = new T[10];
        }
        public Queue(int size)
        {
            storage = new T[size];
        }
        public void Enqueue(T addition)
        {
            
            storage[indexplus] = addition;
            indexplus++;        
        }
        public T Dequeue()
        {
            indexminus++;
            return storage[indexminus];
        }
        public  T Peek()
        {
            if (indexminus < 0)
            {
                throw new InvalidOperationException("Empty stack mate.");
            }
            else
            {
                return storage[indexminus];
            }
        }
      

    }
    

}
