using NUnit.Framework;
using System;
namespace AdaptorPattern
{
    [TestFixture()]
    public class UnitTests
    {
        //Cretes a squarepeg and checks all getter methods
        [Test()]
        public void TestCase0()
        {
            SquarePeg peg = new SquarePeg(10.0);
            Assert.AreEqual(10.0, peg.getWidth());
        }

        //Creates a square peg and checks all setter methods
        [Test()]
        public void TestCase1()
        {
            SquarePeg peg = new SquarePeg(10.0);
            peg.setWidth(20.0);
            Assert.AreEqual(20.0, peg.getWidth());
        }

        //Creates a round hole and checks all getter methods
        [Test()]
        public void TestCase2()
        {
            RoundHole hole = new RoundHole(10);
            Assert.AreEqual(10.0, hole.getRadius());
        }

    }
}
