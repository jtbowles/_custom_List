using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace CustomListTest
{
    [TestClass]
    public class OverloadOpSubTest
    {
        [TestMethod]
        public void OverloadOpSub_ListContainsTwoSimilarInts_ReturnsListOfOne()
        {
            // arrange
            CustomList<int> numOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> numTwo = new CustomList<int>() { 3, 4, 1 };
            CustomList<int> expectedResult = new CustomList<int>() { 2 };
            CustomList<int> actualResult;

            // act
            actualResult = numOne - numTwo;

            // assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOpSub_ListOfDifferentSizes_ReturnsListOfOne()
        {
            // arrange
            CustomList<int> numOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> numTwo = new CustomList<int>() { 3, 4 };
            CustomList<int> expectedResult = new CustomList<int>() { 4 };
            CustomList<int> actualResult;

            // act
            actualResult = numTwo - numOne;

            // assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOpSub_StringsOfMultipleOccurances_RemovesFirstInstance()
        {
            // arrange
            CustomList<string> numOne = new CustomList<string>() { "Jason", "Connor", "Scott", "Connor", "Tim" };
            CustomList<string> numTwo = new CustomList<string>() { "Tim", "Connor" };
            CustomList<string> expectedResult = new CustomList<string>() { "Jason", "Scott", "Connor" };
            CustomList<string> actualResult;

            // act
            actualResult = numOne - numTwo;

            // assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOpSub_SubtractListOfFourFromEmptyList_ReturnsEmptyList()
        {
            // arrange
            CustomList<string> numOne = new CustomList<string>() { "Jason", "Connor", "Scott", "Connor" };
            CustomList<string> numTwo = new CustomList<string>() {  };
            CustomList<string> expectedResult = new CustomList<string>() {  };
            CustomList<string> actualResult;

            // act
            actualResult = numTwo - numOne;

            // assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
    }
}
