using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarackaNaPica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void txtCenaMala_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void rbMala_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            int totalPrice = 0;

            /* Radio Buttons */
            if (rbMala.Checked && int.TryParse(txtCenaMala.Text, out int price))
                totalPrice += price;
            if (rbSredna.Checked && int.TryParse(txtCenaSredna.Text, out price))
                totalPrice += price;
            if (rbGolema.Checked && int.TryParse(txtCenaGolema.Text, out price))
                totalPrice += price;

            /* Check Buttons */
            if (chbFeferonki.Checked && int.TryParse(txtCenaFeferonki.Text, out price))
                totalPrice += price;
            if (chbSirenje.Checked && int.TryParse(txtCenaSirenje.Text, out price))
                totalPrice += price;
            if (chbKecap.Checked && int.TryParse(txtCenaKecap.Text, out price))
                totalPrice += price;

            /* Drinks */
            if (int.TryParse(txtKolicinaGaziran.Text, out int quantity) && int.TryParse(txtCenaGaziran.Text, out price))
            {
                totalPrice += (quantity * price);
                txtVkupnoGaziran.Text = (quantity * price).ToString();
            }
            else txtVkupnoGaziran.Text = "0";

            if (int.TryParse(txtKolicinaGusti.Text, out quantity) && int.TryParse(txtCenaGusti.Text, out price))
            {
                totalPrice += (quantity * price);
                txtVkupnoGusti.Text = (quantity * price).ToString();
            }
            else txtVkupnoGusti.Text = "0";

            if (int.TryParse(txtKolicinaPivo.Text, out quantity) && int.TryParse(txtCenaPivo.Text, out price))
            {
                totalPrice += (quantity * price);
                txtVkupnoPivo.Text = (quantity * price).ToString();
            }
            else txtVkupnoPivo.Text = "0";

            /* Dessert */
            if (lstDeserti.SelectedIndex != -1 && int.TryParse(txtCenaDesert.Text, out price))
                totalPrice += price;

            txtVkupno.Text = totalPrice.ToString();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            string message = "Дали сакате да ја откажете нарачката?";
            string caption = "Откажување на нарачка";
            DialogResult res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Application.Exit();
        }

        private void btnNaracaj_Click(object sender, EventArgs e)
        {
            int total = int.Parse(txtVkupno.Text);
            if (int.TryParse(txtNaplata.Text, out int money) && money >= total)
            {
                txtKusur.Text = (money - total).ToString();
                MessageBox.Show("Успешна нарачка, Ви благодариме", "Успешна нарачка",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Нарачката не е успешна", "Неуспешна нарачка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}