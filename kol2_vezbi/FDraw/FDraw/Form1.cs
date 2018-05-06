using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDraw
{
    public partial class Form1 : Form
    {
        public RectanglesDoc RectanglesDoc { get; set; }
        public Color Color { get; set; }
        public string Filename { get; set; }

        private bool _ctrlPressed;
        private bool _mousePressed;
        private bool mouseMoved;
        private bool _selected;
        private bool _drawingContour;
        private Point _startPoint;
        private Point _endPoint;
        private int _height;
        private int _width;
        private int _prevX;
        private int _prevY;

        public Form1()
        {
            InitializeComponent();
            RectanglesDoc = new RectanglesDoc();
            Color = Color.DarkBlue;
            Filename = string.Empty;
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMoved = false;
            _mousePressed = true;
            _selected = RectanglesDoc.Select(e.Location);
            if (!_selected)
            {
                _startPoint = e.Location;
                _drawingContour = true;
            }
            else
            {
                _prevX = e.X;
                _prevY = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _mousePressed = false;
            if (!_selected && mouseMoved) // nothing selected, add a shape
            {
                var position = GetPosition();

                if (_ctrlPressed) // add a square
                {
                    int max = Math.Max(_width, _height);
                    RectanglesDoc.AddRectangle(position, max, max, Color);
                }
                else // add a rectangle
                {
                    RectanglesDoc.AddRectangle(position, _width, _height, Color);
                }
            }

            _selected = false;
            RectanglesDoc.ClearSelected();
            _startPoint = Point.Empty;
            _drawingContour = true;
            Invalidate(true);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoved = true;
            if (!_mousePressed)
                return;
            if (_selected)
            {
                RectanglesDoc.Move(e.X - _prevX, e.Y - _prevY);
                _prevX = e.X;
                _prevY = e.Y;
                _drawingContour = false;
            }
            else
            {
                int diffX = e.Location.X - _startPoint.X;
                int diffY = e.Location.Y - _startPoint.Y;
                _width = Math.Abs(diffX);
                _height = Math.Abs(diffY);

                if (_ctrlPressed) // draw a contour square
                {
                    int max = Math.Max(_width, _height);
                    int xm = (diffX) < 0 ? -1 : 1;
                    int ym = (diffY) < 0 ? -1 : 1;
                    _endPoint = new Point(_startPoint.X + max * xm, _startPoint.Y + max * ym);
                }
                else // draw a contour rectangle
                    _endPoint = e.Location;
            }

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                _ctrlPressed = true;
            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                _ctrlPressed = false;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            RectanglesDoc.Draw(e.Graphics);

            if (_drawingContour && _startPoint != Point.Empty)
            {
                var pen = new Pen(Color.Gray, 2);
                pen.DashStyle = DashStyle.Dot;
                var position = GetPosition();

                if (_ctrlPressed) // draw a contour square
                {
                    int max = Math.Max(_width, _height);
                    e.Graphics.DrawRectangle(pen, position.X, position.Y, max, max);
                }
                else // draw a contour rectangle
                {
                    e.Graphics.DrawRectangle(pen, position.X, position.Y, _width, _height);
                }

                pen.Dispose();
            }

            if (Filename != string.Empty)
                this.Text = $"FDraw | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "FDraw";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblShapes.Text = $"Shapes: {RectanglesDoc.Count}";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RectanglesDoc = new RectanglesDoc();
                Filename = string.Empty;
                ResetValues();
                Invalidate(true);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "FDraw files (*.fdw)|*.fdw";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else return;

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    RectanglesDoc = (RectanglesDoc) formatter.Deserialize(stream);
                    ResetValues();
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Filename == string.Empty)
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, RectanglesDoc);
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "FDraw files (*.fdw)|*.fdw";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else return;

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, RectanglesDoc);
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                Color = dialog.Color;
        }

        public Point GetPosition()
        {
            int x = Math.Min(_startPoint.X, _endPoint.X);
            int y = Math.Min(_startPoint.Y, _endPoint.Y);
            return new Point(x, y);
        }

        public void ResetValues()
        {
            _ctrlPressed = _mousePressed = mouseMoved = _selected = false;
            _drawingContour = true;
            _startPoint = _endPoint = Point.Empty;
            _height = _width = _prevX = _prevY = -1;
        }
    }
}