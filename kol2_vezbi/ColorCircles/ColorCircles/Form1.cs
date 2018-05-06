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

namespace ColorCircles
{
    public partial class Form1 : Form
    {
        public CircleDoc CircleDoc { get; set; }
        public Color Color { get; set; }
        public string Filename { get; set; }
        private Point _center;
        private int _radius;
        private bool _drawingContour;

        public Form1()
        {
            InitializeComponent();
            CircleDoc = new CircleDoc();
            Color = Color.DarkBlue;
            Filename = string.Empty;
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _center = Point.Empty;
            _radius = -1;
            _drawingContour = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_center == Point.Empty)
                {
                    _center = e.Location;
                    _drawingContour = true;
                }
                else
                {
                    _radius = (int) Math.Sqrt(Math.Pow(_center.X - e.X, 2) + Math.Pow(_center.Y - e.Y, 2));
                    CircleDoc.AddCircle(_center, Color, _radius);
                    _drawingContour = false;
                    _center = Point.Empty;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                CircleDoc.Select(e.Location);
            }

            Invalidate(true);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drawingContour)
            {
                _radius = (int) Math.Sqrt(Math.Pow(_center.X - e.X, 2) + Math.Pow(_center.Y - e.Y, 2));
                Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _drawingContour = false;
                _center = Point.Empty;
                Invalidate();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                CircleDoc.RemoveSelected();
                Invalidate(true);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            CircleDoc.Draw(e.Graphics);

            if (_drawingContour && _center != Point.Empty)
            {
                var pen = new Pen(Color.Gray, 3);
                pen.DashStyle = DashStyle.Dot;
                e.Graphics.DrawEllipse(pen, _center.X - _radius, _center.Y - _radius, _radius * 2, _radius * 2);
                pen.Dispose();
            }

            if (Filename != string.Empty)
                this.Text = $"Color Circles | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Color Circles";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblCircles.Text = $"Circles: {CircleDoc.CirclesCount()}";
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                Color = dialog.Color;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectAllToolStripMenuItem.Text == "Select &All")
            {
                CircleDoc.SelectAll(true);
                selectAllToolStripMenuItem.Text = "Unselect &All";
            }
            else
            {
                CircleDoc.SelectAll(false);
                selectAllToolStripMenuItem.Text = "Select &All";
            }

            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CircleDoc = new CircleDoc();
                Filename = String.Empty;
                Invalidate(true);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Color circles file (*.ccf)|*.ccf";
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
                    CircleDoc = (CircleDoc) formatter.Deserialize(stream);
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
                Filename = string.Empty;
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
                    formatter.Serialize(stream, CircleDoc);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
                Filename = string.Empty;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Color circles file (*.ccf)|*.ccf";
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
                    formatter.Serialize(stream, CircleDoc);
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
                Filename = string.Empty;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}