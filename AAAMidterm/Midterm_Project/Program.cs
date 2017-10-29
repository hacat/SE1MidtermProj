using System;

namespace Midterm_Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String[] arguments = new String [] { "args" };

            //Visitor Pattern implemented
            VisitorDemo visitor = new VisitorDemo();
            visitor.Maine(args);

            //Adaptor Factory Pattern implemented
            //This is with 1 argument so it will create a PCFactory
            FactoryFmProto factory = new FactoryFmProto();
            factory.Maine(arguments);

            //Adatper Pattern implemented
            SquarePegAdapter adapter = new SquarePegAdapter();
            adapter.Maine(args);

        }
    }
}
