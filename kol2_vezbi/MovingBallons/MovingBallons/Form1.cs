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

namespace MovingBallons
{
    public partial class Form1 : Form
    {
        public BaloonsDoc BaloonsDoc { get; set; }
        public Color Color { get; set; }
        public string Filename { get; set; }
        public Random Random { get; set; }

        public Form1()
        {
            InitializeComponent();
            BaloonsDoc = new BaloonsDoc();
            Color = Color.DarkRed;
            Filename = string.Empty;
            Random = new Random();
            this.DoubleBuffered = true;
            timer1.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure you want to quit the game", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            timer1.Start();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure you want to start a new game", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BaloonsDoc = new BaloonsDoc();
                Filename = string.Empty;
                Invalidate(true);
            }

            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new OpenFileDialog();
            dialog.Filter = "Moving baloons files (*.mbf)|*.mbf";
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
                    BaloonsDoc = (BaloonsDoc) formatter.Deserialize(stream);
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
                    formatter.Serialize(stream, BaloonsDoc);
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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new SaveFileDialog();
            dialog.Filter = "Moving baloons files (*.mbf)|*.mbf";
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
                    formatter.Serialize(stream, BaloonsDoc);
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

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                Color = dialog.Color;
            timer1.Start();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int x = Random.Next(Baloon.Radius * 2, this.Width - Baloon.Radius * 2);
            int y = Random.Next(Baloon.Radius * 2 + toolStrip1.Height + menuStrip1.Height,
                this.Height - Baloon.Radius * 2 - statusStrip1.Height - 25);
            Point center = new Point(x, y);
            BaloonsDoc.AddBaloon(center, Color);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            BaloonsDoc.DrawBaloons(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Moving baloons | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Moving baloons";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblBaloni.Text = $"Baloons: {BaloonsDoc.BallonsCount()}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int top = menuStrip1.Height + toolStrip1.Height;
            int heigth = this.Height - statusStrip1.Height - 25;
            BaloonsDoc.MoveBaloons(top, heigth);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            BaloonsDoc.SelectBaloon(e.X, e.Y);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectAllToolStripMenuItem.Text == "Select &All")
            {
                BaloonsDoc.SelectAllBaloons(true);
                selectAllToolStripMenuItem.Text = "Unselect &All";
            }
            else
            {
                BaloonsDoc.SelectAllBaloons(false);
                selectAllToolStripMenuItem.Text = "Select &All";
            }

            Invalidate();
        }
    }
}