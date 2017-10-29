/* The OLD */
//1.0: SquarePeg Class
class SquarePeg {

    //1.1: Width Variable
    private double width;

    //1.2: SquarePeg Constructor
    public SquarePeg(double width) {
        this.width = width;
    }

    //1.3: GetWidth Method
    public double getWidth() {
        return width;
    }

    //1.4: SetWidth Method
    public void setWidth(double width) {
        this.width = width;
    }
}

/* The NEW */
//2.0: Round Hole Class
class RoundHole {

    //2.1: Radius Variable
    private final int radius;

    //2.2: RoundHole Constructor
    public RoundHole(int radius) {
        this.radius = radius;
        System.out.println("RoundHole: max SquarePeg is " + radius * Math.sqrt(2));
    }

    //2.3: GetRadius Method
    public int getRadius() {
        return radius;
    }
}

// Design a "wrapper" class that can "impedance match" the old to the new
//3.0: SquarePegAdapter Class
class SquarePegAdapter {
    // The adapter/wrapper class "has a" instance of the legacy class
    //3.1: SquarePeg Variable
    private final SquarePeg squarePeg;

    //3.2: SquarePegAdapter Constructor
    public SquarePegAdapter(double w) {
        squarePeg = new SquarePeg(w);
    }

    // Identify the desired interface
    //3.3: MakeFit Method
    public void makeFit(RoundHole roundHole) {
        // The adapter/wrapper class delegates to the legacy object
        double amount = squarePeg.getWidth() - roundHole.getRadius() * Math.sqrt(2);
        System.out.println( "reducing SquarePeg " + squarePeg.getWidth() + " by " + ((amount < 0) ? 0 : amount) + " amount");
        if (amount > 0) {
            squarePeg.setWidth(squarePeg.getWidth() - amount);
            System.out.println("   width is now " + squarePeg.getWidth());
        }
    }
}

//4.0: AdapterDemoSquarePeg Class
public class AdapterDemoSquarePeg {

    //4.1: Main Method
    public static void main( String[] args ) {
        RoundHole roundHole = new RoundHole( 5 );
        SquarePegAdapter squarePegAdapter;
        for (int i = 6; i < 10; i++) {
            squarePegAdapter = new SquarePegAdapter((double)i);
            // The client uses (is coupled to) the new interface
            squarePegAdapter.makeFit(roundHole);
        }
    }
}
