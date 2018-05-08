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

namespace NumbersMaster
{
    public partial class Form1 : Form
    {
        public NumberDoc NumberDoc { get; set; }
        public string Filename { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            NumberDoc = new NumberDoc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filename = string.Empty;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode.ToString();
            var lastChar = key[key.Length - 1];
            if (!key.StartsWith("F") && !key.StartsWith("O") && char.IsDigit(lastChar))
            {
                NumberDoc.KeyPressed(lastChar - '0');
                Invalidate(true);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            NumberDoc.DrawNumbers(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Numbers Master | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Numbers Master";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lblStatistics.Text = $"Hits: {NumberDoc.Hits} Misses: {NumberDoc.Misses}";
            if (btnPause.Text == "Resume")
                lblPaused.Text = "PAUSED";
            else lblPaused.Text = string.Empty;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NumberDoc.Tick();
            Invalidate(true);
        }

        private void timerAdd_Tick(object sender, EventArgs e)
        {
            NumberDoc.AddNumber(this.Width, this.Height);
            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerAdd.Stop();
            if (MessageBox.Show("Are you sure you want to start a new game", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NumberDoc = new NumberDoc();
                Filename = string.Empty;
                Invalidate(true);
            }

            timerAdd.Start();
            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerAdd.Stop();

            var dialog = new OpenFileDialog();
            dialog.Filter = "Numbers Master files (*.nmf)|*.nmf";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                timerAdd.Start();
                timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    NumberDoc = (NumberDoc) formatter.Deserialize(stream);
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}", "EXCEPTION");
            }
            finally
            {
                timerAdd.Start();
                timer1.Start();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerAdd.Stop();

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
                    formatter.Serialize(stream, NumberDoc);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}", "EXCEPTION");
            }
            finally
            {
                timerAdd.Start();
                timer1.Start();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerAdd.Stop();

            var dialog = new SaveFileDialog();
            dialog.Filter = "Numbers Master files (*.nmf)|*.nmf";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                timerAdd.Start();
                timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, NumberDoc);
                    Invalidate(true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED. HERE ARE THE DETAILS:\n\n{exception}", "EXCEPTION");
            }
            finally
            {
                timerAdd.Start();
                timer1.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerAdd.Stop();
            if (MessageBox.Show("Are you sure you want to quit the game", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            timerAdd.Start();
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pause")
            {
                timer1.Stop();
                timerAdd.Stop();
                btnPause.Text = "Resume";
            }
            else
            {
                timer1.Start();
                timerAdd.Start();
                btnPause.Text = "Pause";
            }
            Invalidate(true);
        }
    }
}