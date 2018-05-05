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

namespace BallsInHoles
{
    public partial class Form1 : Form
    {
        public BallsDoc BallsDoc { get; set; }
        public Color Color { get; set; }
        public string Filename { get; set; }
        public Random Random { get; set; }
        private readonly int _left;
        private readonly int _top;
        private int _height;
        private int _width;

        public Form1()
        {
            InitializeComponent();
            BallsDoc = new BallsDoc();
            Color = Color.Red;
            Filename = string.Empty;
            Random = new Random();
            _left = 10;
            _top = menuStrip1.Height + toolStrip1.Height + Ball.Radius;
            _height = this.Height - (int) (_top * 2);
            _width = this.Width - (int) (_left * 3.5);
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateHoles();
            timer1.Start();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BallsDoc = new BallsDoc();
                GenerateHoles();
                Filename = string.Empty;
                Invalidate(true);
            }

            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new OpenFileDialog();
            dialog.Filter = "Balls in Holes file (*.bhf)|*.bhf";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    BallsDoc = (BallsDoc) formatter.Deserialize(stream);
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
            finally
            {
                timer1.Start();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
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
                    formatter.Serialize(stream, BallsDoc);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
            finally
            {
                timer1.Start();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new SaveFileDialog();
            dialog.Filter = "Balls in Holes file (*.bhf)|*.bhf";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, BallsDoc);
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
            finally
            {
                timer1.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            timer1.Start();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GenerateHoles();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                Color = dialog.Color;
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            BallsDoc.AddBall(e.Location, Color);
            Invalidate(true);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            _height = this.Height - (int) (_top * 2);
            _width = this.Width - (int) (_left * 3.5);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            var pen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pen, _left, _top, _width, _height);
            pen.Dispose();

            BallsDoc.DrawHoles(e.Graphics, new Font("Arial", 20));
            BallsDoc.DrawBalls(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Balls in Holes | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Balls in Holes";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblBrTopcinja.Text = $"# Balls: {BallsDoc.BallsCount()}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BallsDoc.MoveBalls(_left, _top, _width, _height);
            BallsDoc.BallsSwallow();
            Invalidate(true);
        }

        private void GenerateHoles()
        {
            timer1.Stop();
            BallsDoc.ClearHoles();
            while (true)
            {
                if (BallsDoc.HolesCount() == 5)
                    break;
                int x = Random.Next(_left + Hole.Radius * 2, _width - Hole.Radius * 2);
                int y = Random.Next(_top + Hole.Radius * 2, _height - Hole.Radius * 2);
                var center = new Point(x, y);

                if (BallsDoc.HolesCount() == 0)
                    BallsDoc.AddHole(center);
                else
                {
                    var h = new Hole(center);
                    bool flag = true;
                    for (int i = 0; i < BallsDoc.HolesCount(); i++)
                    {
                        if (BallsDoc.Holes[i].TouchAnotherHole(h))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        BallsDoc.AddHole(center);
                }
            }

            Invalidate();
            timer1.Start();
        }
    }
}