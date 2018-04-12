using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingShapes
{
    public partial class Form1 : Form
    {
        public ShapesList ShapesList { get; set; }
        public Shape SelectedShape { get; set; }
        public ShapeType Type { get; set; }
        public Color Color { get; set; }
        public bool IsMouseDown { get; set; }
        public int PrevX { get; set; }
        public int PrevY { get; set; }

        public Form1()
        {
            InitializeComponent();
            ShapesList = new ShapesList();
            SelectedShape = null;
            Type = ShapeType.Circle;
            Color = Color.Chocolate;
            DoubleBuffered = true;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShapesList.AddShape(e.X, e.Y, Color, Type);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            ShapesList.Draw(e.Graphics);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            foreach (var shape in ShapesList.Shapes)
                shape.Selected = false;
            SelectedShape = ShapesList.Select(e.X, e.Y);
            Invalidate();

            PrevX = e.X;
            PrevY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown && SelectedShape != null)
            {
                SelectedShape.Move(e.X - PrevX, e.Y - PrevY);
                Invalidate();

                PrevX = e.X;
                PrevY = e.Y;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && SelectedShape != null)
            {
                ShapesList.Shapes.Remove(SelectedShape);
                Invalidate();
            }
        }

        private void pickAColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var picker = new ColorDialog();
            var res = picker.ShowDialog();

            if (res == DialogResult.OK)
                Color = picker.Color;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type = ShapeType.Circle;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type = ShapeType.Rectangle;
        }

        private void generateNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapesList = new ShapesList();
            SelectedShape = null;
            Invalidate();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ShapesList.AddShape(random.Next(1, Size.Width), random.Next(1, Size.Height), Color, Type);
            Invalidate();
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type = ShapeType.Triangle;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}