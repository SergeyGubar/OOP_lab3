using System;
using System.Drawing;
using OOPLab3WinForms;
using SharpGL.Enumerations;

namespace OOPLab3
{
    public class ColoredCircle : Circle
    {
        public Color Color { get; set; }
        public override string GetInfo()
        {
            return base.GetInfo() + $"Color: {Color}";
        }

        public ColoredCircle(double x, double y, double z, Color clr, double radius) : base(x, y, z, radius)
        {
            Color = clr;
        }
        public ColoredCircle(double x, double y, Color clr, double radius) : this(x, y, 0, clr, radius)
        {
        }
        public ColoredCircle(double x, Color clr, double radius) : this(x, 0, 0, clr, radius)
        {
        }

        public override void Draw()
        {
            Program.GL.Begin(BeginMode.Polygon);

            //delta = (2 * (float)Math.PI * (float)Radius) / (360 / (float)Radius);
            prevX = (float)Radius;
            prevY = 0;
            for (float i = 1; i <= 361; i += (float)Radius * 5)
            {
                float y = (float)Radius * (float)Math.Sin(i / 180 * Math.PI);
                float x = (float)Radius * (float)Math.Cos(i / 180 * Math.PI);
                Program.GL.Color(1f, 1f, 1f);
                DrawLine((float)X + prevX, (float)Y + prevY, (float)Z, (float)X + x, (float)Y + y, (float)Z);
                prevX = x;
                prevY = y;
            }

            Program.GL.End();
        }
    }
}