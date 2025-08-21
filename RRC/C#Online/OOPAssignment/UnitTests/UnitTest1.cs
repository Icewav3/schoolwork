using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOPAssignment;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculator_multiply_6()
        {
            Calculator calculator = new Calculator();
            calculator.number1.Enter("3");
            calculator.number2.Enter("2");
            calculator.expectedResult.Enter("6");
            calculator.operation = "x";
            Assert.AreEqual(6, calculator.Calculate());
        }
        [TestMethod]
        public void Calculator_isvalid_correct()
        {
            Calculator calculator = new Calculator();
            calculator.number1.Enter("3");
            calculator.number2.Enter("2");
            calculator.expectedResult.Enter("6");
            calculator.operation = "x";
            calculator.Calculate();
            Assert.AreEqual(true, calculator.IsCorrect);
        }
        [TestMethod]
        public void Calculator_isvalid_incorrect()
        {
            Calculator calculator = new Calculator();
            calculator.number1.Enter("3");
            calculator.number2.Enter("2");
            calculator.expectedResult.Enter("8");
            calculator.operation = "x";
            calculator.Calculate();
            Assert.AreEqual(false, calculator.IsCorrect);
        }
        [TestMethod]
        public void Calculator_add_5()
        {
            Calculator calculator = new Calculator();
            calculator.number1.Enter("3");
            calculator.number2.Enter("2");
            calculator.expectedResult.Enter("5");
            calculator.operation = "+";
            Assert.AreEqual(5, calculator.Calculate());
        }
        [TestMethod]
        public void Calculator_subtract_1()
        {
            Calculator calculator = new Calculator();
            calculator.number1.Enter("3");
            calculator.number2.Enter("2");
            calculator.expectedResult.Enter("1");
            calculator.operation = "-";
            Assert.AreEqual(1, calculator.Calculate());
        }
        [TestMethod]
        public void Calculator_divide_2()
        {
            Calculator calculator = new Calculator();
            calculator.number1.Enter("4");
            calculator.number2.Enter("2");
            calculator.expectedResult.Enter("2");
            calculator.operation = "/";
            Assert.AreEqual(2, calculator.Calculate());
        }
    }
}
