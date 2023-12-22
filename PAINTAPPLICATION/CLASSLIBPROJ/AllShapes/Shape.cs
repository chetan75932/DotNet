namespace AllShapes;

public abstract class Shape{
    public String Color{set;get;}
    public int Thickness{get;set;}

    public Shape()
    {
        this.Color="Pink";
        this.Thickness=10;
    }

    public Shape(String Color,int Thickness)
    {
        this.Color=Color;
        this.Thickness=Thickness;
    }

    public abstract void Draw();

    public override string ToString()
    {
        return this.Color+" "+this.Thickness;
    }
}