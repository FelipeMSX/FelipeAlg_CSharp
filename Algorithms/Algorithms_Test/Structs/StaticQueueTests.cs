using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_Test.Structs
{
    [TestClass]
    public class StaticQueueTests
    {

        private StaticQueue
        [TestInitialize]
        public void Initialize()
        {
         
        }

        [TestMethod, TestCategory("Heapsort")]
        public void Sort_VectorNumbers_CrescentOrderedList()
        {
            //Arrange
            HeapSort<int> heapsort = new HeapSort<int>((x, y) => x.CompareTo(y), HeapSort<int>.Build.Max);

            //Act
            heapsort.Sort(vector);

            //Assert
            bool isOrdered = true;
            for (int i = 0; i < vector.Length - 1; i++)
            {
                isOrdered = vector[i] <= vector[i + 1];
                if (!isOrdered)
                    break;
            }


            Assert.IsTrue(isOrdered, "A ordem do vetor deveria estar crescente!");
        }
    }
}
