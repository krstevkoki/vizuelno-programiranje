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

namespace HalfCircles
{
    public partial class Form1 : Form
    {
        public CircleDoc CircleDoc { get; set; }
        public Color Color { get; set; }
        public string Filename { get; set; }

        public Form1()
        {
            InitializeComponent();
            CircleDoc = new CircleDoc();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color = Color.Red;
            Filename = string.Empty;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CircleDoc.AddCircle(e.Location, Color);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            CircleDoc.DrawCircles(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Half Circles | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Half Circles";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblCircles.Text = $"Total: {CircleDoc.Count}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CircleDoc.SwapCirclesColors();
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CircleDoc = new CircleDoc();
                Filename = string.Empty;
                if (btnStart.Text != "Старт")
                    btnStart_Click(sender, e);
                Invalidate(true);
            }

            if (btnStart.Text != "Старт")
                timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new OpenFileDialog();
            dialog.Filter = "Half Circles files (*.hcf)|*.hcf";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                if (btnStart.Text != "Старт")
                    timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    CircleDoc = (CircleDoc) formatter.Deserialize(stream);
                    if (btnStart.Text != "Старт")
                        btnStart_Click(sender, e);
                    Invalidate(true);
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}");
            }
            finally
            {
                if (btnStart.Text != "Старт")
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
                if (btnStart.Text != "Старт")
                    timer1.Start();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new SaveFileDialog();
            dialog.Filter = "Half Circles files (*.hcf)|*.hcf";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                if (btnStart.Text != "Старт")
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
                if (btnStart.Text != "Старт")
                    timer1.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

            if (btnStart.Text != "Старт")
                timer1.Start();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                Color = dialog.Color;

            if (btnStart.Text != "Старт")
                timer1.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Старт")
            {
                timer1.Start();
                btnStart.Text = "Пауза";
            }
            else
            {
                timer1.Stop();
                btnStart.Text = "Старт";
            }
        }
    }
}