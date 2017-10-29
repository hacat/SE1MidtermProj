//System is a language library that allows the use of console functions
//such as console.write line etc.
using System;

//Element Interface
interface Element
{
    void accept(Visitor v);
}

//in all of the class function, the colon (:) is the same as (implements) in java.
//implements, or the colon (:) allows the use of parent function
//see section 2.0 in the java file
class FOO : Element
{
	//see section 2.1 in the java file
    public void accept(Visitor v)
    {
        v.visit(this);
    }

	//see section 2.2 in the java file
    public String getFOO()
    {
        return "FOO";
    }
}

//class function, the colon (:) is the same as (implements) in java.
//implements, or the colon (:) allows the use of parent function
//see section 3.0 in the java file
class BAR : Element
{
	//see section 3.1 in the java file
    public void accept(Visitor v)
    {
        v.visit(this);
    }

	//see section 3.2 in the java file
    public String getBAR()
    {
        return "BAR";
    }
}

//class function, the colon (:) is the same as (implements) in java.
//implements, or the colon (:) allows the use of parent function
//see section 4.0 in the java file
class BAZ : Element
{
	//see section 4.1 in the java file
    public void accept(Visitor v)
    {
        v.visit(this);
    }

	//see section 4.2 in the java file
    public String getBAZ()
    {
        return "BAZ";
    }
}

//see section 5.0 in the java file
interface Visitor
{
	//see section 5.1 in the java file
    void visit(FOO foo);
	//see section 5.2 in the java file
    void visit(BAR bar);
	//see section 5.3 in the java file
    void visit(BAZ baz);
}

//class function, the colon (:) is the same as (implements) in java.
//implements, or the colon (:) allows the use of parent function
//see section 6.0 in the java file
class UpVisitor : Visitor
{
    public String str;

	//see section 6.1 in the java file
    public void visit(FOO foo)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println
        Console.WriteLine("do Up on " + foo.getFOO());
        str = ("do Up on " + foo.getFOO());
    }

	//see section 6.2 in the java file
    public void visit(BAR bar)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println
        Console.WriteLine("do Up on " + bar.getBAR());
        str = ("do Up on " + bar.getBAR());
    }

	//see section 6.3 in the java file
    public void visit(BAZ baz)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println
        Console.WriteLine("do Up on " + baz.getBAZ());
        str = ("do Up on " + baz.getBAZ());
    }

    public override String ToString() => str;
}

//class function, the colon (:) is the same as (implements) in java.
//implements, or the colon (:) allows the use of parent function
//see section 7.0 in the java file
class DownVisitor : Visitor
{

    public String str;

	//see section 7.1 in the java file
    public void visit(FOO foo)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println
        Console.WriteLine("do Down on " + foo.getFOO());
        str = ("do Down on " + foo.getFOO());
    }

	//see section 7.2 in the java file
    public void visit(BAR bar)
    {
		//Console.WriteLine writes information to the use from the console
		//or command line. the Console.writeLine is the same functionality
		//as the java command System.out.println
        Console.WriteLine("do Down on " + bar.getBAR());
        str = ("do Down on " + bar.getBAR());
    }

	//see section 7.3 in the java file
    public void visit(BAZ baz)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println
        Console.WriteLine("do Down on " + baz.getBAZ());
        str = ("do Down on " + baz.getBAZ());
    }

    public override String ToString() => str;
}


//see section 8.0 in the java file
public class VisitorDemo
{
    //here the Main function has to be capitalized in C# (i.e. (M)ain compared to its
    //counter-part in java
    //see section 8.1 in the java file
    public void Maine(String[] args)
    {
        Element[] list = { new FOO(), new BAR(), new BAZ() };
        UpVisitor up = new UpVisitor();
        DownVisitor down = new DownVisitor();
        //for a for loop in C# it is a foreach statement, compared to its
        //counter part in java, which is simply for
        foreach (Element element in list)
        {
            element.accept(up);
        }
        //for a for loop in C# it is a foreach statement, compared to its
        //counter part in java, which is simply for
        foreach (Element element in list)
        {
            element.accept(down);
        }
    }
}
