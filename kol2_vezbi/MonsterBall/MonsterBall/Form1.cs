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

namespace MonsterBall
{
    public partial class Form1 : Form
    {
        public BallDoc BallDoc { get; set; }
        public string Filename { get; set; }
        private int _left;
        private int _top;
        private int _width;
        private int _height;

        public Form1()
        {
            InitializeComponent();
            BallDoc = new BallDoc();
            this.DoubleBuffered = true;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filename = string.Empty;
            _left = 20;
            _top = 60;
            _width = this.Width - (int) (_left * 3);
            _height = this.Height - (int) (_top * 2.5);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var ball = new Ball(e.Location);

            if (ball.Center.X > _left + ball.Radius &&
                ball.Center.X < (_left + _width) - ball.Radius &&
                ball.Center.Y > _top + ball.Radius &&
                ball.Center.Y < (_top + _height) - ball.Radius)
            {
                BallDoc.AddBall(ball);
                Invalidate(true);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            _width = this.Width - (int) (_left * 2.8);
            _height = this.Height - (int) (_top * 2.2);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            BallDoc.DrawBalls(e.Graphics, new Font("Times New Roman", 20));

            var pen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pen, _left, _top, _width, _height);
            pen.Dispose();

            if (Filename != string.Empty)
                this.Text = $"Monster Ball | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Monster Ball";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblTotal.Text = $"# Balls: {BallDoc.Count}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BallDoc.MoveBalls(_left, _top, _width, _height);
            BallDoc.CanSwallow();
            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BallDoc = new BallDoc();
                Filename = string.Empty;
                Invalidate(true);
            }

            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new OpenFileDialog();
            dialog.Filter = "Monster Ball files (*.mbf)|*.mbf";
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
                    BallDoc = (BallDoc) formatter.Deserialize(stream);
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
                    formatter.Serialize(stream, BallDoc);
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
            dialog.Filter = "Monster Ball files (*.mbf)|*.mbf";
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
                    formatter.Serialize(stream, BallDoc);
                    Invalidate();
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
    }
}