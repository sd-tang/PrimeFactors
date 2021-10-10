using System;
using Xunit;
using PrimeFactorsLib;
using System.Collections.Generic;

namespace PrimeFactorsLibUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int a = 7;
            List<int> expected = new List<int>() {7};
            var calc = new PrimeFactors();

            // Act
            List<int> actual = calc.GetPrimeFactors(a);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2()
        {
            // Arrange
            int a = 10;
            List<int> expected = new List<int>() {2, 5};
            var calc = new PrimeFactors();

            // Act
            List<int> actual = calc.GetPrimeFactors(a);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test3()
        {
            // Arrange
            int a = 100;
            List<int> expected = new List<int>() {2, 2, 5, 5};
            var calc = new PrimeFactors();

            // Act
            List<int> actual = calc.GetPrimeFactors(a);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test4()
        {
            // Arrange
            int a = 380;
            List<int> expected = new List<int>() {2, 2, 5, 19};
            var calc = new PrimeFactors();

            // Act
            List<int> actual = calc.GetPrimeFactors(a);

            // Assert
            Assert.Equal(expected, actual);

        }

        // [Fact]
        // public void Test2()
        // {
        //     // Arrange
        //     int a = 9;
        //     bool expected = false;
        //     var calc = new PrimeFactors();

        //     // Act
        //     bool actual = calc.IsPrimeNumber(a);

        //     // Assert
        //     Assert.Equal(expected, actual);

        // }
    }
}
