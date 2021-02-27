using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.IntegrationTest
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void checkPolynomCalcFull()
        {
            string polynom = "3x^2+2x+1";
            string x = "2";
            int result = 0;
            if (DataCheck.polynomCheck(polynom) && DataCheck.argumentCheck(x))
            {
                result = CalcModule.polynomCalc(polynom, x);
                Assert.AreEqual(result, 17);
            } else
            {
                Assert.AreEqual(result, 1);
            }
        }

        [TestMethod]
        public void checkExspressionCalcFull()
        {
            string polynomP = "2x^4+3x^2+x+2";
            string x = "1";
            string polynomQ = "2x^4+3x^2+x+2";
            string y = "1";

            long result = 0;

            if (DataCheck.polynomCheck(polynomP) && DataCheck.argumentCheck(x) && 
                DataCheck.polynomCheck(polynomQ) && DataCheck.argumentCheck(y))
            {
                result = CalcModule.expressionCalc(polynomP, x, polynomQ, y);
                Assert.AreEqual(result, -10623730);
            }
            else
            {
                Assert.AreEqual(result, 1);
            }
        }
    }
}
