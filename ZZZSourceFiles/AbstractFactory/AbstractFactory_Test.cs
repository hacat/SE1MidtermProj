using NUnit.Framework;
using System;

namespace AdaptorFactoryPattern
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase1()
        {

            //Unit testing for PCFactory Class makeCompromise method
            AbstractFactory PCFactory = new PCFactory();
            Assert.IsTrue(new Expression("\"do it your way, any way, or no way\"").ToString() == PCFactory.makeCompromise().ToString());

        }

        [Test()]
        public void TestCase2()
        {

            //Unit testing for PCFactory Class makeGrade method
            AbstractFactory PCFactory = new PCFactory();
            Assert.IsTrue(new Expression("\"you pass, self-esteem intact\"").ToString() == PCFactory.makeGrade().ToString());

        }

        [Test()]
        public void TestCase3()
        {
            //Unit testing for NotPCFactory Class makeCompromise method
            AbstractFactory NotPCFactory = new NotPCFactory();
            Assert.IsTrue(new Expression("\"my way, or the highway\"").ToString() == NotPCFactory.makeCompromise().ToString());
        }

        [Test()]
        public void TestCase4()
        {
            //Unit testing for NotPCFactory Class makeGrade method
            AbstractFactory NotPCFactory = new NotPCFactory();
            Assert.IsTrue(new Expression("\"take test, deal with the results\"").ToString() == NotPCFactory.makeGrade().ToString());
        }

        [Test()]
        public void TestCase5()
        {
            /**
             * When FactoryFM takes more than 0 arguments, it will return
             * 
             * "vertically challenged" 
             * "factually inaccurate" 
             * "chronologically gifted" 
             * 
             * "do it your way, any way, or no way"
             * "you pass, self-esteem intact"
             */

            String[] args = new String[] { "test1", "test2" };
            FactoryFmProto.Main(args);

        }

        [Test()]
        public void TestCase6()
        {
           

            /**
             * When FactoryFM takes more than 0 arguments, it will return
             * 
             * "short" 
             * "lie" 
             * "old" 
             * 
             * "my way, or the highway"
             * "take test, deal with the results"
             */

            String[] args2 = new String[] {};
            FactoryFmProto.Main(args2);

        }
    }
}
