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
            // arrange
            CustomList<string> testOne = new CustomList<string>() { "Cousins", "Cook", "Thielen" };
            CustomList<string> testTwo = new CustomList<string>() { "Rodgers", "Jones", "Adams" };

            CustomList<string> expectedResult = new CustomList<string>() { "Cousins", "Cook", "Thielen", "Rodgers", "Jones", "Adams" };
            CustomList<string> actualResult;

            // act
            actualResult = testOne + testTwo;

            // assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOperator_TwoListsOfIntsDifferentSizes_ReturnsListOfCount5()
        {
            // arrange
            CustomList<int> one = new CustomList<int>() { 1, 2 };
            CustomList<int> two = new CustomList<int>() { 3, 4, 5 };

            CustomList<int> expectedResult = new CustomList<int>() { 3, 4, 5, 1, 2 };
            CustomList<int> actualResult = new CustomList<int>();

            // act
            actualResult = two + one;

            // assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOperator_AddListOf3ToEmptyList_ReturnListWithContents()
        {
            // arrange
            CustomList<int> one = new CustomList<int>() { };
            CustomList<int> two = new CustomList<int>() { 3, 4, 5 };

            CustomList<int> expectedResult = new CustomList<int>() { 3, 4, 5 };
            CustomList<int> actualResult;

            // act
            actualResult = one + two;

            // assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
    }
}
