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
            Assert.IsTrue(t.isEquilateral());//Ska misslyckas, equileteral ska vara = 1
        }
        //Inga lika sidor
        [TestMethod]
        public void isScalene()
        {
            Triangle t = new Triangle(3.0, 4.0, 5.0);
            Assert.IsTrue(t.isScalene());//Ska misslyckas, scalene ska vara = 3
        }
        [TestMethod]
        public void isScaleneFalse()
        {
            Triangle t = new Triangle(3, 3, 5.4);
            Assert.IsFalse(t.isScalene());
        }
        [TestMethod]
        public void isEquilateralFalse()
        {
            Triangle t = new Triangle(5, 2.0, 2.0);
            Assert.IsFalse(t.isEquilateral());
        }
        [TestMethod]
        public void isIsoscelesFalse()
        {
            Triangle t = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(t.isIsosceles());
        }
    }
}
