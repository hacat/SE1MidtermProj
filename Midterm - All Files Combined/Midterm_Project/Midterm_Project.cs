using System;

namespace Midterm_Project
{
    class MainClass
    {
        //Main method to implment all the Patterns
        public static void Main(string[] args)
        {
            String[] arguments = new String [] { "args" };

            //Visitor Pattern implemented
            //Members 3 and 4
            Console.WriteLine("Visitor Pattern Results:\r\n");
            VisitorDemo visitor = new VisitorDemo();
            visitor.Maine(args);

            //Adaptor Factory Pattern implemented
            //This is with 1 argument so it will create a PCFactory
            //Members 5 and 6
            Console.WriteLine("\r\nAdaptor Factory Pattern Results:\r\n");
            FactoryFmProto factory = new FactoryFmProto();
            factory.Maine(arguments);

            //Adatper Pattern implemented
            //Members 1 and 2
            Console.WriteLine("\r\nAdaptor Pattern Results:\r\n");
            AdapterDemoSquarePeg adapter = new AdapterDemoSquarePeg();
            adapter.Maine(args);

        }
    }
}
