using System;

namespace OOPLab3
{
    public class Cone : Circle
    {
        public double Height { get; set; }

        public double Line { //<---- это образующая, я просто названия подходящего не нашел
            get { return Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2)); }
            set { }
        }

        public override double Square {
            get { return base.Square + Pi * Radius * Line; }
        }

        public override double Volume {
            get { return 1 / 3 * base.Square * Height; }
        }

        public void Scale(double factor)
        {
            base.Scale(factor);
            Height *= factor;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Height: {Height}, Line {Line}, ";
        }

        public override double Perim { get { return 0; }
            protected set { }
        }

        public Cone(double x, double y, double z, double radius, double height) : base(x,y,z,radius)
        {
            Height = height;
        }
        public Cone(double x, double y,  double radius, double height) : this(x, y, 0, radius, height)
        {
        }
        public Cone(double x, double radius, double height) : this(x, 0, 0, radius, height)
        {
        }


        
    }
}