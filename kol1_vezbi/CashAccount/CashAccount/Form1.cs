using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckAvailability();
        }

        private void btnDodadiNov_Click(object sender, EventArgs e)
        {
            DodadiProdukt form = new DodadiProdukt();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                lstProdukti.Items.Add(form.Product);
                CheckAvailability();
                lstProdukti.SelectedIndex = -1;
            }
        }

        private void btnDodadiVoSmetka_Click(object sender, EventArgs e)
        {
            if (lstProdukti.SelectedIndex != -1)
            {
                ProductItem item = new ProductItem();

                item.Product = lstProdukti.SelectedItem as Product;
                item.Quantity = Convert.ToInt32(nupKolicina.Value);

                lstSmetka.Items.Add(item);
                nupKolicina.Value = nupKolicina.Minimum;
                UpdateComputation();
            }
            else
            {
                string message = "Немате избрано продукт!";
                string caption = "Грешка при додавање во сметка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (lstSmetka.SelectedIndex != -1)
            {
                string message = "Дали сте сигурни дека сакате да го избришете продуктот од сметката?";
                string caption = "Бришење од сметка";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lstSmetka.Items.Remove(lstSmetka.SelectedItem);
                    UpdateComputation();
                }
            }
            else
            {
                string message = "Немате избрано продукт!";
                string caption = "Грешка при бришење од сметка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nupDanok_ValueChanged(object sender, EventArgs e)
        {
            UpdateComputation();
        }

        private void UpdateComputation()
        {
            decimal total = 0M;
            foreach (ProductItem item in lstSmetka.Items)
                total += (item.Product.Price * item.Quantity);
            txtVkupno.Text = total.ToString(".");
            decimal toPay = total + (nupDanok.Value / 100M) * total;
            txtZaPlakjanje.Text = toPay.ToString(".");
        }

        private void CheckAvailability()
        {
            if (lstProdukti.Items.Count == 0)
            {
                nupKolicina.Enabled = false;
                btnDodadiVoSmetka.Enabled = false;
                btnIzbrisi.Enabled = false;
            }
            else
            {
                nupKolicina.Enabled = true;
                btnDodadiVoSmetka.Enabled = true;
                btnIzbrisi.Enabled = true;
            }
        }
    }
}