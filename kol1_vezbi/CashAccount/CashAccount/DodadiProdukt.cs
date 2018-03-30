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
    public partial class DodadiProdukt : Form
    {
        public Product Product { get; set; }

        public DodadiProdukt()
        {
            InitializeComponent();
            Product = new Product();
        }

        private void txtKod_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                validatorIme.SetError(txtIme, "Внесете име!");
            }
            else
            {
                validatorIme.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product.Name = txtIme.Text;
            Product.Price = nupCena.Value;
            Product.Code = nupKod.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}