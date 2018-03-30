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
    public partial class DodadiLinija : Form
    {
        public Line Line { get; set; }

        public DodadiLinija()
        {
            InitializeComponent();
            Line = new Line();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Line.City = txtDestinacija.Text;
            Line.Price = nupCena.Value;
            string time = nupCas.Value + ":" + nupMinuta.Value.ToString("00");
            Line.DepartureTime = time;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtDestinacija_Validating(object sender, CancelEventArgs e)
        {
            if (txtDestinacija.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                validatorDestinacija.SetError(txtDestinacija, "Внесете дестинација!");
            }
            else
            {
                validatorDestinacija.Clear();
            }
        }
    }
}