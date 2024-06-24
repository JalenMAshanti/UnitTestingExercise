using NuGet.Frameworks;
using System;
using System.Dynamic;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(4, 7, 2, 13)]
        [InlineData(-5, -8, 7, -6)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
          
            Calculator calculator = new Calculator();
            
            var actual = calculator.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1)]//Add test data <-------
        [InlineData(6, 3, 3)]
        [InlineData(19, 25, -6)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {

            //Arrange

            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        [InlineData(6, 5, 30)]
        [InlineData(-9, 4, -36)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
         
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9, 3, 3)]//Add test data <-------
        [InlineData(10, 2, 5)]
        [InlineData(20, 5, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();  

            //Act
            int actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
