using System;
using OOPLab3WinForms;
using SharpGL.Enumerations;

namespace OOPLab3
{
    public class Circle : Figure
    {
        protected float prevX, prevY;
        public const double Pi = Math.PI;
        public double Radius { get; set; }

        public override double Square {
            get { return Pi * Math.Pow(Radius, 2); }
        }

        public override double Volume {
            get { return 0; }
        }


        public override void Scale(double factor)
        {
            base.Scale(factor);
            Radius *= factor;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Radius: {Radius}";
        }

        public override double Perim {
            get { return Pi * 2 * Radius; }
            protected set { }
        }

        public Circle(double x, double radius) : this(x, 0, 0, radius)
        {

        }
        public Circle(double x, double y, double radius) : this(x, y, 0, radius)
        {

        }
        public Circle(double x, double y, double z, double radius)
        {
            X = x;
            Y = y;
            Z = z;
            Radius = radius;
        }

        public override void Draw()
        {
            Program.GL.Begin(BeginMode.Lines);

            prevX = (float)Radius;
            prevY = (float)Radius;
            float x;
            float y;
            for (x = -(float)Radius; x <= (float)Radius; x += 0.001f)
            {
                y = (float)Math.Sqrt(Math.Pow(Radius, 2) * (1 - Math.Pow(x / Radius, 2)));
                DrawLine((float)X + prevX, (float)Y + prevY, (float)Z, (float)X + x, (float)Y + y, (float)Z);
                prevX = x;
                prevY = y;
            }
            for (x = (float)Radius; x >= -(float)Radius; x -= 0.001f)
            {
                y = -(float)Math.Sqrt(Math.Pow(Radius, 2) * (1 - Math.Pow(x / Radius, 2)));
                DrawLine((float)X + prevX, (float)Y + prevY, (float)Z, (float)X + x, (float)Y + y, (float)Z);
                prevX = x;
                prevY = y;
            }

            Program.GL.End();
        }
    }
}