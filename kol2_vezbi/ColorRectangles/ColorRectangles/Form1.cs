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

namespace ColorRectangles
{
    public partial class Form1 : Form
    {
        public RectangleDoc RectangleDoc { get; set; }
        public Color Color { get; set; }
        public string Filename { get; set; }
        private Point _teme1;
        private Point _teme2;
        private bool _drawingContour;

        public Form1()
        {
            InitializeComponent();
            Color = Color.Blue;
            RectangleDoc = new RectangleDoc(Color);
            Filename = string.Empty;
            _teme1 = _teme2 = Point.Empty;
            _drawingContour = true;
            this.DoubleBuffered = true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Color = dialog.Color;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start a new game?", "New game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RectangleDoc = new RectangleDoc(Color);
                Filename = string.Empty;
                Invalidate(true);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
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
                    formatter.Serialize(stream, RectangleDoc);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Color rectangles files (*.crf)|*.crf";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Filename = dialog.FileName;
            }
            else
                return;

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    RectangleDoc = (RectangleDoc) formatter.Deserialize(stream);
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
            dialog.Filter = "Color rectangles files (*.crf)|*.crf";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Filename = dialog.FileName;
            }
            else
                return;

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, RectangleDoc);
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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RectangleDoc.Hit(e.X, e.Y);
                Invalidate();
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (_teme1 == Point.Empty)
                {
                    _teme1 = new Point(e.X, e.Y);
                    _drawingContour = true;
                }
                else
                {
                    _teme2 = new Point(e.X, e.Y);
                    int width = Math.Abs(_teme2.X - _teme1.X);
                    int height = Math.Abs(_teme2.Y - _teme1.Y);
                    Point teme;

                    if (_teme2.X < _teme1.X && _teme2.Y < _teme1.Y)
                        teme = _teme2;
                    else if (_teme2.X > _teme1.X && _teme2.Y < _teme1.Y)
                        teme = new Point(_teme1.X, _teme2.Y);
                    else if (_teme2.X < _teme1.X && _teme2.Y > _teme1.Y)
                        teme = new Point(_teme2.X, _teme1.Y);
                    else
                        teme = _teme1;

                    RectangleDoc.AddRectangle(teme, width, height, Color);
                    _drawingContour = false;
                    _teme1 = Point.Empty;
                    Invalidate(true);
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_teme1 != Point.Empty)
            {
                _teme2 = new Point(e.X, e.Y);
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            RectangleDoc.Draw(e.Graphics);

            if (_drawingContour)
            {
                Pen pen = new Pen(Color.Gray, 2);
                pen.DashStyle = DashStyle.Dot;

                int width = Math.Abs(_teme2.X - _teme1.X);
                int height = Math.Abs(_teme2.Y - _teme1.Y);
                if (_teme2.X < _teme1.X && _teme2.Y < _teme1.Y)
                    e.Graphics.DrawRectangle(pen, _teme2.X, _teme2.Y, width, height);
                else if (_teme2.X > _teme1.X && _teme2.Y < _teme1.Y)
                    e.Graphics.DrawRectangle(pen, _teme1.X, _teme2.Y, width, height);
                else if (_teme2.X < _teme1.X && _teme2.Y > _teme1.Y)
                    e.Graphics.DrawRectangle(pen, _teme2.X, _teme1.Y, width, height);
                else
                    e.Graphics.DrawRectangle(pen, _teme1.X, _teme1.Y, width, height);
                pen.Dispose();
            }

            if (Filename != string.Empty)
                this.Text = $"Rectangles | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Rectangles";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblRectangles.Text = $"Rectangles: {RectangleDoc.RectanglesCount()}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RectangleDoc.DeleteSelected();
                Invalidate(true);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangleDoc.DeleteSelected();
            Invalidate(true);
        }
    }
}