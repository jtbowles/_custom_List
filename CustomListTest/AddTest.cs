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
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 1;
            int actualResult;

            list.Add(15);
            actualResult = list.Count;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_IntOf15_IndexHoldsValue()
        {
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 15;
            int actualResult;

            list.Add(15);
            actualResult = list[0];
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_5Ints_ResultAtIndex3()
        {
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 11;
            int actualResult;

            list.Add(15);
            list.Add(11);
            list.Add(9);
            list.Add(83);
            list.Add(92);
            actualResult = list[1];
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_9Strings_ResultAtIndexSix()
        {
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "Bell";
            string actualResult;

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
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_9Strings_CountIsNine()
        {
            CustomList<string> list = new CustomList<string>();
            int expectedResult = 9;
            int actualResult;

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
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
