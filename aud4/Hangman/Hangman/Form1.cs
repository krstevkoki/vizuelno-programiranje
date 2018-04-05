using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private int _timeElapsed;
        private int _numWrongGuesses;
        private bool _isSurrendered;
        public HangmanWorld Game { get; private set; }

        public Form1()
        {
            InitializeComponent();
            BeginGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBukva.Focus();
        }

        public void BeginGame()
        {
            Game = new HangmanWorld();
            _numWrongGuesses = 0;
            _timeElapsed = HangmanWorld.MAX_TIME;
            _isSurrendered = false;
            lblTimer.ForeColor = _timeElapsed < 10 ? Color.Red : Color.Black;

            pbVreme.Minimum = 0;
            pbVreme.Maximum = HangmanWorld.MAX_TIME;

            pbObidi.Minimum = 0;
            pbObidi.Maximum = HangmanWorld.MAX_WRONG;

            SetValues();
            btnPogodi.Enabled = true;
            сеПредавамToolStripMenuItem.Enabled = true;
            timerVreme.Start();
        }

        public void EndGame()
        {
            timerVreme.Stop();
            string message;
            string caption;

            if (_timeElapsed == 0) // time's up
            {
                message = "Вашето време истече";
                caption = "Крај на играта";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_numWrongGuesses == HangmanWorld.MAX_WRONG) // no turns left
            {
                message = "Ги потрошивте преостанатите обиди за погодување на зборот";
                caption = "Крај на играта";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // we have a winner
            {
                message = "Браво, го погодивте зборот";
                caption = "Крај на играта";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            message = "Дали сакате нова игра?";
            caption = "Нова игра";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                BeginGame();
            else
                this.Close();
        }

        private void timerVreme_Tick(object sender, EventArgs e)
        {
            _timeElapsed--;
            lblTimer.ForeColor = _timeElapsed < 10 ? Color.Red : Color.Black;
            SetValues();

            if (_timeElapsed == 0 || _numWrongGuesses == HangmanWorld.MAX_WRONG)
                EndGame();
        }

        private void btnPogodi_Click(object sender, EventArgs e)
        {
            string message;
            string caption;
            if (txtBukva.Text.Length > 0)
            {
                char guess = txtBukva.Text.ToLower()[0];
                if (!char.IsLetter(guess))
                {
                    message = "Не внесовте буква";
                    caption = "Грешка при погодување";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Game.ValidateGuessedChar(guess))
                    {
                        if (Game.RemovingOccurencesNumber == 0)
                            _numWrongGuesses++;
                    }
                    else
                    {
                        timerVreme.Stop();
                        message = $"Буквата [{guess}] веќе ја имате пробано!";
                        caption = "Дупликат буква";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        timerVreme.Start();
                    }

                    SetValues();
                    if (Game.DidWin())
                        EndGame();
                }
            }
            else
            {
                timerVreme.Stop();
                message = "Морате да имате внесено една буква";
                caption = "Грешка при погодување";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                timerVreme.Start();
            }

            txtBukva.Clear();
            txtBukva.Focus();
        }

        private void започниНоваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeginGame();
        }

        private void сеПредавамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isSurrendered = true;
            timerVreme.Stop();
            string message = "Дали сте сигурни дека сакате да се предадете?";
            string caption = "Откажување на игра";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                char firstLetter = char.ToUpper(Game.Word[0]);
                lblZbor.Text = "";
                lblZbor.Text += firstLetter + " ";
                foreach (char c in Game.Word.Substring(1))
                    lblZbor.Text += (c + " ");
                btnPogodi.Enabled = false;
                сеПредавамToolStripMenuItem.Enabled = false;
            }
            else
                timerVreme.Start();
        }

        private void исклучиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerVreme.Stop();
            string message = "Дали сакате да ја исклучете играта?";
            string caption = "Исклучување на игра";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
            else
            {
                if (!_isSurrendered)
                    timerVreme.Start();
            }
        }

        private void SetValues()
        {
            lblTimer.Text = $"{_timeElapsed / 60:00}:{_timeElapsed % 60:00}";
            pbVreme.Value = _timeElapsed;
            pbObidi.Value = _numWrongGuesses;
            lblZbor.Text = Game.GetMaskedWord();
            txtProbaniBukvi.Text = Game.GetAllLetters();
            lblObidi.Text =
                $"Неуспешни обиди: {_numWrongGuesses}            Максимално дозволени: {HangmanWorld.MAX_WRONG}";
        }
    }
}