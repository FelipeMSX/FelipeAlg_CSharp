using System;
using Algorithms.Study;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_Test.Study
{
    [TestClass]
    public class Aula03Tests
    {
        [TestMethod, TestCategory("Aula03")]
        public void Sum_1_1()
        {
            //Arrange
            Aula03 aula03 = new Aula03();
            //Act
            int result = aula03.Sum(8, 3);
            //Assert
            Assert.IsTrue(result == 6);
        }

        [TestMethod, TestCategory("Aula03"), ExpectedException(typeof(Exception))]
        public void Sum_1_2()
        {
            //Arrange
            Aula03 aula03 = new Aula03();
            //Act
            int result = aula03.Sum(3, -3);
            //Assert
            Assert.Inconclusive();
        }

        //[TestMethod, TestCategory("Aula03")]
        //public void Sum_2_1()
        //{
        //    //Arrange
        //    Aula03 aula03 = new Aula03();
        //    //Act
        //    int result = aula03.Sum(1, 0);
        //    //Assert
        //    Assert.IsTrue(result == 0);
        //}

        //[TestMethod, TestCategory("Aula03"), ExpectedException(typeof(Exception))]
        //public void Sum_2_2()
        //{
        //    //Arrange
        //    Aula03 aula03 = new Aula03();
        //    //Act
        //    int result = aula03.Sum(-1, -1);
        //    //Assert
        //    Assert.Inconclusive();
        //}

        //[TestMethod, TestCategory("Aula03")]
        //public void Sum_3_1()
        //{
        //    //Arrange
        //    Aula03 aula03 = new Aula03();
        //    //Act
        //    int result = aula03.Sum(8, 3);
        //    //Assert
        //    Assert.IsTrue(result == 6);
        //}

        //[TestMethod, TestCategory("Aula03"), ExpectedException(typeof(Exception))]
        //public void Sum_3_2()
        //{
        //    //Arrange
        //    Aula03 aula03 = new Aula03();
        //    //Act
        //    int result = aula03.Sum(-1, -1);
        //    //Assert
        //    Assert.Inconclusive();
        //}
    }
}
