using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpGL;
using OOPLab3;
using Image = OOPLab3.Image;
using Point = OOPLab3.Point;

namespace OOPLab3WinForms
{
    public partial class Form1 : Form
    {
        private Image image;
        private float YOUSPINME = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.GL = openGLControl1.OpenGL;
            image = new Image();
            image.list.Add(new Point(0.5, 0, 0));
        }

        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            YOUSPINME += (float) rotationSpeed.Value;
            Program.GL.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            Program.GL.LoadIdentity();
            Program.GL.LineWidth((float)lineSize.Value);
            Program.GL.PointSize((float)pointSize.Value);
            Program.GL.Translate(0, 0, -1);
            Program.GL.Rotate(0, YOUSPINME, 0);
            Program.GL.Color((float)colorR.Value, (float)colorG.Value, (float)colorB.Value);


            image.Draw();

            Program.GL.Flush();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioPoint.Checked)
            {
                image.list.Add(new Point((float)positionX.Value, (float)positionY.Value, (float)positionZ.Value));
            }
            if (radioCircle.Checked)
            {
                image.list.Add(new Circle((float)positionX.Value, (float)positionY.Value, (float)positionZ.Value, 0.2));
            }
            if (radioColoredCircle.Checked)
            {
                image.list.Add(new ColoredCircle((float)positionX.Value, (float)positionY.Value, (float)positionZ.Value, Color.AliceBlue, 0.2));
            }
            if (radioEllipse.Checked)
            {
                image.list.Add(new Ellipse((float)positionX.Value, (float)positionY.Value, (float)positionZ.Value,0.2f,0.4f));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            image.list.Clear();
        }
    }
}
