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

namespace TickingPies
{
    public partial class Form1 : Form
    {
        public BallDoc BallDoc { get; set; }
        public Color Color { get; set; }
        public string Filename { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            BallDoc = new BallDoc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color = Color.CornflowerBlue;
            Filename = string.Empty;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            BallDoc.AddBall(e.Location, Color);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            BallDoc.Draw(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Ticking Pies | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Ticking Pies";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            lblTotal.Text = $"Total: {BallDoc.Count}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            BallDoc.Tick();
            Invalidate(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Старт")
            {
                btnStart.Text = "Стоп";
                timer.Start();
            }
            else
            {
                btnStart.Text = "Старт";
                timer.Stop();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BallDoc = new BallDoc();
                Color = Color.CornflowerBlue;
                Filename = string.Empty;
                btnStart.Text = "Старт";

                Invalidate(true);
            }
            else
            {
                if (btnStart.Text == "Стоп")
                    timer.Start();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            var dialog = new OpenFileDialog();
            dialog.Filter = "Ticking Pie Files (*.tpf) | *.tpf";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                if (btnStart.Text == "Стоп")
                    timer.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    BallDoc = (BallDoc) formatter.Deserialize(stream);
                    Color = Color.CornflowerBlue;
                    btnStart.Text = "Старт";
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED! HERE ARE THE DETAILS:\n\n{exception}",
                    "Exception");
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
                    formatter.Serialize(stream, BallDoc);
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
                if (btnStart.Text == "Стоп")
                    timer.Start();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            var dialog = new SaveFileDialog();
            dialog.Filter = "Ticking Pie Files (*.tpf) | *.tpf";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                if (btnStart.Text == "Стоп")
                    timer.Start();
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
                MessageBox.Show($"EXCEPTION HAPPENED! HERE ARE THE DETAILS:\n\n{exception}",
                    "Exception");
            }
            finally
            {
                if (btnStart.Text == "Стоп")
                    timer.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

            if (btnStart.Text == "Стоп")
                timer.Start();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                Color = dialog.Color;

            if (btnStart.Text == "Стоп")
                timer.Start();
        }
    }
}