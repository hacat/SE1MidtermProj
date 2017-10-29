using NUnit.Framework;
using System;
namespace MidtermTestaaaa
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase0()
        {
            SquarePeg peg = new SquarePeg(10.0);
            Assert.AreEqual(10.0, peg.getWidth());
        }

        [Test()]
        public void TestCase1()
        {
            SquarePeg peg = new SquarePeg(10.0);
            peg.setWidth(20.0);
            Assert.AreEqual(20.0, peg.getWidth());
        }

        [Test()]
        public void TestCase2()
        {
            RoundHole hole = new RoundHole(10.0);
            Assert.AreEqual(10.0, hole.getRadius());
        }

        [Test()]
        public void TestCase3()
        {
            SquarePegAdapter pegAdapter = new SquarePegAdapter(10.0);
            pegAdapter.makeFit(20.0);
            Assert.AreEqual(20.0, pegAdapter.getWidth());
        }


        [Test()]
        public void TestCase4()
        {
            SquarePegAdapter pegAdapter = new SquarePegAdapter(10.0);
            pegAdapter.makeFit(-30.0);
            Assert.AreEqual(10.0, pegAdapter.getWidth());
        }

    }
}

