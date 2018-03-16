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
    public partial class FormUslovi : Form
    {
        public FormUslovi()
        {
            InitializeComponent();
        }

        private void FormUslovi_Load(object sender, EventArgs e)
        {
            txbUslovi.Text = "ioasjdioajsdioasjdiasd\n" +
                             "okasokdpoaskdpoaskdoaskdaoskd\n" +
                             "oaskdpoakspdokasd\n" +
                             "oaksdpokaspdkaposd\n" +
                             "pokaspdokapod";
            txbUslovi.Size = new System.Drawing.Size(this.Size.Width - 20, this.Size.Height - 43);
        }

        private void FormUslovi_Resize(object sender, EventArgs e)
        {
            txbUslovi.Size = new System.Drawing.Size(this.Size.Width - 20, this.Size.Height - 43);
        }
    }
}