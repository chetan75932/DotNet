using Hardware;

namespace AllShapes;
public class Line:Shape, IPrinter{

    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}

    public Line():base()
    {
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);
    }


    public Line(Point p1,Point p2):base("red",24)
    {
            this.StartPoint=p1;
            this.EndPoint=p2;
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing Circle!");
    }

    void IPrinter.Print()
    {
        Console.WriteLine("Printing ");
    }

    public override String ToString()
    {
        return base.ToString()+this.StartPoint+" "+this.EndPoint;
    } 
} 