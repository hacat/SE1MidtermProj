using NUnit.Framework;
using System;
namespace MidtermTest
{
    [TestFixture()]
    public class Test
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
            RoundHole hole = new RoundHole(10.0);
            Assert.AreEqual(10.0, hole.getRadius());
        }

        //Creates a peg adapter and checks the makeFit method
        [Test()]
        public void TestCase3()
        {
            SquarePegAdapter pegAdapter = new SquarePegAdapter(10.0);
            pegAdapter.makeFit(1.0);
            Assert.AreEqual(10.0 - 1.0 * Math.Sqrt(2.0), pegAdapter.getWidth());
        }

        //Creates a peg adapter and checks the negative edge case
        [Test()]
        public void TestCase4()
        {
            SquarePegAdapter pegAdapter = new SquarePegAdapter(10.0);
            pegAdapter.makeFit(-30.0);
            Assert.AreEqual(10.0, pegAdapter.getWidth());
        }

    }
}
