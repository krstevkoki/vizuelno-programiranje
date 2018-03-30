using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProblems
{
    public partial class DodadiIspit : Form
    {
        public Ispit Ispit { get; set; }

        public DodadiIspit()
        {
            InitializeComponent();
            Ispit = new Ispit();
        }

        private void DodadiIspit_Load(object sender, EventArgs e)
        {
            nudGodina.Focus();
        }

        private void cbMesec_Validating(object sender, CancelEventArgs e)
        {
            if (cbMesec.SelectedIndex == -1)
            {
                e.Cancel = true;
                validatorMesec.SetError(cbMesec, "Изберете месец!");
            }
            else
            {
                validatorMesec.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Ispit.Month = (string) cbMesec.SelectedItem;
            Ispit.Year = Convert.ToInt32(nudGodina.Value);
            DialogResult = DialogResult.OK;
        }
    }
}