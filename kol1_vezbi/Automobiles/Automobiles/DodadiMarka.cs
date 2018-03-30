using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{
    public partial class DodadiMarka : Form
    {
        public Marka Marka { get; set; }

        public DodadiMarka()
        {
            InitializeComponent();
            Marka = new Marka();
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
                validatorIme.Clear();
            }
        }

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (txtSifra.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                validatorSifra.SetError(txtSifra, "Внесете шифра!");
            }
            else
            {
                validatorSifra.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Marka.Name = txtIme.Text;
            Marka.Sifra = txtSifra.Text;
            DialogResult = DialogResult.OK;
        }
    }
}