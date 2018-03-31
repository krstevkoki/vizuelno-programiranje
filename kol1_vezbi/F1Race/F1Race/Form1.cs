using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nudSekundi_ValueChanged(object sender, EventArgs e)
        {
            if (nudSekundi.Value > 59)
            {
                nudMinuti.Value++;
                nudSekundi.Value = 0;
            }

            if (nudSekundi.Value < 0)
            {
                if (nudMinuti.Value != 0)
                {
                    nudMinuti.Value--;
                    nudSekundi.Value = 59;
                }
                else
                {
                    nudSekundi.Value = 0;
                }
            }
        }

        private void btnDodadiVozac_Click(object sender, EventArgs e)
        {
            DodadiVozac form = new DodadiVozac();
            var res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                lstVozaci.Items.Add(form.Driver);
                lstVozaci.SelectedIndex = -1;
                RefreshValues();
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (lstVozaci.SelectedIndex != -1)
            {
                string message = "Дали сте сигурни дека сакате да го избришите возачот?";
                string caption = "Бришење на возач";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lstVozaci.Items.Remove(lstVozaci.SelectedItem);
                    RefreshValues();
                }
            }
            else
            {
                string message = "Немате изберено возач!";
                string caption = "Неуспешно бришење возач";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodadiKrug_Click(object sender, EventArgs e)
        {
            if (lstVozaci.SelectedIndex != -1)
            {
                var vozac = lstVozaci.SelectedItem as Driver;
                Lap lap = new Lap();
                lap.Minutes = Convert.ToInt32(nudMinuti.Value);
                lap.Seconds = Convert.ToInt32(nudSekundi.Value);
                vozac.Laps.Add(lap);
                RefreshValues();
                ClearValues();
            }
            else
            {
                string message = "Немате изберено возач!";
                string caption = "Неуспешно додавање круг";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstVozaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValues();
        }

        private void RefreshValues()
        {
            if (lstVozaci.SelectedIndex != -1)
            {
                lstKrugovi.Items.Clear();
                var vozac = lstVozaci.SelectedItem as Driver;
                foreach (var lap in vozac.Laps)
                {
                    lstKrugovi.Items.Add(lap);
                }

                ComputeBestLap(Convert.ToInt32(nudVreme.Value));
            }
            else
            {
                lstKrugovi.Items.Clear();
                txtNajdobar.Text = "";
            }
        }

        private void ComputeBestLap(int secondsTreshold)
        {
            int minSeconds = Int32.MaxValue;
            Lap minLap = null;
            foreach (Lap item in lstKrugovi.Items)
            {
                int lapSeconds = item.ToSeconds();
                if (lapSeconds > secondsTreshold && lapSeconds < minSeconds)
                {
                    minSeconds = lapSeconds;
                    minLap = item;
                }
            }

            if (minLap != null)
            {
                txtNajdobar.Text = minLap.ToString();
            }
            else
            {
                txtNajdobar.Text = "";
            }
        }

        private void ClearValues()
        {
            nudMinuti.Value = 0M;
            nudSekundi.Value = 0M;
        }

        private void nudVreme_ValueChanged(object sender, EventArgs e)
        {
            RefreshValues();
        }
    }
}