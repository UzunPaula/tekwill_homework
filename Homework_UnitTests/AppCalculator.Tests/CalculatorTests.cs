using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Add(4, 2);

            //Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Substract_ShouldReturnDifferenceOfTwoNumbers()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Subtract(4, 2);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnProductOfTwoNumbers()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Multiply(4, 2);

            //Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Divide_ShouldReturnDivisionOfTwoNumbers()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Divide(4, 2);

            //Assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void Divide_ShouldThrowDivideByZeroException()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            Action resultException = () => sut.Divide(4, 0);

            //Assert
            Assert.Throws<DivideByZeroException>(resultException);
        }
    }
}
