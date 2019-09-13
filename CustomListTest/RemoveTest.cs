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
            // arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "Name";
            string actualResult;

            // act
            list.Add("Hello");
            list.Add("My");
            list.Add("Name");
            list.Add("Is");
            list.Add("YeaBoi");
            list.Remove("My");
            actualResult = list[1];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_TwoDifferentInts_ElemenIndexChanges()
        {
            // arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 3;
            int actualResult;

            // act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(2);
            list.Remove(1);
            actualResult = list[0];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_StringHello_RemovesFirstInstance()
        {
            // arrange
            CustomList<string> list = new CustomList<string>();
            int expectedResult = 2;
            int actualResult;

            // act
            list.Add("Hello");
            list.Add("Hello");
            list.Add("Hello");
            list.Remove("Hello");
            actualResult = list.Count;

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_Int3_RemovesFirstInstance()
        {
            // arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 3;
            int actualResult;

            // act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(3);
            list.Add(4);
            list.Remove(3);
            actualResult = list[4];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_IntNotInTheList_ListIsUnaffected()
        {
            // arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 3;
            int actualResult;

            // act
            list.Add(30);
            list.Add(11);
            list.Add(23);
            list.Remove(35);
            actualResult = list.Count;

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test69()
        {
            // arrange
            CustomList<string> allStar = new CustomList<string>();
            string expectedResult = "Cook";
            string actualResult;

            // act
            allStar.Add("Rodgers");
            allStar.Add("Wilson");
            allStar.Add("Brady");
            allStar.Add("Vick");
            allStar.Add("Favre");
            allStar.Add("Starr");
            allStar.Add("McNabb");
            allStar.Add("Cook");

            allStar.Remove("Favre");
            allStar.Remove("Starr");
            allStar.Remove("McNabb");

            actualResult = allStar[4];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
