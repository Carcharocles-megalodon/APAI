using System;
using System.Collections.Generic;
using System.Text;

namespace APAIProjs
{

    class Queue
    {
        int[] storage;
        int indexplus = 0;
        int indexminus;
        
        public Queue()
        {
            storage = new int[10];
        }
        public Queue(int size)
        {
            storage = new int[size];
        }
        public void Enqueue(int addition)
        {
            
            storage[indexplus] = addition;
            indexplus++;        
        }
        public int Dequeue()
        {
            indexminus++;
            storage[indexminus] = 0;
            return storage[indexminus];
        }
        public Boolean Empty()
        {
            for(int i = 0; i < storage.Length; i++)
            {
                if (storage[i] == 0)  return true; 
            }
            return false;
        }
        public Boolean Empty(int indexed)
        {
            if (storage[indexed] == 0) return true;
            else return false;
        }

    }
    

}
