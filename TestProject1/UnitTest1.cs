using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static SquareEquation.liczenie;

namespace TestProject1

{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            SquareEquation.liczenie l = new SquareEquation.liczenie();

            double x1, x2;
            var a = 2;
            var b = 5;
            var c = 1;
            SquareEquation.liczenie.solveSquareEquation(a, b, c,out x1, out x2);
            
            Assert.AreNotEqual(x1, double.NaN);
            Assert.AreNotEqual(x2, double.NaN);

        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x1, x2;
            var a = 1;
            var b = 2;
            var c = 1;
            SquareEquation.liczenie.solveSquareEquation(a, b, c, out x1, out x2);
            Assert.AreEqual(x1, x2);
            


        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x1, x2;
            var a = 5;
            var b = 6;
            var c = 7;
            SquareEquation.liczenie.solveSquareEquation(a, b, c, out x1, out x2);
            Assert.AreEqual(x1, double.NaN);
            Assert.AreEqual(x2, double.NaN);


        }
    }
}