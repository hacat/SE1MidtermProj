using System;
/**
 * AdaptorFactory C# Code
 * Midterm Project 1
 * Coverted Java Code from source: https://sourcemaking.com/design_patterns/abstract_factory/java/2
 * All lines in C# matches up with lines in Java code
 */

namespace AdaptorFactoryPattern
{
    public interface ICloneable { }

    /*********************
       Expression Class
    *********************/

    class Expression : ICloneable
    {
        public String str;

        //Store Expression
        public Expression(String str)
        {
            this.str = str;
        }


        //Clone Expression
        public virtual Expression Clone()
        {
            Expression clone = null;
            //if cloning does not work, print exception
            try
            {
                clone = (Expression)this.MemberwiseClone();
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return clone;
        }


        public override String ToString() => str;

    }



    /*********************
     AbstractFactory Class
     *********************/

    abstract class AbstractFactory
    {
        public Expression prototype;

        public Expression makePhase()
        {
            return prototype.Clone();
        }

        public abstract Expression makeCompromise();

        public abstract Expression makeGrade();
    }



    /*********************
       PCFactory Class
    *********************/

    class PCFactory : AbstractFactory
    {

        public PCFactory()
        {
            prototype = new PCPhase();
        }


        public override Expression makeCompromise()
        {
            return new Expression("\"do it your way, any way, or no way\"");
        }


        public override Expression makeGrade()
        {
            return new Expression("\"you pass, self-esteem intact\"");
        }
    }



    /*********************
        PCPhase Class
    *********************/

    class PCPhase : Expression
    {
        private static int next = 0;
        private static readonly String[] list = {"\"animal companion\"", "\"vertically challenged\"",
                    "\"factually inaccurate\"", "\"chronologically gifted\""};


        public PCPhase() : base(list[next])
        {
            next = (next + 1) % list.Length;
        }


        public override Expression Clone()
        {
            return new PCPhase();
        }
    }



    /*********************
       NotPCPhase Class
    *********************/

    class NotPCPhase : Expression
    {
        private static int next = 0;
        private static readonly String[] list = { "\"pet\"", "\"short\"", "\"lie\"", "\"old\"" };


        public NotPCPhase() : base(list[next])
        {
            next = (next + 1) % list.Length;
        }


        public override Expression Clone()
        {
            return new NotPCPhase();
        }
    }



    /*********************
      NotPCFactory Class
    *********************/

    class NotPCFactory : AbstractFactory
    {

        public NotPCFactory()
        {
            prototype = new NotPCPhase();
        }


        public override Expression makeCompromise()
        {
            return new Expression("\"my way, or the highway\"");
        }


        public override Expression makeGrade()
        {
            return new Expression("\"take test, deal with the results\"");
        }
    }



    /*********************
     FactoryFmProto Class
    *********************/

    public class FactoryFmProto
    {
        public static void Maine(String[] args)
        {

            AbstractFactory factory;
            if (args.Length > 0)
            {
                factory = new PCFactory();
            }
            else
            {
                factory = new NotPCFactory();
            }
            //Loop through all the phrases and prints them out
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(factory.makePhase() + " ");
            }
            //Print out results
            Console.WriteLine();
            Console.WriteLine(factory.makeCompromise());
            Console.WriteLine(factory.makeGrade());
        }
    }
}
