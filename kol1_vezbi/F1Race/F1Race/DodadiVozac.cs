using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class DodadiVozac : Form
    {
        public Driver Driver { get; set; }

        public DodadiVozac()
        {
            InitializeComponent();
            Driver = new Driver();
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
                e.Cancel = false;
                validatorIme.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Driver.Name = txtIme.Text;
            Driver.Age = Convert.ToInt32(nudVozrast.Value);
            Driver.IsFirst = chbPrv.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}