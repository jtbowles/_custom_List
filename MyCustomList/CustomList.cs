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
        //public T value;
        
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


        public /*bool*/ void Remove(T item)
        {
            bool arrayContainsItem = CheckArray(item);

            if (arrayContainsItem)
            {
                T[] temporaryArray = new T[Capacity];
                int openIndex = 0;

                for (int i = 0; i < Count; i++)
                {
                    if (item.Equals(array[i]))
                    {
                        openIndex = i;
                        break;
                    }
                    temporaryArray[i] = array[i];
                }

                for (int i = openIndex; i < Count - 1; i++)
                {
                    temporaryArray[i] = array[i + 1];
                }
                DecrementCount();
                array = temporaryArray;
            }
        }

        public override string ToString()
        {
            string runningStr = "";

            for (int i = 0; i < Count; i++)
            {
                string x = array[i].ToString();
                runningStr += x + " ";
            }
            return runningStr;
        }

        //public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        //{
        //    CustomList<T> addedList = new CustomList<T>();

        //    // for (

        //    return addedList;
        //}

        private void CheckCapacity()
        {
            if(Count == Capacity)
            {
                Capacity *= 2;
            }
        }

        private bool CheckArray(T item)
        {
            bool contains = false;

            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(array[i]))
                {
                    contains = true;
                }
            }
            return contains;
        }

        private void IncrementCount()
        {
            Count++;
        }

        private void DecrementCount()
        {
            Count--;
        }
    }
}
