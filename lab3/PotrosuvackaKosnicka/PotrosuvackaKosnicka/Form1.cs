using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotrosuvackaKosnicka
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

        private void btnDodadiProdukt_Click(object sender, EventArgs e)
        {
            DodadiForm form = new DodadiForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                lstProdukti.Items.Add(form.Product);
        }

        private void btnIzbrisiProdukt_Click(object sender, EventArgs e)
        {
            if (lstProdukti.SelectedIndex != -1)
            {
                lstProdukti.Items.Remove(lstProdukti.SelectedItem);
                ClearValues();
            }
            else
                MessageBox.Show("Немате избрано продукт!", "Грешка при бришење", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }


        private void btnIsprazniLista_Click(object sender, EventArgs e)
        {
            string message = "Дали сте сигурни дека сакате да ја испразните листата со продукти";
            string caption = "Испразни ја листата?";
            DialogResult res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                lstProdukti.Items.Clear();
                ClearValues();
            }
        }

        private void lstProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProdukti.SelectedIndex != -1)
            {
                txtIme.Text = ((Product) lstProdukti.SelectedItem).Name;
                txtKategorija.Text = ((Product) lstProdukti.SelectedItem).Category;
                txtCena.Text = ((Product) lstProdukti.SelectedItem).Price.ToString(".00");
            }
        }

        private void btnDodadiKosnicka_Click(object sender, EventArgs e)
        {
            if (lstProdukti.SelectedIndex != -1)
            {
                ProductItem item = new ProductItem();
                item.Product = (Product) lstProdukti.SelectedItem;
                item.Quantity = (int) nupKolicina.Value;

                /*if (!lstKosnicka.Items.Contains(item))
                {
                    lstKosnicka.Items.Add(item);
                    CalculatePrice();
                }
                else
                {
                    MessageBox.Show("Продуктот веќе постои во кошничката!", "Грешка при додавање",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                lstKosnicka.Items.Add(item);
                CalculatePrice();
                nupKolicina.Value = nupKolicina.Minimum;
                lstProdukti.SelectedIndex = -1;
                ClearValues();
            }
            else
            {
                MessageBox.Show("Немате избрано продукт!", "Грешка при додавање",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzbrisiKosnicka_Click(object sender, EventArgs e)
        {
            if (lstKosnicka.SelectedIndex != -1)
            {
                lstKosnicka.Items.Remove(lstKosnicka.SelectedItem);
                CalculatePrice();
            }
            else
            {
                MessageBox.Show("Немате избрано продукт!", "Грешка при бришење", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnIsprazniKosnicka_Click(object sender, EventArgs e)
        {
            string message = "Дали сте сигурни дека сакате да ја испразните кошничката?";
            string caption = "Испразни ја кошничката?";
            DialogResult res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                lstKosnicka.Items.Clear();
                CalculatePrice();
            }
        }

        private void CalculatePrice()
        {
            int price = 0;
            foreach (var item in lstKosnicka.Items)
            {
                ProductItem product = (ProductItem) item;
                price += (product.Product.Price * product.Quantity);
            }

            txtVkupno.Text = price.ToString("0.00");
        }

        private void ClearValues()
        {
            txtIme.Text = "";
            txtKategorija.Text = "";
            txtCena.Text = "";
        }
    }
}