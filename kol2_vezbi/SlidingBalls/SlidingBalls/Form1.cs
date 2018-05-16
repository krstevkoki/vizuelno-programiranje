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

namespace SlidingBalls
{
    public partial class Form1 : Form
    {
        public BallDoc BallDoc { get; set; }
        public Random Random { get; set; }
        public string Filename { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            BallDoc = new BallDoc();
            Random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filename = string.Empty;
            timer1.Stop();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // start moving a red ball, if clicked
            {
                if (BallDoc.SelectBall(e.Location))
                    timer1.Start();
            }
            else if (e.Button == MouseButtons.Right) // add a red ball
            {
                BallDoc.AddBall(e.Location, Color.Red);
                Invalidate(true);
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var choice = Random.Next(2);

            if (choice == 0) // add a blue ball
                BallDoc.AddBall(e.Location, Color.Blue);
            else if (choice == 1)
                BallDoc.AddBall(e.Location, Color.Green);

            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            BallDoc.DrawBalls(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Sliding Balls | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Sliding Balls";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblActive.Text = $"Active: {BallDoc.Count}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BallDoc.Move(this.Width, this.Height - statusStrip1.Height))
                timer1.Stop();
            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool stopped = false;
            if (timer1.Enabled)
            {
                timer1.Stop();
                stopped = true;
            }

            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BallDoc = new BallDoc();
                Filename = string.Empty;
                stopped = false;
                timer1.Stop();
                Invalidate(true);
            }

            if (stopped)
                timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool stopped = false;
            if (timer1.Enabled)
            {
                timer1.Stop();
                stopped = true;
            }

            var dialog = new OpenFileDialog();
            dialog.Filter = "Sliding Ball Files (*.sbf) | *.sbf";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                if (stopped)
                    timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    BallDoc = (BallDoc) formatter.Deserialize(stream);
                    if (BallDoc.IsMoving)
                        timer1.Start();
                    else
                        timer1.Stop();
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

            bool stopped = false;
            if (timer1.Enabled)
            {
                timer1.Stop();
                stopped = true;
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
                if (stopped)
                    timer1.Start();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool stopped = false;
            if (timer1.Enabled)
            {
                timer1.Stop();
                stopped = true;
            }

            var dialog = new SaveFileDialog();
            dialog.Filter = "Sliding Ball Files (*.sbf) | *.sbf";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                if (stopped)
                    timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, BallDoc);
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
            finally
            {
                if (stopped)
                    timer1.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool stopped = false;
            if (timer1.Enabled)
            {
                timer1.Stop();
                stopped = true;
            }

            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

            if (stopped)
                timer1.Start();
        }
    }
}