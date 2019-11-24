using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PositiveSum()
        {
            int num1 = 3;
            int num2 = 4;
            int somma_aspettata = 7;
            int somma = CalcLibrary.calc.somma(num1 , num2);
            Assert.AreEqual(somma_aspettata, somma);
        }
        [TestMethod]
        public void PositiveDivision()
        {
            int num1 = 3;
            int num2 = 0;
            int divisione_aspettata = 0;
            double divisione = CalcLibrary.calc.divisione(num1, num2);
            Assert.AreEqual(divisione_aspettata, divisione);
        }
        [TestMethod]
        public void NegativeSum()
        {
            int num1 = -3;
            int num2 = -5;
            int somma_aspettata = -8;
            int somma = CalcLibrary.calc.somma(num1, num2);
            Assert.AreEqual(somma_aspettata, somma);
        }
    }
}
