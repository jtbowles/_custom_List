using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace CustomListTest
{
    [TestClass]
    public class OverloadOpAddTest
    {
        [TestMethod]
        public void OverloadOperator_ListOfStringTeams_ReturnsListOfBothTeams()
        {
            CustomList<string> testOne = new CustomList<string>() { "Cousins", "Cook", "Thielen" };
            CustomList<string> testTwo = new CustomList<string>() { "Rodgers", "Jones", "Adams" };
            CustomList<string> expectedResult = new CustomList<string>() { "Cousins", "Cook", "Thielen", "Rodgers", "Jones", "Adams" };
            CustomList<string> actualResult;

            actualResult = testOne + testTwo;
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOperator_TwoListsOfIntsDifferentSizes_ReturnsListOfCount5()
        {
            CustomList<int> one = new CustomList<int>() { 1, 2 };
            CustomList<int> two = new CustomList<int>() { 3, 4, 5 };
            CustomList<int> expectedResult = new CustomList<int>() { 3, 4, 5, 1, 2 };
            CustomList<int> actualResult = new CustomList<int>();

            actualResult = two + one;
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOperator_AddListOf3ToEmptyList_ReturnListWithContents()
        {
            CustomList<int> one = new CustomList<int>() { };
            CustomList<int> two = new CustomList<int>() { 3, 4, 5 };
            CustomList<int> expectedResult = new CustomList<int>() { 3, 4, 5 };
            CustomList<int> actualResult;

            actualResult = one + two;
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
    }
}
