
/**
 * 
 * AdaptorFactory Java Code
 * Midterm Project 1
 * Java Code source: https://sourcemaking.com/design_patterns/abstract_factory/java/2
 * 
 * All lines in Java matches up with lines in C# code
 */



/****************************
 Section 1: Expression Class
 *****************************/

class Expression implements Cloneable
{
    //1.1: str veriable
    public String str;

    //1.2 Expression Constructor
    public Expression(String str) 
    {
        this.str = str;
    }

    //1.3 Expression Clone Method
    //returns a clone of the current expression
    @Override
    public Expression clone() 
    {
        Expression clone = null;

        //prints out error if clone does not work
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

    //1.4 Expression ToString Method
    @Override
    public String toString() {
        return str;
    }
}


/***********************************
 Section 2.0: AbstractFactory Class
************************************/

//abstract factory class for PCFactory and NotPCFactory
abstract class AbstractFactory 
{
    //2.1 Prototype variable
    public Expression prototype;

    //2.2 makephase() method
    public Expression makePhase() 
    {
        return prototype.clone();
    }

    //2.3 makeCompromise() method
    public abstract Expression makeCompromise();

    //2.4 makeGrade() method
    public abstract Expression makeGrade();
}



/****************************
 Section 3.0: PCFactory Class
 *****************************/

class PCFactory extends AbstractFactory 
{
    //3.1 PCFactory constructor
    public PCFactory() 
    {
        prototype = new PCPhase();
    }

    //3.2 PCFactory makeCompormise method
    @Override
    public Expression makeCompromise() 
    {
        return new Expression("\"do it your way, any way, or no way\"");
    }

    //3.3 PCFactory makeGrade method
    @Override
    public Expression makeGrade() 
    {
        return new Expression("\"you pass, self-esteem intact\"");
    }
}



/**************************
 Section 4.0: PCPhase Class
 ***************************/

class PCPhase extends Expression 
{
    //4.1 next variable
    private static int next = 0;
    
    //4.2 list variable
    private static final String[] list = {"\"animal companion\"", "\"vertically challenged\"",
            "\"factually inaccurate\"", "\"chronologically gifted\""};

    //4.3 PCPhase constructor
    public PCPhase() 
    {
        super(list[next]);
        next = (next + 1) % list.length;
    }

    //4.4 PCPhase clone method
    @Override
    public Expression clone() 
    {
        return new PCPhase();
    }
}



/*****************************
 Section 5.0: NotPCPhase Class
 ******************************/

class NotPCPhase extends Expression 
{
    //5.1 next variable
    private static int next = 0;
    
    //5.2 list variable
    private static final String[] list = {"\"pet\"", "\"short\"", "\"lie\"", "\"old\""};

    //5.3 NotPCPhase constructor
    public NotPCPhase() 
    {
        super(list[next]);
        next = (next + 1) % list.length;
    }
    
    //5.4 NotPCPhase clone method
    @Override
    public Expression clone() 
    {
        return new NotPCPhase();
    }
}



/*******************************
 Section 6.0: NotPCFactory Class
 ********************************/

class NotPCFactory extends AbstractFactory 
{
    //6.1 NotPCFactory constructor
    public NotPCFactory() 
    {
        prototype = new NotPCPhase();
    }

    //6.2 NtPCFactory makeGrade method
    @Override
    public Expression makeGrade() 
    {
        return new Expression("\"my way, or the highway\"");
    }

    //6.3 NtPCFactory makeCompormise method
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
    //7.1 main method
    public static void main(String[] args) 
    {
        //creates a factory variable
        AbstractFactory factory;
        
        //checks to see if it is a PCFactory or NotPCFactory
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
