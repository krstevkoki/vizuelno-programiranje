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

namespace FlyingBall
{
    public partial class Form1 : Form
    {
        public BallDoc BallDoc { get; set; }
        public string FileName { get; set; }
        private int _counter;

        public Form1()
        {
            InitializeComponent();
            BallDoc = new BallDoc(this.Width);
            FileName = string.Empty;
            if (pauseToolStripMenuItem.Text != "Resume")
                timer1.Start();
            this.DoubleBuffered = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var res = MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                BallDoc = new BallDoc(this.Width);
                pauseToolStripMenuItem.Text = "Pause";
                timer1.Start();
                Invalidate(true);
                return;
            }

            if (pauseToolStripMenuItem.Text != "Resume")
                timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            var dialog = new OpenFileDialog();
            dialog.Filter = "Flying ball document (*.fbd)|*.fbd";
            dialog.Title = "Open your game";
            if (FileName != string.Empty)
                dialog.FileName = FileName.Substring(FileName.LastIndexOf('\\') + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                FileName = dialog.FileName;
            else
            {
                if (pauseToolStripMenuItem.Text != "Resume")
                    timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    BallDoc = (BallDoc) formatter.Deserialize(stream);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXEPTION HAS HAPPENED! HERE ARE DETAILS:\n\n{exception}");
            }
            finally
            {
                Invalidate(true);
                if (pauseToolStripMenuItem.Text != "Resume")
                    timer1.Start();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            var dialog = new SaveFileDialog();
            dialog.Filter = "Flying ball document (*.fbd)|*.fbd";
            dialog.Title = "Save your game";
            if (FileName != string.Empty)
                dialog.FileName = FileName.Substring(FileName.LastIndexOf('\\') + 1);


            if (dialog.ShowDialog() == DialogResult.OK)
                FileName = dialog.FileName;
            else
            {
                if (pauseToolStripMenuItem.Text != "Resume")
                    timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, BallDoc);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXEPTION HAS HAPPENED! HERE ARE DETAILS:\n\n{exception}");
            }
            finally
            {
                if (pauseToolStripMenuItem.Text != "Resume")
                    timer1.Start();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (FileName == string.Empty)
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }

            try
            {
                using (var stream = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, BallDoc);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXEPTION HAS HAPPENED! HERE ARE DETAILS:\n\n{exception}");
            }
            finally
            {
                if (pauseToolStripMenuItem.Text != "Resume")
                    timer1.Start();
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pauseToolStripMenuItem.Text == "Pause")
            {
                timer1.Stop();
                pauseToolStripMenuItem.Text = "Resume";
            }
            else
            {
                timer1.Start();
                pauseToolStripMenuItem.Text = "Pause";
            }

            Invalidate(true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var res = MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                this.Close();
            if (pauseToolStripMenuItem.Text != "Resume")
                timer1.Start();
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblHits.Text = $"Hits: {BallDoc.Hits}";
            lblMisses.Text = $"Misses: {BallDoc.Misses}";
            if (pauseToolStripMenuItem.Text == "Resume")
                lblPause.Text = "PAUSED";
            else
                lblPause.Text = string.Empty;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            BallDoc.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_counter % 8 == 0) // add a ball
            {
                var rand = new Random();
                BallDoc.AddBall(new Point(-Ball.Radius * 2,
                    rand.Next(Ball.Radius * 2, (this.Height - statusStrip1.Height - Ball.Radius * 2))));
            }

            ++_counter;
            BallDoc.Move();
            Invalidate(true);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pauseToolStripMenuItem.Text != "Resume")
            {
                BallDoc.IsHit(e.X, e.Y);
                Invalidate(true);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            BallDoc.Width = this.Width;
        }
    }
}