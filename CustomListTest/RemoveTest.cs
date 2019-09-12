using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace CustomListTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            CustomList<string> list = new CustomList<string>();
            string expectedResult = "Name";
            string actualResult;

            // act
            list.Add("Hello");
            list.Add("My");
            list.Add("Name");
            list.Add("Is");
            list.Add("YeaBoi");
            list.Remove("My");
            actualResult = list[1];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange

            // act

            // assert
        }

        [TestMethod]
        public void TestMethod3()
        {
            // arrange

            // act

            // assert
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
    }
}
