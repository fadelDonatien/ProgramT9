using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramT9;

namespace ProjectT9UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Form1 fm;

        [TestMethod]
        public void ProgramT9Test()
        {
            fm = new Form1();
            string inStr = "bonjour";
            string outStr = "2266666566688777";
            var result = fm.StringEncode(inStr);

            Assert.AreEqual(outStr, result);
        }
    }
}
