using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T> : IEnumerable
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

        public void Remove(T item)
        {
            bool arrayContainsItem = CheckArray(item);

            if (arrayContainsItem)
            {
                T[] temporaryArray = new T[Capacity];
                int openIndex = FindOpenIndex(item, temporaryArray);
                IndexShiftAfterRemoval(openIndex, temporaryArray);
                DecrementCount();
            }
        }

        public override string ToString()
        {
            string runningStr = "";

            for (int i = 0; i < Count; i++)
            {
                string indexToString = array[i].ToString();
                runningStr += indexToString + " ";
            }

            return runningStr;
        }

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> temporaryList = new CustomList<T>();

            temporaryList.AddToList(a, temporaryList);
            temporaryList.AddToList(b, temporaryList);

            return temporaryList;
        }

        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> sumOfLists = a + new CustomList<T>();

            for (int i = 0; i < b.Count; i++)
            {
                sumOfLists.Remove(b[i]);
            }

            return sumOfLists;
        }


        public CustomList<T> Zip(CustomList<T> passedInList)
        {
            CustomList<T> temporaryList = new CustomList<T>();
            bool listOneCountGreaterThanZero = CheckListCountGreaterThanZero(this);
            bool listTwoCountGreaterThanZero = CheckListCountGreaterThanZero(passedInList);

            if (listOneCountGreaterThanZero && listTwoCountGreaterThanZero)
            {
                CustomList<T> biggerList = CompareListCounts(this, passedInList);
                int openIndex = ZipTwoListsWithCountsGreaterThanZero(passedInList, temporaryList);

                ZipRemainingValues(openIndex, biggerList, temporaryList);
            }
            else
            {
                temporaryList = SetZippedList(passedInList, listOneCountGreaterThanZero, listTwoCountGreaterThanZero);
            }

            return temporaryList;
        }




        private bool CheckListCountGreaterThanZero(CustomList<T> passedInList)
        {
            if(passedInList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private CustomList<T> CompareListCounts(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> result = new CustomList<T>();

            if(one.Count > two.Count)
            {
                result = one;
            }
            else 
            {
                result = two;
            }

            return result;
        }

        private int ZipTwoListsWithCountsGreaterThanZero(CustomList<T> passedInList, CustomList<T> temporaryList)
        {
            int openIndex = 0;

            for (int i = 0; i < Count && i < passedInList.Count; i++)
            {
                temporaryList.Add(array[i]);
                temporaryList.Add(passedInList[i]);
                openIndex = i;
            }

            return openIndex;
        }

        private void ZipRemainingValues(int openIndex, CustomList<T> biggerList, CustomList<T> temporaryList)
        {
            for (int i = openIndex + 1; i < biggerList.Count; i++)
            {
                temporaryList.Add(biggerList[i]);
            }
        }

        private CustomList<T> SetZippedList(CustomList<T> passedInList, bool one, bool two)
        {
            CustomList<T> temporary = new CustomList<T>();

            if (one && !two)
            {
                temporary = this;
            }
            else if (!one && two)
            {
                temporary = passedInList;
            }

            return temporary;
        }

        private void CheckCapacity()
        {
            if(Count == Capacity)
            {
                Capacity *= 2;
            }
        }

       

        private static bool CheckList(T item, T comparableItem)
        {
            bool contains = false;

            if (item.Equals(comparableItem))
            {
                return true;
            }

            return contains;
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

        private int FindOpenIndex(T item, T[] temporaryArray)
        {
            int openIndex = 0;

            for (int i = 0; i < Count; i++)
            {
                bool compareItems = CompareItemToIndex(item, array[i]);

                if (compareItems)
                {
                    openIndex = i;
                    break;
                }

                temporaryArray[i] = array[i];
            }

            return openIndex;
        }

        private bool CompareItemToIndex(T item, T indexToCheck)
        {
            bool check = false;

            if (item.Equals(indexToCheck))
            {
                check = true;
            }

            return check;
        }

        private void IndexShiftAfterRemoval(int indexToStartAt, T[] temporaryArray)
        {
            for (int i = indexToStartAt; i < Count - 1; i++)
            {
                temporaryArray[i] = array[i + 1];
            }
            array = temporaryArray;
        }

        private void AddToList(CustomList<T> a, CustomList<T> temporaryList)
        {
            for (int i = 0; i < a.Count; i++)
            {
                temporaryList.Add(a[i]);
            }
        }

        private static void CompareAndRemove(T element, CustomList<T> a, CustomList<T> b)
        {
            int counter = b.Count;
            for (int i = 0; i < counter; i++)
            {
                if (element.Equals(b[i]))
                {
                    a.Remove(element);
                    b.Remove(element);
                }
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }
    }
}
