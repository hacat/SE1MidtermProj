using NUnit.Framework;
using System;

namespace AbstractFactoryPattern
{
    [TestFixture()]
    public class UnitTests
    {
        [Test()]
        public void PCFactory_Class_makeCompromise()
        {

            //Unit testing for PCFactory Class makeCompromise method
            AbstractFactory PCFactory = new PCFactory();
            Assert.IsTrue(new Expression("\"do it your way, any way, or no way\"").ToString() == PCFactory.makeCompromise().ToString());

        }

        [Test()]
        public void PCFactory_Class_makeGrade()
        {

            //Unit testing for PCFactory Class makeGrade method
            AbstractFactory PCFactory = new PCFactory();
            Assert.IsTrue(new Expression("\"you pass, self-esteem intact\"").ToString() == PCFactory.makeGrade().ToString());

        }

        [Test()]
        public void NotPCFactory_Class_makeCompromise()
        {
            //Unit testing for NotPCFactory Class makeCompromise method
            AbstractFactory NotPCFactory = new NotPCFactory();
            Assert.IsTrue(new Expression("\"my way, or the highway\"").ToString() == NotPCFactory.makeCompromise().ToString());
        }

        [Test()]
        public void NotPCFactory_Class_makeGrade()
        {
            //Unit testing for NotPCFactory Class makeGrade method
            AbstractFactory NotPCFactory = new NotPCFactory();
            Assert.IsTrue(new Expression("\"take test, deal with the results\"").ToString() == NotPCFactory.makeGrade().ToString());
        }

        [Test()]
        public void FactoryFmProto_Two_Args()
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
            FactoryFmProto factory = new FactoryFmProto();
            factory.Maine(args);

        }

        [Test()]
        public void FactoryFmProto_One_Args()
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

            String[] args = new String[] {};
            FactoryFmProto factory = new FactoryFmProto();
            factory.Maine(args);

        }
    }
}
