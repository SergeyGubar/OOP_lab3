using System;
using OOPLab3WinForms;
using SharpGL.Enumerations;

namespace OOPLab3
{
    public class Ellipse : Circle
    {
        public double Radius2 { get; set; }
        protected float prevX, prevY;
        public override double Square {
            get { return Radius * Radius2 * Pi; }
        }

        public override double Volume {
            get { return 0; }
        }
        public override void Scale(double factor)
        {
            base.Scale(factor);
            Radius2 *= factor;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Radius2: {Radius2}";
        }

        public override double Perim
        {
            get { return 2 * Pi * Math.Sqrt((Math.Pow(Radius, 2) + Math.Pow(Radius2, 2)) / 2); }
            protected set { }
        }

        public Ellipse(double x, double y, double z, double r1, double r2) : base(x, y, z, r1)
        {
            Radius2 = r2;
        }
        public Ellipse(double x, double y, double r1, double r2) : this(x, y, 0, r1, r2)
        {
        }
        public Ellipse(double x, double r1, double r2) : this(x, 0, 0, r1, r2)
        {
        }

        public override void Draw()
        {
            Program.GL.Begin(BeginMode.Lines);
            float x;
            float y;
            for (x = 2 * -(float) Radius; x <= 2 * (float) Radius; x += 0.001f)
            {
                
                y = (float) Math.Sqrt(Math.Pow(Radius2, 2) * (1 - Math.Pow(x / Radius, 2)));
                DrawLine((float)X + prevX, (float)Y + prevY, (float)Z, (float)X + x, (float)Y + y, (float)Z);
                prevX = x;
                prevY = y;
            }
            for (x = 2 * (float)Radius; x >= 2 * -(float)Radius; x -= 0.001f)
            {
                
                y = -(float)Math.Sqrt(Math.Pow(Radius2, 2) * (1 - Math.Pow(x / Radius, 2)));
                DrawLine((float)X + prevX, (float)Y + prevY, (float)Z, (float)X + x, (float)Y + y, (float)Z);
                prevX = x;
                prevY = y;
            }


            Program.GL.End();
        }
    }
}