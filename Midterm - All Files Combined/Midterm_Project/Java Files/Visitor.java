
//1.0: Element Interface
interface Element {
    void accept(Visitor v);
}

//2.0: FOO Class
class FOO implements Element {

    //2.1: Accept Method
    public void accept(Visitor v) {
        v.visit(this);
    }

    //2.2: GetFoo Method
    public String getFOO() {
        return "FOO";
    }
}

//3.0: Bar Class
class BAR implements Element {

    //3.1: Accept Method
    public void   accept( Visitor v ) {
        v.visit( this );
    }

    //3.2: GetBar Method
    public String getBAR() {
        return "BAR";
    }
}

//4.0: Baz Class
class BAZ implements Element {

    //4.1: Accept Method
    public void accept(Visitor v) {
        v.visit(this);
    }

    //4.2: GetBaz Method
    public String getBAZ() {
        return "BAZ";
    }
}

//5.0: Visitor Interface
interface Visitor {
    void visit(FOO foo);
    void visit(BAR bar);
    void visit(BAZ baz);
}

//6.0: UpVisitor Class
class UpVisitor implements Visitor {

    //6.1: Visit Method (Foo)
    public void visit(FOO foo) {
        System.out.println("do Up on " + foo.getFOO());
    }

    //6.2: Visit Method (Bar)
    public void visit(BAR bar) {
        System.out.println("do Up on " + bar.getBAR());
    }

    //6.3: Visit Method (Baz)
    public void visit(BAZ baz) {
        System.out.println( "do Up on " + baz.getBAZ() );
    }
}

//7.0: DownVisitor Class
class DownVisitor implements Visitor {

    //7.1: Visit Method (Foo)
    public void Visit(FOO foo) {
        System.out.println("do Down on " + foo.getFOO());
    }

    //7.2: Visit Method (Bar)
    public void visit(BAR bar) {
        System.out.println("do Down on " + bar.getBAR());
    }

    //7.3: Visit Method (Baz)
    public void visit(BAZ baz ) {
        System.out.println("do Down on " + baz.getBAZ());
    }
}

//8.0: VisitorDemo Class
public class VisitorDemo {

    //8.1: Main Method
    public static void main( String[] args ) {
        Element[] list = {new FOO(), new BAR(), new BAZ()};
        UpVisitor up = new UpVisitor();
        DownVisitor down = new DownVisitor();
        for (Element element : list) {
            element.accept(up);
        }
        for (Element element : list) {
            element.accept(down);
        }
    }
}
