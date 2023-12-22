namespace AllShapes;

public class Point{
        public int X{get;set;}
        public int Y{get;set;}

        public Point()
        {
            this.X=this.Y=0;
        }

        public Point(int x_coordinate,int y_coordinate)
        {
            this.X=x_coordinate;
            this.Y=y_coordinate;
        }

        public override String ToString()
        {
            return  string.Format("X={0},Y={1}",this.X,this.Y);
        }
} 