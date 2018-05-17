using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingRectangles
{
    public partial class Form1 : Form
    {
        public RectangleDoc RectangleDoc { get; set; }
        public Color Color { get; set; }
        public string Filename { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            RectangleDoc = new RectangleDoc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color = Color.Green;
            Filename = string.Empty;
            timer.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                RectangleDoc.LeftButtonClick(e.Location);
            else if (e.Button == MouseButtons.Right)
                RectangleDoc.RightButtonClick(e.Location);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RectangleDoc.AddRectangle(e.Location, Color);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            RectangleDoc.DrawRectangles(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Moving Rectangles | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Moving Rectangles";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            lblTotal.Text = $"R: {RectangleDoc.Count}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int height = this.Height - statusStrip1.Height;
            RectangleDoc.MoveRectangles(height);
            RectangleDoc.RotateRectangles(this.Width);

            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RectangleDoc = new RectangleDoc();
                Filename = string.Empty;
                Color = Color.Green;
                Invalidate(true);
            }

            timer.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            var dialog = new OpenFileDialog();
            dialog.Filter = "Moving Rectangle Files (*.mrf) | *.mrf";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                timer.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    RectangleDoc = (RectangleDoc) formatter.Deserialize(stream);
                    Color = Color.Green;
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED! HERE ARE THE DETAILS:\n\n{exception}",
                    "Exception");
            }
            finally
            {
                timer.Start();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

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
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED! HERE ARE THE DETAILS:\n\n{exception}",
                    "Exception");
            }
            finally
            {
                timer.Start();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            var dialog = new SaveFileDialog();
            dialog.Filter = "Moving Rectangle Files (*.mrf) | *.mrf";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                timer.Start();
                return;
            }

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
                MessageBox.Show($"EXCEPTION HAPPENED! HERE ARE THE DETAILS:\n\n{exception}",
                    "Exception");
            }
            finally
            {
                timer.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

            timer.Start();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                Color = dialog.Color;

            timer.Start();
        }
    }
}