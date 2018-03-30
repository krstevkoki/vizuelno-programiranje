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
    public partial class DodadiDestinacija : Form
    {
        public Destination Destination { get; set; }

        public DodadiDestinacija()
        {
            InitializeComponent();
            Destination = new Destination();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Destination.City = txtIme.Text;
            Destination.Distance = nupDolzina.Value;
            Destination.Price = Convert.ToInt32(nupCena.Value);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
                validatorIme.Clear();
            }
        }
    }
}