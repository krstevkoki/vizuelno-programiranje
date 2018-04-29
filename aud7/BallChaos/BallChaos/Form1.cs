using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallChaos
{
    public partial class Form1 : Form
    {
        public BallDoc BallDoc { get; set; }
        public Color CurrentColor { get; set; }
        public String FileName { get; set; }

        private readonly int _left;
        private readonly int _top;
        private int _width;
        private int _height;

        public Form1()
        {
            InitializeComponent();
            _left = 20;
            _top = 60;
            _width = this.Width - (3 * _left);
            _height = this.Height - (int) (2.5 * _top);
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentColor = Color.Blue;
            BallDoc = new BallDoc();
            FileName = String.Empty;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BallDoc.Move(_left, _top, _width, _height);
            BallDoc.CheckCollisions();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            var pen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pen, _left, _top, _width, _height);
            pen.Dispose();
            BallDoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Location.X > (_left + Ball.Radius) 
                && e.Location.Y > (_top + Ball.Radius) 
                && e.Location.X < ((_left + _width) - Ball.Radius)
                && e.Location.Y < ((_top + _height) - Ball.Radius))
            {
                var ball = new Ball(e.Location, CurrentColor);
                BallDoc.AddBall(ball);
                Invalidate();
                BallDoc.ClearRedoStack();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string message = "Do you want to save the game?";
            string caption = "Save before exiting";
            var res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
                this.Close();
            }
            else
                this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string message = "Do you want to save the game?";
            string caption = "Save before new game";
            var res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            }

            FileName = string.Empty;
            BallDoc = new BallDoc();
            Invalidate();
            timer1.Start();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new ColorDialog();
            var res = dialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                CurrentColor = dialog.Color;
            }
            timer1.Start();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (FileName == string.Empty)
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "Balls doc file|*.bll";
                dialog.Title = "Save game";

                var res = dialog.ShowDialog();

                if (res == DialogResult.OK)
                    FileName = dialog.FileName;
            }

            if (FileName != string.Empty)
            {
                using (var fileStream = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, BallDoc);
                }
            }

            timer1_Tick(sender, e);
            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Balls doc file|*.bll";
            dialog.Title = "Open balls doc file";

            timer1.Stop();
            var res = dialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                FileName = dialog.FileName;
                try
                {
                    using (var fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                    {
                        var formatter = new BinaryFormatter();
                        BallDoc = (BallDoc) formatter.Deserialize(fileStream);
                    }
                }
                catch (Exception)
                {
                    string message = $"Could not read file {FileName}";
                    var caption = "Error opening file";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FileName = null;
                }
            }

            timer1_Tick(sender, e);
            timer1.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            _width = this.Width - (3 * _left);
            _height = this.Height - (int)(2.5 * _top);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BallDoc.Undo();
            Invalidate();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BallDoc.Redo();
            Invalidate();
        }
    }
}