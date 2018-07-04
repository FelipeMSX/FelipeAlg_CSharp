﻿using System;
using System.Text.RegularExpressions;
using Algorithms.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_Test.Utils
{
    [TestClass]
    public class RegexExpressionsTests
    {

        #region CPF - Valid Inputs
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
            Assert.IsTrue(result, "The input is valid because the CPF has a match!");
        }

        #endregion

        #region CPF - Invalid Inputs

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
            //Act
            bool result = Regex.IsMatch("04811133340", RegexExpressions.CPF);
            //Assert
            Assert.IsFalse(result, "The input is invalid because the CPF pattern doesn't match!");
        }
        #endregion


        #region CNPJ - Valid Inputs
        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void CNPJ_ValidPattern_ValidCPNJ()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("86.218.925/0001-29", RegexExpressions.CNPJ);
            //Assert
            Assert.IsTrue(result, "The input is valid because the CNPJ has a match!");
        }

        #endregion

        #region CNPJ - Invalid Inputs

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void CNPJ_MissingADigit_InvalidCNPJ()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("86.218.925/001-29", RegexExpressions.CNPJ);
            //Assert
            Assert.IsFalse(result, "CNPJ is invalid because one character is missing!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void CNPJ_WithCharacter_InvalidCNPJ()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("86.218.A25/001-29", RegexExpressions.CNPJ);
            //Assert
            Assert.IsFalse(result, "CNPJ must contain only numbers with mask!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void CNPJ_MissingAllCharacteres_InvalidCNPJ()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("", RegexExpressions.CNPJ);
            //Assert
            Assert.IsFalse(result, "The CNPJ is invalid because it is empty!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions"), ExpectedException(typeof(ArgumentNullException))]
        public void CPNJ_NullInput_InvalidCNPJ()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch(null, RegexExpressions.CNPJ);
            //Assert
            Assert.Inconclusive("It's not acceptable null value!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void CNPJ_OnlyNumbers_InvalidCNPJ()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("877317600003157", RegexExpressions.CNPJ);
            //Assert
            Assert.IsFalse(result, "CNPJ is only valid with mask!");
        }

        #endregion


        #region IP - Valid Inputs
        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void IP_ValidPattern_ValidIP()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("172.168.218.116", RegexExpressions.AddressIP);
            //Assert
            Assert.IsTrue(result, "The input is valid because the IP has a match!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void IP_ValidPatternWithOneSingleDigit_ValidIP()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("1.2.3.4", RegexExpressions.AddressIP);
            //Assert
            Assert.IsTrue(result, "The input is valid because the IP has a match!");
        }

        #endregion


        #region IP - Invalid Inputs
        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void IP_PatternWithCharacterNotValid_InvalidIP()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("1a2.168.2a8.116", RegexExpressions.AddressIP);
            //Assert
            Assert.IsFalse(result, "The input is valid because the IP has a match!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void IP_MissingAllCharacteres_InvalidIP()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("", RegexExpressions.AddressIP);
            //Assert
            Assert.IsFalse(result, "The IP is invalid because it is empty!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions"), ExpectedException(typeof(ArgumentNullException))]
        public void IP_NullInput_InvalidIP()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch(null, RegexExpressions.AddressIP);
            //Assert
            Assert.Inconclusive("It's not acceptable null value!");
        }

        /// <summary>
        /// Técnica: Particionamento de Equivalência.
        /// </summary>
        [TestMethod, TestCategory("RegexExpressions")]
        public void IP_OnlyNumbers_InvalidIP()
        {
            //Arrange
            //Act
            bool result = Regex.IsMatch("172168218116", RegexExpressions.AddressIP);
            //Assert
            Assert.IsFalse(result, "IP is only valid with mask!");
        }
        #endregion

    }
}
