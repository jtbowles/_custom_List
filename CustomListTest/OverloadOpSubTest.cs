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
            CustomList<int> numOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> numTwo = new CustomList<int>() { 3, 4, 1 };
            CustomList<int> expectedResult = new CustomList<int>() { 2 };
            CustomList<int> actualResult;

            actualResult = numOne - numTwo;
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOpSub_ListOfDifferentSizes_ReturnsListOfOne()
        {
            CustomList<int> numOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> numTwo = new CustomList<int>() { 3, 4 };
            CustomList<int> expectedResult = new CustomList<int>() { 4 };
            CustomList<int> actualResult;

            actualResult = numTwo - numOne;
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOpSub_StringsOfMultipleOccurances_RemovesFirstInstance()
        {
            CustomList<string> nameOne = new CustomList<string>() { "Jason", "Connor", "Scott", "Connor", "Tim" };
            CustomList<string> nameTwo = new CustomList<string>() { "Tim", "Connor" };
            CustomList<string> expectedResult = new CustomList<string>() { "Jason", "Scott", "Connor" };
            CustomList<string> actualResult;

            actualResult = nameOne - nameTwo;
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void OverloadOpSub_SubtractListOfFourFromEmptyList_ReturnsEmptyList()
        {
            CustomList<string> numOne = new CustomList<string>() { "Jason", "Connor", "Scott" };
            CustomList<string> numTwo = new CustomList<string>() { "Nelson", "Connor", "Scott"};
            CustomList<string> expectedResult = new CustomList<string>() { "Nelson" };
            CustomList<string> actualResult;

            actualResult = numTwo - numOne;
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
    }
}
