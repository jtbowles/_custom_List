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
        private T value;
        private int numberOfOccurances;
        
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
            numberOfOccurances = 0;
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
            T[] temporaryArray = new T[Capacity];
            

            for (int i = 0; i <= Count;)
            {
                for (int j = 0; j <= Count;)
                {
                    bool contains = ContainsItem(array[j], item);

                    if (contains)
                    {
                        //CheckOccurance();
                        //if(numberOfOccurances == 1)
                        //{
                            DecrementCount();
                            i++;
                        //}
                        //else
                        //{
                        //    temporaryArray[i] = array[j];
                        //    j++;
                        //    i++;
                        //}
                        // check if it's the first occurance ? remove : add to tempArray
                    }
                    else
                    {
                        temporaryArray[i] = array[j];
                        j++;
                        i++;
                    }

                    //if (!contains)
                    //{
                    //    temporaryArray[j] = array[i];
                    //    j++;
                    //    i++;
                    //}
                    //else if(contains && firstOccurance)
                    //{
                    //    temporaryArray[j] = array[i];
                    //    j++;
                    //    i++;
                    //}
                    //else
                    //{

                    //    DecrementCount();
                    //    i++;
                    //}
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

        private void CheckOccurance()
        {

            numberOfOccurances++;
        }

        private bool ContainsItem(T index, T item)
        {
            if(index.Equals(item))
            {
                value = item;
                return true;
            }
            else
            {
                return false;
            }
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
