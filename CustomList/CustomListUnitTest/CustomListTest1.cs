using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class CustomListTest1
    {
        [TestMethod]
        public void Add_FirstValue_OneItemInList()
        {
            List<int> CustomList = new List<int>();
            int firstValue = 1;

            CustomList.Add(firstValue);

            Assert.AreEqual(firstValue, CustomList[0]);
        }

        [TestMethod]
        public void Add_SecondValue_TwoItemsInList()
        {
            List<int> CustomList = new List<int>();
            int firstValue = 1;
            int secondValue = 2;

            CustomList.Add(firstValue);
            CustomList.Add(secondValue);

            Assert.AreEqual(secondValue, CustomList[1]);
        }

        [TestMethod]
        public void Add_ThreeValues_CheckCount()
        {
            List<int> CustomList = new List<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            int expectedResult = 3;

            CustomList.Add(firstValue);
            CustomList.Add(secondValue);
            CustomList.Add(thirdValue);
            int actualResult = CustomList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_CapacityToArray_True()
        {
            List<int[]> CustomList = new List<int[]>();
            int array[] = new Array;
            int array1[] = { 1, 2 };
            int array2[] = { 3, 4 };

            Assert.AreEqual(CustomList[0], array1);

        }

        [TestMethod]
        public void Remove_FirstValue_True()
        {
            List<int> CustomList = new List<int>();
            int firstValue = 1;

            CustomList.Remove(firstValue);

            Assert.AreEqual(firstValue, true);
        }

        [TestMethod]
        public void Remove_SecondValue_IndexChange()
        {
            List<int> CustomList = new List<int>();

            CustomList.Add(1);
            CustomList.Add(2);
            CustomList.Remove(1);

            Assert.AreEqual(2, CustomList[0]);
        }

        [TestMethod]
        public void ToString_FirstValue_ReturnString()
        {
            List<int> CustomList = new List<int>();
            int firstValue = 1;
            string expectedResult = "1";

            CustomList.Add(firstValue);
            string actualResult = CustomList.ToString(firstValue);

            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}
