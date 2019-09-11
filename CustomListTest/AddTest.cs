using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace CustomListTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void Add_IntOf15_CountIncreases()
        {
            // arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 1;
            int actualResult;

            // act
            list.Add(15);
            actualResult = list.Count;

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_IntOf15_IndexHoldsValue()
        {
            // arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 15;
            int actualResult;

            // act
            list.Add(15);
            actualResult = list[0];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_5Ints_ResultAtIndex3()
        {
            // arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 11;
            int actualResult;

            // act
            list.Add(15);
            list.Add(11);
            list.Add(9);
            list.Add(83);
            list.Add(92);
            actualResult = list[1];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_9Strings_ResultAtIndexSix()
        {
            // arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "Bell";
            string actualResult;

            // act
            list.Add("Kamara");
            list.Add("Barkley");
            list.Add("McCaffrey");
            list.Add("Chubb");
            list.Add("Cook");
            list.Add("Carson");
            list.Add("Bell");
            list.Add("Gurley II");
            list.Add("Peterson");
            actualResult = list[6];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_9Strings_CountIsNine()
        {
            // arrange
            CustomList<string> list = new CustomList<string>();
            int expectedResult = 9;
            int actualResult;

            // act
            list.Add("Kamara");
            list.Add("Barkley");
            list.Add("McCaffrey");
            list.Add("Chubb");
            list.Add("Cook");
            list.Add("Carson");
            list.Add("Bell");
            list.Add("Gurley II");
            list.Add("Peterson");
            actualResult = list.Count;

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
