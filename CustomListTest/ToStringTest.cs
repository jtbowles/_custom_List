using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace CustomListTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ToString_ListOfInts_ReturnsValuesWithASpace()
        {
            // arrange
            CustomList<int> nums = new CustomList<int>();
            string expectedResult = "1 2 3 ";
            string actualResult;

            // act
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            actualResult = nums.ToString();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToString_EmptyListOfStrings_ReturnEmptyString()
        {
            // arrange
            CustomList<string> names = new CustomList<string>();
            string expectedResult = "";
            string actualResult;

            // act
            actualResult = names.ToString();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToString_ListOfEmptyStrings_ReturnsEmptySpaces()
        {
            // arrange
            CustomList<string> names = new CustomList<string>();
            string expectedResult = "  ";
            string actualResult;

            // act
            names.Add("");
            names.Add("");
            actualResult = names.ToString();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void TestMethod5()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void TestMethod6()
        {
            // arrange

            // act

            // assert
        }
    }
}
