
using AllShapes;
using System.Drawing;

namespace WindowsApplication;


public partial class Form1 : Form
{
        AllShapes.Point startPoint;
        AllShapes.Point endPoint;
    public Form1()
    {
        InitializeComponent();
           // Connect the Paint event of the PictureBox to the event handler method.
        Paint += new System.Windows.Forms.PaintEventHandler(OnPaint);   
        MouseDown+=new System.Windows.Forms.MouseEventHandler(onMouseDown);
        MouseUp+=new System.Windows.Forms.MouseEventHandler(onMouseUp);
    }

    //Event handlers
    public void OnPaint(object sender, PaintEventArgs e){
       
    }

    public void onMouseDown(object sender, MouseEventArgs e){
      
       startPoint=new AllShapes.Point(e.X, e.Y);


    }


     public void onMouseUp(object sender, MouseEventArgs e){
        endPoint=new AllShapes.Point(e.X, e.Y);
        Line l=new Line(startPoint, endPoint);
        Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0));
        Graphics g=this.CreateGraphics();
        g.DrawLine(pen,l.StartPoint.X, l.StartPoint.Y, l.EndPoint.X, l.EndPoint.Y);
    }
}