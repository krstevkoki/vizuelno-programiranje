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

namespace LettersMaster
{
    public partial class Form1 : Form
    {
        public LettersDoc LettersDoc { get; set; }
        public string Filename { get; set; }

        private Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            LettersDoc = new LettersDoc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filename = string.Empty;
            timerGenerate.Start();
            timerMove.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var letter = e.KeyCode.ToString()[0];
            if (e.KeyCode.ToString().Length > 1 || !char.IsLetter(letter))
                return;

            LettersDoc.Guess(letter);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            LettersDoc.DrawLetters(e.Graphics);

            if (Filename != string.Empty)
                this.Text = $"Letters Master | {Filename.Substring(Filename.LastIndexOf(@"\") + 1)}";
            else this.Text = "Letters Master";
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            lblTotal.Text = $"Points: {LettersDoc.Hits}, Misses: {LettersDoc.Misses}";
            lblDistribution.Text = $"{LettersDoc.GetDistribution()}";
        }

        private void timerGenerate_Tick(object sender, EventArgs e)
        {
            LettersDoc.AddLetter(this.Width, _random);
            Invalidate(true);
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            LettersDoc.Move(this.Height - statusStrip1.Height);
            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMove.Stop();
            timerGenerate.Stop();

            if (MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LettersDoc = new LettersDoc();
                Filename = string.Empty;
                _random = new Random();
                Invalidate(true);
            }

            timerMove.Start();
            timerGenerate.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMove.Stop();
            timerGenerate.Stop();

            var dialog = new OpenFileDialog();
            dialog.Filter = "Letters Master Files (*.lmf) | *.lmf";
            dialog.Title = "Open your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                timerMove.Start();
                timerGenerate.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    LettersDoc = (LettersDoc) formatter.Deserialize(stream);
                    _random = new Random();
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
                timerMove.Start();
                timerGenerate.Start();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMove.Stop();
            timerGenerate.Stop();

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
                    formatter.Serialize(stream, LettersDoc);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXCEPTION HAPPENED! HERE ARE THE DETAILS:\n\n{exception}",
                    "Exception");
            }
            finally
            {
                timerMove.Start();
                timerGenerate.Start();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMove.Stop();
            timerGenerate.Stop();

            var dialog = new SaveFileDialog();
            dialog.Filter = "Letters Master Files (*.lmf) | *.lmf";
            dialog.Title = "Save your game";
            if (Filename != string.Empty)
                dialog.FileName = Filename.Substring(Filename.LastIndexOf(@"\") + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                Filename = dialog.FileName;
            else
            {
                timerMove.Start();
                timerGenerate.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(Filename, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, LettersDoc);
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
                timerMove.Start();
                timerGenerate.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMove.Stop();
            timerGenerate.Stop();

            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

            timerMove.Start();
            timerGenerate.Start();
        }
    }
}