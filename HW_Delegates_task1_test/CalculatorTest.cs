using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_Delegates_task1;

namespace HW_Delegates_task1_test
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator calculator = new Calculator();

        [TestMethod]
        public void Calculate_WithAdd()
        {
            double operand1 = 45.67;
            double operand2 = -12.367;
            double actualResult = calculator.Calculate(operand1, operand2, "+");
            double expectedResult = 33.303;

            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [TestMethod]
        public void Calculate_WithSub()
        {
            double operand1 = -45.67;
            double operand2 = -12.367;
            double actualResult = calculator.Calculate(operand1, operand2, "-");
            double expectedResult = -33.303;

            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [TestMethod]
        public void Calculate_WithMult()
        {
            double operand1 = 45.67;
            double operand2 = -12.367;
            double actualResult = calculator.Calculate(operand1, operand2, "*");
            double expectedResult = -564.80089;

            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [TestMethod]
        public void Calculate_WithDiv()
        {
            double operand1 = 45.67;
            double operand2 = -12.367;
            double actualResult = calculator.Calculate(operand1, operand2, "/");
            double expectedResult = -3.6928924;

            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "You can not divide on a zero!")]
        public void Calculate_WithDivideByZero()
        {
            double operand1 = 45.67;
            double operand2 = 0.0;
            double actualResult = calculator.Calculate(operand1, operand2, "/");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "This is not a valid sign.")]
        public void Calculate_WithInvalidSign()
        {
            double operand1 = 45.67;
            double operand2 = 0.7;
            double actualResult = calculator.Calculate(operand1, operand2, "=");
        }
    }
}
