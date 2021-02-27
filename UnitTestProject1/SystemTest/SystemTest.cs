using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.SystemTest
{
    [CodedUITest]
    public class SystemTest
    {
        public SystemTest () {}

        [TestMethod]
        public void CodedPolynomCalcCheck()
        {
            this.UIMap.openApplication();
            this.UIMap.typeText();
            this.UIMap.clickRun();
            this.UIMap.assertPolynomCalc();
            this.UIMap.closeApplication();
        }
    }
}
