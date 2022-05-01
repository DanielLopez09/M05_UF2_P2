using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProyectoSorting;
using System.Linq;

namespace SortingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BubbleSort_Test()
        {
            //Arrange
            Random random = new Random();
            SortingArray sortArray = new SortingArray(10000, random);
            int[] temp = new int[sortArray.array.Length];
            Array.Copy(sortArray.array, temp, sortArray.array.Length);

            //Act
            sortArray.BubbleSort(temp);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(temp, sortArray.arrayCreciente));
        }


        [TestMethod]
        public void QuickSort_Test()
        {
            //Arrange
            Random random = new Random();
            SortingArray sortArray = new SortingArray(10000, random);
            int[] temp = new int[sortArray.array.Length];
            Array.Copy(sortArray.array, temp, sortArray.array.Length);

            //Act
            sortArray.QuickSort(temp);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(temp, sortArray.arrayCreciente));
        }

        [TestMethod]
        public void MergeSort_Test()
        {
            //Arrange
            Random random = new Random();
            SortingArray sortArray = new SortingArray(10000, random);
            int[] temp = new int[sortArray.array.Length];
            Array.Copy(sortArray.array, temp, sortArray.array.Length);

            //Act
            sortArray.MergeSort(temp);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(temp, sortArray.arrayCreciente));
        }

        [TestMethod]
        public void HeapSort_Test()
        {
            //Arrange
            Random random = new Random();
            SortingArray sortArray = new SortingArray(10000, random);
            int[] temp = new int[sortArray.array.Length];
            Array.Copy(sortArray.array, temp, sortArray.array.Length);

            //Act
            sortArray.HeapSort(temp);

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(temp, sortArray.arrayCreciente));
        }
    }
}