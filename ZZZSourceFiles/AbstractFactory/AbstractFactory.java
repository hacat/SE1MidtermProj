
/**
 * 
 * AdaptorFactory Java Code
 * Midterm Project 1
 * Java Code source: https://sourcemaking.com/design_patterns/abstract_factory/java/2
 * 
 * All lines in Java matches up with lines in C# code
 */



/*********************
    Expression Class
 *********************/

class Expression implements Cloneable
{
    public String str;

    //Store Expression
    public Expression(String str) 
    {
        this.str = str;
    }

    //Clone Expression
    @Override
    public Expression clone() 
    {
        Expression clone = null;
        //if cloning does not work, print exception
        try 
        {
            clone = (Expression)super.clone();
        } 
        catch (CloneNotSupportedException ex) 
        {
            ex.printStackTrace();
        }
        return clone;
    }

    @Override
    public String toString() {
        return str;
    }
}


/*********************
 AbstractFactory Class
*********************/

abstract class AbstractFactory 
{
    public Expression prototype;

    public Expression makePhase() 
    {
        return prototype.clone();
    }

    public abstract Expression makeCompromise();

    public abstract Expression makeGrade();
}



/*********************
   PCFactory Class
*********************/

class PCFactory extends AbstractFactory 
{

    public PCFactory() 
    {
        prototype = new PCPhase();
    }

    @Override
    public Expression makeCompromise() 
    {
        return new Expression("\"do it your way, any way, or no way\"");
    }

    @Override
    public Expression makeGrade() 
    {
        return new Expression("\"you pass, self-esteem intact\"");
    }
}



/*********************
    PCPhase Class
*********************/

class PCPhase extends Expression 
{
    private static int next = 0;
    private static final String[] list = {"\"animal companion\"", "\"vertically challenged\"",
            "\"factually inaccurate\"", "\"chronologically gifted\""};

    public PCPhase() 
    {
        super(list[next]);
        next = (next + 1) % list.length;
    }

    @Override
    public Expression clone() 
    {
        return new PCPhase();
    }
}



/*********************
   NotPCPhase Class
*********************/

class NotPCPhase extends Expression 
{
    private static int next = 0;
    private static final String[] list = {"\"pet\"", "\"short\"", "\"lie\"", "\"old\""};

    public NotPCPhase() 
    {
        super(list[next]);
        next = (next + 1) % list.length;
    }

    @Override
    public Expression clone() 
    {
        return new NotPCPhase();
    }
}



/*********************
  NotPCFactory Class
*********************/

class NotPCFactory extends AbstractFactory 
{

    public NotPCFactory() 
    {
        prototype = new NotPCPhase();
    }

    @Override
    public Expression makeGrade() 
    {
        return new Expression("\"my way, or the highway\"");
    }

    @Override
    public Expression makeCompromise() 
    {
        return new Expression("\"take test, deal with the results\"");
    }
}



/*********************
 FactoryFmProto Class
*********************/

public class FactoryFmProto 
{
    public static void main(String[] args) 
    {
    
        AbstractFactory factory;
        if (args.length  > 0) 
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
            System.out.print(factory.makePhase() + " ");
        }
        //Print out results
        System.out.println();
        System.out.println(factory.makeCompromise());
        System.out.println(factory.makeGrade());
    }
}