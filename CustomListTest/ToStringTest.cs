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
            CustomList<int> nums = new CustomList<int>();
            string expectedResult = "1 2 3 ";
            string actualResult;

            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            actualResult = nums.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToString_EmptyListOfStrings_ReturnEmptyString()
        {
            CustomList<string> names = new CustomList<string>();
            string expectedResult = "";
            string actualResult;

            actualResult = names.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToString_ListOfEmptyStrings_ReturnsEmptySpaces()
        {
            CustomList<string> names = new CustomList<string>();
            string expectedResult = "  ";
            string actualResult;

            names.Add("");
            names.Add("");
            actualResult = names.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
