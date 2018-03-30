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
    public partial class DodadiAerodrom : Form
    {
        public Airport Airport { get; set; }

        public DodadiAerodrom()
        {
            InitializeComponent();
            Airport = new Airport();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Airport.Code = txtKod.Text;
            Airport.Name = txtIme.Text;
            Airport.City = txtGrad.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtGrad_Validating(object sender, CancelEventArgs e)
        {
            if (txtGrad.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                validatorGrad.SetError(txtGrad, "Внесете град!");
            }
            else
            {
                validatorGrad.Clear();
            }
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

        private void txtKod_Validating(object sender, CancelEventArgs e)
        {
            if (txtKod.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                validatorKod.SetError(txtKod, "Внесете код!");
            }
            else if (!IsValidCode(txtKod.Text.Trim()))
            {
                e.Cancel = true;
                validatorKod.SetError(txtKod, "Невалиден код!");
            }
            else
            {
                validatorKod.Clear();
            }
        }

        private static bool IsValidCode(string code)
        {
            if (code.Length != 3)
                return false;
            foreach (var letter in code)
                if (!(letter >= 65 && letter <= 90))  // not in [A-Z]
                    return false;

            return true;
        }
    }
}