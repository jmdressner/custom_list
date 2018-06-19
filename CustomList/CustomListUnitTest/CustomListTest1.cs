﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class CustomListTest1
    {
        // Add Method Tests ------------------------------------
        [TestMethod]
        public void Add_FirstValue_OneItemInList()
        {
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;

            customList.Add(firstValue);

            Assert.AreEqual(firstValue, customList[0]);
        }

        [TestMethod]
        public void Add_SecondValue_TwoItemsInList()
        {
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;

            customList.Add(firstValue);
            customList.Add(secondValue);

            Assert.AreEqual(secondValue, customList[1]);
        }

        [TestMethod]
        public void Add_ThreeValues_CheckCount()
        {
            CustomList<int> customList = new CustomList<int>();
            int expectedResult = 3;

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            int actualResult = customList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_Array_ArrayInList()
        {
            CustomList<Array> customList = new CustomList<Array>();
            int [] inputValue = new int[] { };

            customList.Add(inputValue);

            Assert.AreEqual(customList[0], inputValue);
        }

        [TestMethod]
        public void Add_CapacityToArray_CheckCapacity()
        {
            CustomList<int> customList = new CustomList<int>();
            int expectedResult = 10;

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            int actualResult = customList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }

        // Remove Method Tests ------------------------------------
        [TestMethod]
        public void Remove_FirstValue_True()
        {
            CustomList<int> customList = new CustomList<int>();

            customList.Add(1);
            bool actualResult = customList.Remove(1);

            Assert.AreEqual(actualResult, true);
        }

        [TestMethod]
        public void Remove_SecondValue_True()
        {
            CustomList<int> customList = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            bool actualResult = customList.Remove(2);

            Assert.AreEqual(actualResult, true);
        }

        [TestMethod]
        public void Remove_SecondValue_CheckCount()
        {
            CustomList<int> customList = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Remove(2);
            int expectedResult = 1;

            int actualResult = customList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_ValueNotPresent_False()
        {
            CustomList<int> customList = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            bool actualResult = customList.Remove(3);

            Assert.AreEqual(actualResult, false);
        }

        // ToString Method Tests --------------------------------
        [TestMethod]
        public void ToString_FirstValue_ReturnString()
        {
            CustomList<int> customList = new CustomList<int>();
            string expectedResult = "1";

            customList.Add(1);
            string actualResult = customList.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToString_SecondValue_ReturnString()
        {
            CustomList<int> customList = new CustomList<int>();
            string expectedResult = "1, 2";

            customList.Add(1);
            customList.Add(2);
            string actualResult = customList.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToString_Count_CheckIfItStaysTheSame()
        {
            CustomList<int> customList = new CustomList<int>();
            int expectedResult = 2;

            customList.Add(1);
            customList.Add(2);
            customList.ToString();
            int actualResult = customList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        // Overload + Operator Method Tests --------------------
        [TestMethod]
        public void OverloadPlusOperator_AddTwoLists_CheckCount()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expectedResult = 4;

            customList.Add(1);
            customList.Add(2);
            customList2.Add(3);
            customList2.Add(4);
            CustomList<int> resultList = customList + customList2;
            int actualResult = resultList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddTwoLists_CheckValueAtIndex2()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList2.Add(3);
            customList2.Add(4);
            CustomList<int> resultList = customList + customList2;

            Assert.AreEqual(3, resultList[2]);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddTwoLists_CheckValueAtIndex0()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList2.Add(3);
            customList2.Add(4);
            CustomList<int> resultList = customList + customList2;

            Assert.AreEqual(1, resultList[0]);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddEmptyList_CheckValueAtIndex4()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            CustomList<int> resultList = customList + customList2;

            Assert.AreEqual(0, resultList[4]);
        }

        [TestMethod]
        public void OverloadPlusOperator_AddTwoLists_CheckCapacity()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expectedResult = 10;

            customList.Add(1);
            customList.Add(2);
            customList2.Add(3);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            CustomList<int> resultList = customList + customList2;
            int actualResult = resultList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }

        // Overload - Operator Method Tests -----------------------
        [TestMethod]
        public void OverloadMinusOperator_TwoLists_CheckCount()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expectedResult = 3;

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList2.Add(3);
            customList2.Add(5);
            CustomList<int> subtractedList = customList - customList2;
            int actualResult = subtractedList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadMinusOperator_TwoLists_CheckValueAtIndex2()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList2.Add(3);
            customList.Add(5);
            CustomList<int> subtractedList = customList - customList2;

            Assert.AreEqual(4, subtractedList[2]);
        }

        [TestMethod]
        public void OverloadMinusOperator_TwoLists_CheckValueAtIndex0()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList2.Add(3);
            customList2.Add(5);
            CustomList<int> subtractedList = customList - customList2;

            Assert.AreEqual(1, subtractedList[0]);
        }

        [TestMethod]
        public void OverloadMinusOperator_EmptyList_CheckValueAtIndex4()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            CustomList<int> subtractedList = customList - customList2;

            Assert.AreEqual(0, subtractedList[4]);
        }

        [TestMethod]
        public void OverloadMinusOperator_TwoLists_CheckCapacity()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expectedResult = 5;

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            customList2.Add(1);
            customList2.Add(4);
            CustomList<int> subtractedList = customList - customList2;
            int actualResult = subtractedList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }

        // Zip Method Tests-------------------------------------------
        [TestMethod]
        public void Zip_TwoListsTogether_CheckCount()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            int expectedResult = 4;

            customList.Add(1);
            customList.Add(3);
            customList2.Add(2);
            customList2.Add(4);
            CustomList<int> zipList = customList.Zip(customList, customList2);
            int actualResult = zipList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Zip_TwoListsTogether_CheckValueAtIndex1()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList2.Add(2);
            customList.Add(3);
            customList2.Add(4);
            CustomList<int> zipList = customList.Zip(customList, customList2);

            Assert.AreEqual(2, zipList[1]);
        }

        [TestMethod]
        public void Zip_TwoListsTogether_CheckValueAtIndex2()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList.Add(3);
            customList2.Add(2);
            customList2.Add(4);
            CustomList<int> zipList = customList.Zip(customList, customList2);

            Assert.AreEqual(3, zipList[2]);
        }

        [TestMethod]
        public void Zip_TwoListsCustomList2Bigger_CheckValueAtIndex4()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList.Add(3);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(5);
            CustomList<int> zipList = customList.Zip(customList, customList2);

            Assert.AreEqual(5, zipList[4]);
        }

        [TestMethod]
        public void Zip_TwoListsCustomListBigger_CheckValueAtIndex4()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            CustomList<int> zipList = customList.Zip(customList, customList2);

            Assert.AreEqual(5, zipList[4]);
        }
    }
}
