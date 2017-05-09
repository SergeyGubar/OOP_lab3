
using OOPLab3WinForms;
using SharpGL.Enumerations;


namespace OOPLab3
{
    public class Point : Figure
    {
        public override double Square {
            get { return 0; }
        }
        public override double Volume {
            get { return 0; }
        }

        public override double Perim {
            get { return 0; }
            protected set { }
        }

        public Point(double x) : this(x, 0, 0)
        {
        }
        public Point(double x, double y) : this(x, y, 0)
        {
        }
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override void Draw()
        {
            Program.GL.Begin(BeginMode.Points);

            Program.GL.Vertex(X, Y, Z);

            Program.GL.End();
        }
    }
}