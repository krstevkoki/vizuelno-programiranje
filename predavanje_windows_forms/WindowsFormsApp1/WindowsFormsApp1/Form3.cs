using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txbVozrast_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            int vozrast;
            if (!int.TryParse(txbVozrast.Text, out vozrast) || vozrast < 1)
            {
                errorMsg = "Невалидна возраст";
                e.Cancel = true;
                txbVozrast.Select(0, txbVozrast.Text.Length);
                errorProviderVozrast.SetError(txbVozrast, errorMsg);
            }
            else
                errorProviderVozrast.SetError(txbVozrast, errorMsg);
        }

        private void txbMail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            if (!ValidEmailAddress(txbMail.Text, out errorMsg))
            {
                e.Cancel = true;
                errorProviderEmail.SetError(txbMail, errorMsg);
            }
            else
                errorProviderEmail.SetError(txbMail, errorMsg);
        }

        private static bool ValidEmailAddress(string emailAddress, out string errorMsg)
        {
            if (emailAddress.Length == 0)
            {
                errorMsg = "e-mail address is required.";
                return false;
            }

            int atPos;
            if ((atPos = emailAddress.IndexOf("@")) > -1)
            {
                int dotPos = emailAddress.IndexOf(".", atPos); // index na '.' posle pozicijata na '@'
                int secondAtPos = emailAddress.IndexOf("@", atPos + 1); // index na drugo '@' posle pozicijata na '@'
                if (dotPos > atPos && secondAtPos <= atPos)
                {
                    errorMsg = "";
                    return true;
                }
            }

            errorMsg = "e-mail адресата мора да биде во валиден формат \n" +
                       "На пример: 'someone@example.com' ";
            return false;
        }

        private void txbKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b' && !((c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F') || (c >= '0' && c <= '9')))
                e.Handled = true;
            if (c >= 'a' && c <= 'f')
                e.KeyChar = char.ToUpper(c);
        }

        private void cbUslovi_CheckedChanged(object sender, EventArgs e)
        {
            btnVnesi.Enabled = cbUslovi.Checked;
        }

        private void btnVnesi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting..");
            this.Close();
        }

        private void linkUslovi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUslovi form = new FormUslovi();
            form.ShowDialog();
        }
    }
}