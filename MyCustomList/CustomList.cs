using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T>
    {
        public T[] array;
        T value;

        public int Count { get; }
        public int Capacity { get; set; }

        public T this[int i]
        {
            get => array[i];
            set => array[i] = value;
        }

        public CustomList()
        {
            Capacity = 0;
            Count = 0;
            array = new T[Capacity];
        }

        // Call separate private methods from inside the Add()

        public void Add(T item)
        {
            T[] temporaryArray = new T[Capacity];
            if(Count == 0)
            {
                temporaryArray[0] = item;
                array = temporaryArray;
            }
        }
    }
}
