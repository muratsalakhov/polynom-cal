using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        
        [TestMethod]
        public void checkPolynomCalc()
        {
            Assert.AreEqual(CalcModule.polynomCalc("3x^2+2x+1", "2"), 17);
            Assert.AreEqual(CalcModule.polynomCalc("3x^5+x^4+5x^2+10", "5"), 10135);
            Assert.AreEqual(CalcModule.polynomCalc("x+2x^5+130", "3"), 619);
            Assert.AreEqual(CalcModule.polynomCalc("9x^5+4x^2+8x^3+9", "2"), 377);
            Assert.AreEqual(CalcModule.polynomCalc("130x^9+1", "4"), 34078721);
            Assert.AreEqual(CalcModule.polynomCalc("7x^7-4x^9-x+10", "5"), -7265610);
            Assert.AreEqual(CalcModule.polynomCalc("5x^3+x^4+x+9", "-5"), 4);
            Assert.AreEqual(CalcModule.polynomCalc("x^2+x^6", "13"), 4826978);
        }

        [TestMethod]
        public void checkExspressionCalc()
        {
            Assert.AreEqual(CalcModule.expressionCalc("2x^4+3x^2+x+2", "1", "2x^4+3x^2+x+2", "1"), -10623730);
            Assert.AreEqual(CalcModule.expressionCalc("2x^4+3x^2+x+2", "2", "32x+7", "3"), -1555671534);
            Assert.AreEqual(CalcModule.expressionCalc("2x^2+x+10", "6", "32x+7x^2", "3"), -1448923);
        }
    }
}
