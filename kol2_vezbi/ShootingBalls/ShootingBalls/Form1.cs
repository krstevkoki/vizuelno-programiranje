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

namespace ShootingBalls
{
    public partial class Form1 : Form
    {
        public BallDoc BallDoc { get; set; }
        public string Filename { get; set; }
        private int _counter;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            BallDoc = new BallDoc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filename = string.Empty;
            _counter = 0;
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BallDoc.Click(e.Location);
            }
            else if (e.Button == MouseButtons.Right) { 
                BallDoc.AddBomb(e.Location);
            }

            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            BallDoc.Draw(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Погоди ги топчињата | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Погоди ги топчињата";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblPoints.Text = $"Points: {BallDoc.Points}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _counter++;
            if (_counter % 2 == 0)
                BallDoc.AddBall(this.Width, this.Height);
            BallDoc.Tick();
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
            dialog.Filter = "Shooting Balls file (*.sbf) | *.sbf";
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
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}", "EXCEPTION");
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
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}", "EXCEPTION");
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
            dialog.Filter = "Shooting Balls file (*.sbf) | *.sbf";
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
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}", "EXCEPTION");
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