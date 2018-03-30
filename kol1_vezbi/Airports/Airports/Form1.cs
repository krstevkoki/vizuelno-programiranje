using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshDestinations();
        }

        private void btnDodadiAerodrom_Click(object sender, EventArgs e)
        {
            DodadiAerodrom form = new DodadiAerodrom();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
                lstAerodromi.Items.Add(form.Airport);

            lstAerodromi.SelectedIndex = -1;
            RefreshDestinations();
        }

        private void btnIzbrisiAerodrom_Click(object sender, EventArgs e)
        {
            if (lstAerodromi.SelectedIndex != -1)
            {
                var result = MessageBox.Show("Дали сакате да го избришете аеродромот?", "Бришење на аеродром",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lstAerodromi.Items.Remove(lstAerodromi.SelectedItem);
                    RefreshDestinations();
                }
            }
            else
            {
                MessageBox.Show("Немате селектирано аеродром!", "Неуспешно бришење",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstAerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDestinations();
        }

        private void btnDodadiDest_Click(object sender, EventArgs e)
        {
            if (lstAerodromi.SelectedIndex != -1)
            {
                DodadiDestinacija form = new DodadiDestinacija();
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ((Airport) lstAerodromi.SelectedItem).Destinations.Add(form.Destination);
                    RefreshDestinations();
                }
            }
            else
            {
                MessageBox.Show("Немате селектирано аеродром!", "Неуспешно додавање дестинација",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDestinations()
        {
            if (lstAerodromi.SelectedIndex != -1)
            {
                lstDestinacii.Items.Clear();
                foreach (var item in ((Airport) lstAerodromi.SelectedItem).Destinations)
                {
                    lstDestinacii.Items.Add(item);
                }

                ComputeMaxAndAverage();
            }
            else
            {
                Clear();
            }
        }

        private void ComputeMaxAndAverage()
        {
            decimal maxDistance = Decimal.MinValue;
            decimal averageDistance = 0M;
            Destination maxDest = null;

            foreach (var item in ((Airport) lstAerodromi.SelectedItem).Destinations)
            {
                if (item.Distance > maxDistance)
                {
                    maxDistance = item.Distance;
                    maxDest = item;
                }

                averageDistance += item.Distance;
            }

            if (maxDest != null || averageDistance != 0)
            {
                txtNajskapaDest.Text = maxDest.ToString();
                txtProsecnaDolzina.Text =
                    (averageDistance / ((Airport) lstAerodromi.SelectedItem).Destinations.Count).ToString(".0");
            }
            else
            {
                Clear();
            }
        }

        private void Clear()
        {
            lstDestinacii.Items.Clear();
            txtNajskapaDest.Text = "";
            txtProsecnaDolzina.Text = "";
        }
    }
}