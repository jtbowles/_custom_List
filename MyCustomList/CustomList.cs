using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T>
    {
        private T[] array;
        
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public T this[int i]
        {
            get => array[i];
            set => array[i] = value;
        }

        public CustomList()
        {
            Capacity = 4;
            Count = 0;
            array = new T[Capacity];
        }

        // Call separate private methods from inside the Add()

        public void Add(T item)
        {
            CheckCapacity();
            IncrementCount();

            T[] temporaryArray = new T[Capacity];

            for (int i = 0; i < Count; i++)
            {
                if(i == Count - 1)
                {
                    temporaryArray[i] = item;
                }
                else
                {
                    temporaryArray[i] = array[i];
                }
            }
            array = temporaryArray;
        }

        private void CheckCapacity()
        {
            if(Count == Capacity)
            {
                Capacity *= 2;
            }
        }

        private void IncrementCount()
        {
            Count++;
        }
    }
}
