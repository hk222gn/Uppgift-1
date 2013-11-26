using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTriangel
{
    [TestClass]
    public class TriangleUnitTest
    {
        //likbent
        [TestMethod]
        public void isIsosceles()
        {
            Triangle t = new Triangle(1.0, 3.0, 1.0);
            Assert.IsTrue(t.isIsosceles());
        }
        //liksidig
        [TestMethod]
        public void isEquilateral()
        {
            Triangle t = new Triangle(2.0, 2.0, 2.0);
            Assert.IsTrue(t.isEquilateral());
        }
        //Inga lika sidor
        [TestMethod]
        public void isScalene()
        {
            Triangle t = new Triangle(3.0, 4.0, 5.0);
            Assert.IsTrue(t.isScalene());
        }
    }
}
