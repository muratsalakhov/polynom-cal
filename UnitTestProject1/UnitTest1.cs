using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkPolynomInput()
        {
            Assert.AreEqual(DataCheck.polynomCheck("3x^2+2x+1"), true);
            Assert.AreEqual(DataCheck.polynomCheck("2+3x^5+x^4+x"), true);
            Assert.AreEqual(DataCheck.polynomCheck("7x"), true);
            Assert.AreEqual(DataCheck.polynomCheck("2x+y"), false);
            Assert.AreEqual(DataCheck.polynomCheck("33xa^2+6"), false);
            Assert.AreEqual(DataCheck.polynomCheck(""), false);
        }

        [TestMethod]
        public void checkArgumentInput()
        {
            Assert.AreEqual(DataCheck.argumentCheck("32"), true);
            Assert.AreEqual(DataCheck.argumentCheck("4"), true);
            Assert.AreEqual(DataCheck.argumentCheck("5"), true);
            Assert.AreEqual(DataCheck.argumentCheck("sa"), false);
            Assert.AreEqual(DataCheck.argumentCheck("8d"), false);
            Assert.AreEqual(DataCheck.argumentCheck(""), false);
        }
    }
}
