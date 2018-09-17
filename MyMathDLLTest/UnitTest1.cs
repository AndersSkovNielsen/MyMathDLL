using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathDLL;

namespace MyMathDLLTest
{
    [TestClass]
    public class MathTest
    {
        MyMath m = new MyMath();

        [TestMethod]
        public void AddTest()
        {
            //== er ok til simple typer (5 er 5, true er true, 4 er ikke 5)
            //.Equals er nødvendig til objekter (PersonA er PersonA ifølge hvad? PersonNr?)
            Assert.IsTrue(m.Add(2, 3).Equals(5));
        }
        [TestMethod]
        public void AddTestNegativeNumber()
        {
            Assert.AreEqual(m.Add(-3, -4), -7);
        }
    }
}
