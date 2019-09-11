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
            int actuaResult;

            // act
            list.Add(15);
            actuaResult = list.Count;

            // assert
            Assert.AreEqual(expectedResult, actuaResult);
        }

        [TestMethod]
        public void Add_IntOf15_IndexHoldsValue()
        {
            // arrange
            CustomList<int> list = new CustomList<int>();
            int expectedResult = 15;
            int actuaResult;

            // act
            list.Add(15);
            actuaResult = list[0];

            // assert
            Assert.AreEqual(expectedResult, actuaResult);
        }

        [TestMethod]
        public void Add_NegativeDoubles_IndexerAt()
        {
            // arrange
            CustomList<double> list = new CustomList<double>();
            double expectedResult = -4.7;
            double actuaResult;

            // act
            list.Add(-1.2);
            list.Add(-3.5);
            list.Add(-4.7);
            actuaResult = list[2];

            // assert
            Assert.AreEqual(expectedResult, actuaResult);
        }

        [TestMethod]
        public void Add_String_CapacityIncreases()
        {
            // arrange
            CustomList<string> list = new CustomList<string>() {"Brady", "Mahomes", "Mayfield", "Wentz"};
            int expectedResult = 8;
            int actualResult;

            // act
            list.Add("Cousins");
            actualResult = list.Capacity;

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_FourStrings_ReturnsTrue()
        {
            // arrange
            CustomList<string> list = new CustomList<string>();
            bool actualResult;

            // act
            list.Add("Brady");
            list.Add("Mahomes");
            list.Add("Mayfield");
            list.Add("Cousins");
            actualResult = list.Capacity == list.Count;

            // assert
            Assert.IsTrue(actualResult);
        }
    }
}
