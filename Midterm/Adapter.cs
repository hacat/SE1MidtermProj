using System;
/**
*  Modified and translated Java code from "Adapter in Java" 
*  from Java to C#.
* 
*  https://sourcemaking.com/design_patterns/adapter/java/2
*/
//TODO: Test cases, Traceability, time spent on every task
namespace Midterm
{
    /* THE OLD */
    class SquarePeg{
        private double width;

        public SquarePeg(double width){
            this.width = width;
        }

        public double getWidth(){
            return width;
        }

        public void setWidth(double width){
            this.width = width;   
        }
    }

    /* THE NEW */
    class RoundHole{
        private readonly int radius;

        public RoundHole(int radius){
            this.radius = radius;
            Console.WriteLine("RoundHole: max SquarePeg is " + radius * Math.Sqrt(2));
        }

        public int getRadius(){
            return radius;
        }
    }

    // Design a "wrapper" class that can "impedance match" the old to the new
    class SquarePegAdapter
    {
        // The adapter/wrapper class "has a" instance of the legacy class
        private readonly SquarePeg squarePeg;

    public SquarePegAdapter(double w)
        {
            squarePeg = new SquarePeg(w);
        }

        // Identify the desired interface
        public void makeFit(RoundHole roundHole)
        {
            
            // The adapter/wrapper class delegates to the legacy object
            double amount = squarePeg.getWidth() - roundHole.getRadius() * Math.Sqrt(2);
            Console.WriteLine("reducing SquarePeg " + squarePeg.getWidth() + " by " + ((amount < 0) ? 0 : amount) + " amount");
            if (amount > 0)
            {
                squarePeg.setWidth(squarePeg.getWidth() - amount);
                Console.WriteLine("   width is now " + squarePeg.getWidth());
            }
        }
    }

    class AdapterDemoSquarePeg
    {
        public static void Main(string[] args)
        {
            RoundHole roundHole = new RoundHole(5);
            SquarePegAdapter squarePegAdapter;
            for (int i = 6; i < 10; i++)
            {
                squarePegAdapter = new SquarePegAdapter((double)i);
                // The client uses (is coupled to) the new interface
                squarePegAdapter.makeFit(roundHole);
            }
        }
    }
}
/** 
Traceability

Hi,

Let me start with this text from 
https://en.wikipedia.org/wiki/Traceability#Systems_and_software_development.
========
Systems and software development
In systems and software development; 
the term traceability (or Requirements Traceability) refers to the ability to 
link product requirements back to stakeholders' rationales and forward to 
corresponding design artifacts, code, and test cases. Traceability supports 
numerous software engineering activities such as change impact analysis,
compliance verification or traceback of code, regression test selection, 
and requirements validation. It is usually accomplished in the form of a matrix 
created for the verification and validation of the project. Unfortunately the 
practice of constructing and maintaining a requirements trace matrix (RTM) can 
be very arduous and over time the traces tend to erode into an inaccurate state
unless date/time stamped. Alternate automated approaches for generating traces 
using information retrieval methods have been developed.

In transaction processing software, traceability implies use of a unique piece 
of data (e.g., order date/time or a serialized sequence number) which can be 
traced through the entire software flow of all relevant application programs. 
Messages and files at any point in the system can then be audited for 
correctness and completeness, using the traceability key to find the particular
transaction */