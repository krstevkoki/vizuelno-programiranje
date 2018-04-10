using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTimer
{
    public partial class Form1 : Form
    {
        private string message = ""; // used for MessageBox
        private string caption = ""; // used for MessageBox
        private int _timeElapsed;

        private static readonly int MINUTES = 1;
        private static readonly int MAX_TIME = MINUTES * 60;
        private static readonly int MAX_POINTS = 100;

        public Equation Equation { get; set; }
        public Player Player { get; set; }
        public List<Player> Players { get; set; }

        public Form1()
        {
            InitializeComponent();
            timerVreme.Interval = 1000;
            timerVreme.Enabled = true;

            pbVreme.Maximum = MAX_TIME;
            pbPoeni.Maximum = MAX_POINTS;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BeginGame();
        }

        private void BeginGame()
        {
            Player = new Player();
            Players = new List<Player>();

            txtIgrac.Focus();
            _timeElapsed = MAX_TIME;

            UpdateValues();
            GenerateNewExpression();
            txtIgrac.Clear();
            txtResult.Clear();

            timerVreme.Start();
        }

        private void EndGame()
        {
            timerVreme.Stop();

            if (_timeElapsed == 0) // time's up
            {
                message = "Вашето време истече";
                caption = "Крај на игра";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else // you're a winner
            {
                message = "Освоивте максимум поени, Вие сте победник на играта";
                caption = "Крај на игра";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void UpdateValues()
        {
            if (_timeElapsed < 10)
                lblVreme.ForeColor = Color.Red;
            else
                lblVreme.ForeColor = Color.Black;

            pbVreme.Value = _timeElapsed;
            lblVreme.Text = $"{_timeElapsed / 60:00}:{_timeElapsed % 60:00}";

            pbPoeni.Value = Player.Score;
            lblPoeni.Text = Player.Score.ToString();
        }

        private void GenerateNewExpression()
        {
            Equation = new Equation();
            txtOperand1.Text = Equation.Operand1.ToString();
            txtOperand2.Text = Equation.Operand2.ToString();
            txtOperator.Text = Equation.Operator.ToString();
        }

        private Player GetPlayerByName(string playerName)
        {
            foreach (var player in Players)
                if (player.Name == playerName)
                    return player;
            return null;
        }

        private bool ContainsPlayerByName(string playerName)
        {
            foreach (var player in Players)
                if (player.Name == playerName)
                    return true;
            return false;
        }

        private void timerVreme_Tick(object sender, EventArgs e)
        {
            _timeElapsed--;
            UpdateValues();
            if (_timeElapsed == 0)
                EndGame();
        }

        private void btnIskluci_Click(object sender, EventArgs e)
        {
            timerVreme.Stop();
            message = "Дали сакате да ја исклучете апликацијата?";
            caption = "Исклучување на апликација";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
            else
                timerVreme.Start();
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            BeginGame();
        }

        private void btnNajdobri_Click(object sender, EventArgs e)
        {
            timerVreme.Stop();
            var form = new DisplayBestPlayers(Players.OrderByDescending(player => player.Score));
            form.ShowDialog();
            timerVreme.Start();
        }

        private void btnPogodi_Click(object sender, EventArgs e)
        {
            if (txtIgrac.Text.Length == 0)
            {
                timerVreme.Stop();
                message = "Немате внесено играч";
                caption = "Грешка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Clear();
                timerVreme.Start();
                return;
            }
            else if (txtResult.Text.Length == 0)
            {
                timerVreme.Stop();
                message = "Немате внесено резултат";
                caption = "Грешка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Clear();
                timerVreme.Start();
                return;
            }

            if (!int.TryParse(txtResult.Text, out int result))
            {
                timerVreme.Stop();
                message = "Невалиден формат на резултатот";
                caption = "Грешка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Clear();
                timerVreme.Start();
                return;
            }

            if (Equation.EvaluateExpression() != result)
            {
                timerVreme.Stop();
                message = "Грешен резултат";
                caption = "Грешка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResult.Clear();
                timerVreme.Start();
                return;
            }

            timerVreme.Stop();
            message = "Точен резултат";
            caption = "Браво";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Player.Score++;
            if (Player.Score % 10 == 0)
            {
                if (_timeElapsed + 10 >= MAX_TIME)
                    _timeElapsed = MAX_TIME;
                else
                    _timeElapsed += 10;
            }

            UpdateValues();

            if (Player.Score == MAX_POINTS)
            {
                EndGame();
                return;
            }
            GenerateNewExpression();
            txtResult.Clear();
            timerVreme.Start();
        }

        private void txtIgrac_Leave(object sender, EventArgs e)
        {
            if (txtIgrac.Text.Length != 0)
            {
                if (ContainsPlayerByName(txtIgrac.Text))
                {
                    Player = GetPlayerByName(txtIgrac.Text);
                    if (Player == null)
                    {
                        timerVreme.Stop();
                        message = "Настана грешка!";
                        caption = "Грешка";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        timerVreme.Start();
                        return;
                    }
                }
                else
                {
                    Player = new Player {Name = txtIgrac.Text};
                    Players.Add(Player);
                }

                UpdateValues();
                txtResult.Focus();
            }
        }
    }
}