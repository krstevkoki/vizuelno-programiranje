using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nudPayment.Maximum = Int32.MaxValue;
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            AddTeam form = new AddTeam();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                lstTeams.Items.Add(form.team);
            }
        }

        private void btnAddToGames_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedItems.Count != 2)
                MessageBox.Show("Селектирајте точно 2 тима");
            else if (msbCode.Text.Length == 0)
                MessageBox.Show("Морате да внесете шифра за натпреварот");
            else if (ContainsCode(msbCode.Text.Trim()))
                MessageBox.Show(string.Format("Натпревар со шифра '{0}' постои", msbCode.Text.Trim()));
            else
            {
                Game game = new Game();
                game.Home = (Team) lstTeams.SelectedItems[0];
                game.Away = (Team) lstTeams.SelectedItems[1];
                game.Code = msbCode.Text.Trim();
                game.Coefficients[0] = nup1.Value;
                game.Coefficients[1] = nupX.Value;
                game.Coefficients[2] = nup2.Value;
                lstGames.Items.Add(game);
                ClearValues();
            }
        }

        private void ClearValues()
        {
            nup1.Value = nup1.Minimum;
            nupX.Value = nupX.Minimum;
            nup2.Value = nup2.Minimum;
            msbCode.Text = "";
            lstTeams.SelectedItems.Clear();
            lstGames.SelectedItems.Clear();
            mtbCode1.Text = "";
            cbTip.SelectedIndex = -1;
        }

        private bool ContainsCode(string code)
        {
            foreach (var item in lstGames.Items)
                if (code == ((Game) item).Code)
                    return true;
            return false;
        }

        private void btnAddToTicket_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            if (mtbCode1.Text.Trim().Length == 0)
            {
                if (lstGames.SelectedIndex == -1)
                {
                    MessageBox.Show("Изберете натпревар");
                    return;
                }

                if (ContainsGame((Game) lstGames.SelectedItem))
                {
                    MessageBox.Show("Натпреварот веќе е додаден во тикетот");
                    return;
                }

                t.Game = (Game) lstGames.SelectedItem;

                if (cbTip.SelectedIndex == -1)
                {
                    MessageBox.Show("Морате да изберете тип");
                    return;
                }

                t.Tip = cbTip.SelectedIndex;
            }
            else // prebaruvanje po sifra
            {
                Game g = FindGameByCode(mtbCode1.Text.Trim());

                if (g == null)
                {
                    MessageBox.Show(string.Format("Натпревар со шифра '{0}' не постои", mtbCode1.Text.Trim()));
                    return;
                }

                if (ContainsGame(g))
                {
                    MessageBox.Show("Натпреварот веќе е додаден во тикетот");
                    return;
                }

                t.Game = g;
                if (cbTip.SelectedIndex == -1)
                {
                    MessageBox.Show("Морате да изберете тип");
                    return;
                }

                t.Tip = cbTip.SelectedIndex;
            }

            lstTicket.Items.Add(t);
            ClearValues();
            RefreshValues();
        }

        private void RefreshValues()
        {
            if (lstTicket.Items.Count != 0)
            {
                decimal totalCoefficient = 1m;
                foreach (var item in lstTicket.Items)
                    totalCoefficient *= ((Ticket) item).Game.Coefficients[((Ticket) item).Tip];
                txtCoefficient.Text = totalCoefficient.ToString(".00");
                txtProfit.Text = (nudPayment.Value * totalCoefficient).ToString(".00");
            }
        }

        private Game FindGameByCode(string code)
        {
            foreach (var item in lstGames.Items)
                if (code == ((Game) item).Code)
                    return (Game) item;
            return null;
        }

        private bool ContainsGame(Game g)
        {
            foreach (var item in lstTicket.Items)
                if (g.Code == ((Ticket) item).Game.Code)
                    return true;
            return false;
        }

        private void nudPayment_ValueChanged(object sender, EventArgs e)
        {
            RefreshValues();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintTicket form = new PrintTicket();
            if (lstTicket.Items.Count != 0)
            {
                form.Coefficient = txtCoefficient.Text;
                form.Payment = nudPayment.Value.ToString();
                form.Profit = txtProfit.Text;
                form.Danok = (decimal.Parse(form.Profit) * 0.10m).ToString(".00");
                form.Isplata = (decimal.Parse(form.Profit) - decimal.Parse(form.Danok)).ToString(".00");
                foreach (var ticket in lstTicket.Items)
                    form.Tickets.Add((Ticket) ticket);
                form.init();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Нема натпревари во тикетот");
            }
        }
    }
}