using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace CustomListTest
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void Zip_OddListAndEvenList_ReturnsNumericalIncrementList()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expectedResult = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> actualResult;

            actualResult = one.Zip(two);
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void Zip_ListOfDifferentCounts_ReturnsCombinedList()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4 };
            CustomList<int> expectedResult = new CustomList<int>() { 2, 1, 4, 3, 5 };
            CustomList<int> actualResult;

            actualResult = two.Zip(one);
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void Zip_ListZipsItself_ReturnsDuplicatedList()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> expectedResult = new CustomList<int>() { 1, 1, 3, 3, 5, 5 };
            CustomList<int> actualResult;

            actualResult = one.Zip(one);
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void Zip_ListOf5WithEmptyList_ReturnsFirstList()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() {  };
            CustomList<int> expectedResult = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> actualResult;

            actualResult = one.Zip(two);
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }


        [TestMethod]
        public void Zip_ZipEmptyList_ReturnsSecondList()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { };
            CustomList<int> expectedResult = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> actualResult;

            actualResult = two.Zip(one);
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

    }
}
