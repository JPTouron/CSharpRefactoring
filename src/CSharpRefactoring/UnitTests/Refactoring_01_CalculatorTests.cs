using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring_01_Calculator;

namespace UnitTests
{
    [TestClass]
    public class Refactoring_01_CalculatorTests
    {
        private Calculator calculatorClass;

        /// <summary>
        /// cuando ejecutamos con type =1 entonces esperamos que lo retornado sea igual al monto ingresado (amount)
        /// </summary>
        [TestMethod]
        public void a_Calculator_WhenTypeIsOne_ReturnsAmountSet()
        {
            //Arrange
            var amount = 1000.5M;
            var type = 1;
            var years = 10;

            //Act
            var result = calculatorClass.Calculate(amount, type, years);

            //Assert
            var expected = amount;
            var actualValue = result;

            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// cuando type=2 entonces esperamos que lo retornado sea basado en el 10 % del monto ingresado segun esta formula:
        /// (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount))
        /// </summary>
        [TestMethod]
        public void b_Calculator_WhenTypeIsTwo_ReturnsDiscountBasedOnTenPercent()
        {
            //Arrange
            var amount = 1000.5M;
            var type = 2;
            var years = 10;

            //calcular los resultados internamente para comparar después
            decimal calculatedDiscount = ManualCalculations.CalculateDiscountBasedOnYears(years);
            var calculatedResult = ManualCalculations.CalculateFinalResultWithType2(amount, calculatedDiscount);

            //Act
            var result = calculatorClass.Calculate(amount, type, years);

            //Assert
            var expected = calculatedResult;
            var actualValue = result;

            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// cuando type=3 entonces esperamos que lo retornado sea basado en el 70 % del monto ingresado segun esta formula:
        /// (0.7m * amount) - disc * (0.7m * amount)
        /// </summary>
        [TestMethod]
        public void c_Calculator_WhenTypeIsThree_ReturnsDiscountBasedOnSeventyPercent()
        {
            //Arrange
            var amount = 1000.5M;
            var type = 3;
            var years = 10;

            //calcular los resultados internamente para comparar después
            decimal calculatedDiscount = ManualCalculations.CalculateDiscountBasedOnYears(years);
            var calculatedResult = ManualCalculations.CalculateFinalResultWithType3(amount, calculatedDiscount);

            //Act
            var result = calculatorClass.Calculate(amount, type, years);

            //Assert
            var expected = calculatedResult;
            var actualValue = result;

            Assert.AreEqual(expected, actualValue);
        }

        /// <summary>
        /// cuando type=4 entonces esperamos que lo retornado sea basado en el 50 % del monto ingresado segun esta formula:
        /// (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount))
        /// </summary>
        [TestMethod]
        public void d_Calculator_WhenTypeIsFour_ReturnsDiscountBasedOnFiftyPercent()
        {
            //Arrange
            var amount = 1000.5M;
            var type = 4;
            var years = 10;

            //calcular los resultados internamente para comparar después
            decimal calculatedDiscount = ManualCalculations.CalculateDiscountBasedOnYears(years);
            var calculatedResult = ManualCalculations.CalculateFinalResultWithType4(amount, calculatedDiscount);

            //Act
            var result = calculatorClass.Calculate(amount, type, years);

            //Assert
            var expected = calculatedResult;
            var actualValue = result;

            Assert.AreEqual(expected, actualValue);
        }

        [TestInitialize]
        public void Initialize()
        {
            calculatorClass = new Calculator();
        }
    }
}