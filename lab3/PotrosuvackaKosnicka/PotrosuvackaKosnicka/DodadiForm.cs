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
    public partial class DodadiForm : Form
    {
        public Product Product { get; set; }

        public DodadiForm()
        {
            InitializeComponent();
            Product = new Product();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product.Name = txtIme.Text;
            Product.Category = txtKategorija.Text;
            if (int.TryParse(txtCena.Text, out int price))
                Product.Price = price;
            else
                throw new FormatException(txtCena.Text);
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                validatorIme.SetError(txtIme, "Внесете име!");
            }
            else
            {
                validatorIme.SetError(txtIme, null);
            }
        }

        private void txtKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (txtKategorija.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                validatorKategorija.SetError(txtKategorija, "Внесете категорија!");
            }
            else
            {
                validatorKategorija.SetError(txtKategorija, null);
            }
        }

        private void txtCena_Validating(object sender, CancelEventArgs e)
        {
            if (txtCena.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                validatorCena.SetError(txtCena, "Внесете цена!");
            }
            else if (!int.TryParse(txtCena.Text.Trim(), out int price))
            {
                e.Cancel = true;
                validatorCena.SetError(txtCena, "Внесете валидна цена!");
            }
            else
            {
                validatorCena.SetError(txtCena, null);
            }
        }
    }
}