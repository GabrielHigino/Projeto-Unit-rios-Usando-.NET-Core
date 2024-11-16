using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Projeto
{
    public class Uniteste1
    {
        [Theory]
        [InlineData(1, 2, 3)]  // 1 + 2 = 3
        [InlineData(4, 5, 9)]  // 4 + 5 = 9
        [InlineData(10, 5, 15)]  // 10 + 5 = 15
        public void TestAdd(int val1, int val2, int expectedResult)
        {
            Calculadora calc = new Calculadora();
            int result = calc.somar(val1, val2);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]  // 5 - 3 = 2
        [InlineData(7, 4, 3)]  // 7 - 4 = 3
        [InlineData(10, 5, 5)]  // 10 - 5 = 5
        public void TestSubtract(int val1, int val2, int expectedResult)
        {
            Calculadora calc = new Calculadora();
            int result = calc.subtrair(val1, val2);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]  // 2 * 3 = 6
        [InlineData(4, 5, 20)]  // 4 * 5 = 20
        [InlineData(6, 7, 42)]  // 6 * 7 = 42
        public void TestMultiply(int val1, int val2, int expectedResult)
        {
            Calculadora calc = new Calculadora();
            int result = calc.multiplicar(val1, val2);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]  // 6 / 2 = 3
        [InlineData(10, 5, 2)]  // 10 / 5 = 2
        [InlineData(9, 3, 3)]  // 9 / 3 = 3
        public void TestDivide(int val1, int val2, int expectedResult)
        {
            Calculadora calc = new Calculadora();
            int result = calc.dividir(val1, val2);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestDivideByZero()
        {
            Calculadora calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }
    }
}
