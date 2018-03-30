using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshLines();
        }

        private void btnDodadiAvtobus_Click(object sender, EventArgs e)
        {
            DodadiAvtobus form = new DodadiAvtobus();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                lstAvtobusi.Items.Add(form.Avtobus);
                lstAvtobusi.SelectedIndex = -1;
                RefreshLines();
            }
        }

        private void btnIzbrisiAvtobus_Click(object sender, EventArgs e)
        {
            if (lstAvtobusi.SelectedIndex != -1)
            {
                string message = "Дали сте сигурни дека сакате да го избришете автобусот?";
                string caption = "Бришење на автобус";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lstAvtobusi.Items.Remove(lstAvtobusi.SelectedItem);
                    RefreshLines();
                }
            }
            else
            {
                string message = "Немате изберено автобус!";
                string caption = "Неуспешно бришење";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstAvtobusi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDodadiLinija.Focus();
            RefreshLines();
        }

        private void btnDodadiLinija_Click(object sender, EventArgs e)
        {
            if (lstAvtobusi.SelectedIndex != -1)
            {
                DodadiLinija form = new DodadiLinija();
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ((Avtobus) lstAvtobusi.SelectedItem).Lines.Add(form.Line);
                    RefreshLines();
                }
            }
            else
            {
                string message = "Немате изберено автобус!";
                string caption = "Неуспешно додавање дестинација";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshLines()
        {
            if (lstAvtobusi.SelectedIndex != -1)
            {
                lstLinii.Items.Clear();
                foreach (var line in ((Avtobus) lstAvtobusi.SelectedItem).Lines)
                    lstLinii.Items.Add(line);
                ComputeMaxAndAverage();
            }
            else
            {
                Clear();
            }
        }

        private void ComputeMaxAndAverage()
        {
            decimal maxPrice = Decimal.MinValue;
            decimal averagePrice = 0M;
            Line maxLine = null;

            foreach (Line line in lstLinii.Items)
            {
                if (line.Price > maxPrice)
                {
                    maxPrice = line.Price;
                    maxLine = line;
                }

                averagePrice += line.Price;
            }

            if (maxLine != null || averagePrice != 0M)
            {
                txtNajskapa.Text = maxLine.ToString();
                txtProsecnaCena.Text = (averagePrice / lstLinii.Items.Count).ToString("0.0");
            }
            else
            {
                Clear();
            }
        }

        private void Clear()
        {
            lstLinii.Items.Clear();
            txtNajskapa.Text = "";
            txtProsecnaCena.Text = "";
        }
    }
}