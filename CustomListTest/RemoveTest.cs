using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace CustomListTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void Remove_StringMy_IndeciesShifted()
        {
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "Name";
            string actualResult;

            list.Add("Hello");
            list.Add("My");
            list.Add("Name");
            list.Add("Is");
            list.Add("YeaBoi");
            list.Remove("My");
            actualResult = list[1];
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_TwoDifferentInts_ElemenIndexChanges()
        {
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 3;
            int actualResult;

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(2);
            list.Remove(1);
            actualResult = list[0];
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_StringHello_RemovesFirstInstance()
        {
            CustomList<string> list = new CustomList<string>();
            int expectedResult = 2;
            int actualResult;

            list.Add("Hello");
            list.Add("Hello");
            list.Add("Hello");
            list.Remove("Hello");
            actualResult = list.Count;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_Int3_RemovesFirstInstance()
        {
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 3;
            int actualResult;

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(3);
            list.Add(4);
            list.Remove(3);
            actualResult = list[4];
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_IntNotInTheList_ListIsUnaffected()
        {
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 3;
            int actualResult;

            list.Add(30);
            list.Add(11);
            list.Add(23);
            list.Remove(35);
            actualResult = list.Count;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
