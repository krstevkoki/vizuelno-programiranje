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

namespace PulsingCircles
{
    public partial class Form1 : Form
    {
        public CircleDoc CircleDoc { get; set; }
        public string Filename { get; set; }
        public Color Color { get; set; }

        public Form1()
        {
            InitializeComponent();
            CircleDoc = new CircleDoc();
            Filename = string.Empty;
            Color = Color.DarkBlue;
            this.DoubleBuffered = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CircleDoc = new CircleDoc();
                toolStripButton1.Text = "Ста&рт";
                Filename = string.Empty;
                Invalidate(true);
            }
            if (toolStripButton1.Text != "Ста&рт")
                timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new OpenFileDialog();
            dialog.Filter = "Pulsing circle files (*.psf)|*.psf";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                if (toolStripButton1.Text != "Ста&рт")
                    timer1.Start();
                return;
            }

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
            }
            finally
            {
                if (toolStripButton1.Text != "Ста&рт")
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
                    formatter.Serialize(stream, CircleDoc);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
            finally
            {
                if (toolStripButton1.Text != "Ста&рт")
                    timer1.Start();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new SaveFileDialog();
            dialog.Filter = "Pulsing circle files (*.psf)|*.psf";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                if (toolStripButton1.Text != "Ста&рт")
                    timer1.Start();
                return;
            }

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
            }
            finally
            {
                if (toolStripButton1.Text != "Ста&рт")
                    timer1.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            if (toolStripButton1.Text != "Ста&рт")
                timer1.Start();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
                Color = dialog.Color;
            if (toolStripButton1.Text != "Ста&рт")
                timer1.Start();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CircleDoc.AddCircle(e.Location, Color);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            CircleDoc.Draw(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Pulsing circles | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Pulsing circles";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            toolStripStatusLabel1.Text = $"Total: {CircleDoc.CirclesCount()}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CircleDoc.IncrementCirclesRadius();
            Invalidate();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripButton1.Text == "Ста&рт")
            {
                timer1.Start();
                toolStripButton1.Text = "Сто&п";
            }
            else
            {
                timer1.Stop();
                toolStripButton1.Text = "Ста&рт";
            }
        }
    }
}