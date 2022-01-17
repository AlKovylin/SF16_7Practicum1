﻿using NUnit.Framework;
using System;

namespace SF16_7Practicum.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(6, calculator.Additional(2, 4));
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Subtraction(7, 2) == 5);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(6, calculator.Miltiplication(2, 3));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(8, 0));
        }
    }
}
