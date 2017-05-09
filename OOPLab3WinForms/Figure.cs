using System.Collections.Generic;
using OOPLab3WinForms;

namespace OOPLab3
{
    public abstract class Figure
    {
        public virtual double Square { get; }
        public virtual double Volume { get; }
        public virtual double X { get; protected set; }
        public virtual double Y { get; protected set; }
        public virtual double Z { get; protected set; }

        
        

        public virtual double Perim { get; protected set; }

        public virtual string GetInfo()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}, Square: {Square}, Volume: {Volume}\n ";
        }

        public virtual string GetInfo2()
        {
            return this.GetType().Name + GetInfo();
        }

        public virtual void Scale(double factor)
        {

        }

        public virtual void Move(double x = 0, double y = 0, double z = 0)
        {
            X += x;
            Y += y;
            Z += z;
        }

        public virtual void SetPosition(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public virtual void Draw()
        {
            
        }

        public void DrawLine(
            float x1, float y1, float z1,
            float x2, float y2, float z2)
        {
            Program.GL.Vertex(x1, y1, z1);
            Program.GL.Vertex(x2, y2, z2);
        }

    }
}