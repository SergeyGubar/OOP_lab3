using System;

namespace OOPLab3
{
    public class StrangeCone : Cone
    {
        public double Radius2 { get; set; }

        public void Scale(double factor)
        {
            base.Scale(factor);
            Radius2 *= factor;
        }
        public double Line {
            get { return Math.Sqrt(Math.Pow(Radius2 - Radius, 2) + Math.Pow(Height, 2)); }
        }

        public override double Square {
            get { return Pi * (Math.Pow(Radius, 2) + (Radius + Radius2) * Line + Math.Pow(Radius2, 2)); }
        }

        public override double Volume {
            get { return (double)1 / 3 * Pi * Height * (Math.Pow(Radius, 2) + Radius * Radius2 + Math.Pow(Radius2, 2)); }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Radius2 {Radius2}";
        }

        public StrangeCone(double x, double y, double z, double height, double radius, double radius2) : base(x, y, z,
            radius, height)
        {
            Radius2 = radius2;
        }
        public StrangeCone(double x, double y, double height, double radius, double radius2) : this(x, y, 0,
            height, radius, radius2)
        {
        }
        public StrangeCone(double x, double height, double radius, double radius2) : this(x, 0, 0,
            height, radius, radius2)
        {
        }
    }
}