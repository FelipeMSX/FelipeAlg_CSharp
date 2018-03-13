using System;
using System.Text.RegularExpressions;
using Algorithms.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_Test.Utils
{
    [TestClass]
    public class RegexExpressionsTests
    {

        #region CPF Valid Inputs
        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void CPF_ValidPattern_ValidCPF()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("048.111.333-78", RegexExpressions.CPF);
            //Assert
            Assert.IsTrue(result, "The input is valid because the CPF pattern doesn't match!");
        }

        #endregion

        #region CPF Invalid Inputs

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void CPF_MissingACharacter_InvalidCPF()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("048.111.333-0", RegexExpressions.CPF);
            //Assert
            Assert.IsFalse(result, "The input is invalid because the CPF pattern doesn't match!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void CPF_MissingAllCharacteres_InvalidCPF()
        {
            //Arrange
            RegexExpressions regex = new RegexExpressions();
            //Act
            bool result = Regex.IsMatch("", RegexExpressions.CPF);
            //Assert
            Assert.IsFalse(result, "The input is invalid because the CPF pattern doesn't match!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions"), ExpectedException(typeof(ArgumentNullException))]
        public void CPF_NullInput_InvalidCPF()
        {
            //Arrange
            RegexExpressions regex = new RegexExpressions();
            //Act
            bool result = Regex.IsMatch(null, RegexExpressions.CPF);
            //Assert
            Assert.Inconclusive("An exception was expected!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void CPF_OnlyNumbers_InvalidCPF()
        {
            //Arrange
            RegexExpressions regex = new RegexExpressions();
            //Act
            bool result = Regex.IsMatch("04811133340", RegexExpressions.CPF);
            //Assert
            Assert.IsFalse(result, "The input is invalid because the CPF pattern doesn't match!");
        }
        #endregion

    }
}
