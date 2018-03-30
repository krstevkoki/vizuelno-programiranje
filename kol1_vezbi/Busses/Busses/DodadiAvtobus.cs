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
    public partial class DodadiAvtobus : Form
    {
        public Avtobus Avtobus { get; set; }

        public DodadiAvtobus()
        {
            InitializeComponent();
            Avtobus = new Avtobus();
        }


        private void txtRegistracija_Validating(object sender, CancelEventArgs e)
        {
            if (txtRegistracija.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                validatorRegistracija.SetError(txtRegistracija, "Внесете регистрација!");
            }
            else if (!IsValidRegistration(txtRegistracija.Text.Trim()))
            {
                e.Cancel = true;
                validatorRegistracija.SetError(txtRegistracija, "Внесете валидна регистрација!");
            }
            else
            {
                validatorRegistracija.Clear();
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
        private static bool IsValidRegistration(string code)
        {
            if (code.Length != 4)
                return false;
            foreach (var c in code)
                if (!(c >= 48 && c <= 57))
                    return false;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Avtobus.Name = txtIme.Text;
            Avtobus.Registration = txtRegistracija.Text;
            Avtobus.IsLocal = chbLokal.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}