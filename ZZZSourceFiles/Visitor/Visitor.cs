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
    String visit(FOO foo);
	//see section 5.2 in the java file
    String visit(BAR bar);
	//see section 5.3 in the java file
    String visit(BAZ baz);
}

//class function, the colon (:) is the same as (implements) in java.
//implements, or the colon (:) allows the use of parent function
//see section 6.0 in the java file
class UpVisitor : Visitor
{
	//see section 6.1 in the java file
    public String visit(FOO foo)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println
        String result = "do Up on " + foo.getFOO();

        //Console.WriteLine("do Up on " + foo.getFOO());
        return result;
    }

	//see section 6.2 in the java file
    public String visit(BAR bar)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println

        //Console.WriteLine("do Up on " + bar.getBAR());
        String result = "do Up on " + bar.getBAR();
        return result;
    }

	//see section 6.3 in the java file
    public String visit(BAZ baz)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println
        //Console.WriteLine("do Up on " + baz.getBAZ());
        String result = "do Up on " + baz.getBAZ();
        return result;
    }
}

//class function, the colon (:) is the same as (implements) in java.
//implements, or the colon (:) allows the use of parent function
//see section 7.0 in the java file
class DownVisitor : Visitor
{
	//see section 7.1 in the java file
    public String visit(FOO foo)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println
        String result = "do Down on " + foo.getFOO();
        //Console.WriteLine("do Down on " + foo.getFOO());
        return result;
    }

	//see section 7.2 in the java file
    public String visit(BAR bar)
    {
		//Console.WriteLine writes information to the use from the console
		//or command line. the Console.writeLine is the same functionality
		//as the java command System.out.println
        //Console.WriteLine("do Down on " + bar.getBAR());
        String result= "do Down on " + bar.getBAR();
        return result;
    }

	//see section 7.3 in the java file
    public String visit(BAZ baz)
    {
        //Console.WriteLine writes information to the use from the console
        //or command line. the Console.writeLine is the same functionality
        //as the java command System.out.println
        //Console.WriteLine("do Down on " + baz.getBAZ());
        String result = "do Down on " + baz.getBAZ();
        return result;
    }
}


//see section 8.0 in the java file
public class VisitorDemo
{
	//here the Main function has to be capitalized in C# (i.e. (M)ain compared to its
	//counter-part in java
	//see section 8.1 in the java file
    public static void Maine(String[] args)
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
