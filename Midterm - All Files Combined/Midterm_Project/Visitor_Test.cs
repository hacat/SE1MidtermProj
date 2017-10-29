﻿using NUnit.Framework;
using System;

namespace VisitorPattern
{
    [TestFixture()]
    public class UnitTests
    {
        //unit test for section 1.0,2.1,5.1, 6.1
        [Test()]
        public void TestMethod1()
        {
            String result1;
            UpVisitor vis=new UpVisitor();
            FOO obj = new FOO();
            obj.accept(vis);
            vis.visit(obj);
            result1=vis.ToString();
            Assert.AreEqual(result1, "do Up on " + obj.getFOO());
             
        }
        //unit test for section 1.0,2.1,5.1, 7.1
        [Test()]
        public void TestMethod2()
        {
            String result2;
            DownVisitor dvis = new DownVisitor();
            FOO obj = new FOO();
            obj.accept(dvis);
            dvis.visit(obj);
            result2 = dvis.ToString();
            Assert.AreEqual(result2, "do Down on " + obj.getFOO());

        }
        //unit test for section 2.2
        [Test()]
        public void TestMethod3()
        {
            String result;
            FOO obj = new FOO();
            result = obj.getFOO();
            Assert.AreEqual(result, "FOO");
        }

        //unit test for section 1.0,3.1,5.2, 6.2
        [Test()]
        public void TestMethod4()
        {
            String result1;
            UpVisitor vis = new UpVisitor();
            BAR obj = new BAR();
            obj.accept(vis);
            vis.visit(obj);
            result1 = vis.ToString();
            Assert.AreEqual(result1, "do Up on " + obj.getBAR());

        }
        //unit test for section 1.0,3.1,5.2, 7.2
        [Test()]
        public void TestMethod5()
        {
            String result2;
            DownVisitor dvis = new DownVisitor();
            BAR obj = new BAR();
            obj.accept(dvis);
            dvis.visit(obj);
            result2 = dvis.ToString();
            Assert.AreEqual(result2, "do Down on " + obj.getBAR());

        }
        //unit test for section 3.2
        [Test()]
        public void TestMethod6()
        {
            String result;
            BAR obj = new BAR();
            result = obj.getBAR();
            Assert.AreEqual(result, "BAR");
        }


        //unit test for section 1.0,4.1,5.3, 6.3
        [Test()]
        public void TestMethod7()
        {
            String result1;
            UpVisitor vis = new UpVisitor();
            BAZ obj = new BAZ();
            obj.accept(vis);
            vis.visit(obj);
            result1 = vis.ToString();
            Assert.AreEqual(result1, "do Up on " + obj.getBAZ());

        }
        //unit test for section 1.0,4.1,5.3,7.3
        [Test()]
        public void TestMethod8()
        {
            String result2;
            DownVisitor dvis = new DownVisitor();
            BAZ obj = new BAZ();
            obj.accept(dvis);
            dvis.visit(obj);
            result2 = dvis.ToString();
            Assert.AreEqual(result2, "do Down on " + obj.getBAZ());

        }
        //unit test for section 4.2
        [Test()]
        public void TestMethod9()
        {
            String result;
            BAZ obj = new BAZ();
            result = obj.getBAZ();
            Assert.AreEqual(result, "BAZ");
        }
    }
}
