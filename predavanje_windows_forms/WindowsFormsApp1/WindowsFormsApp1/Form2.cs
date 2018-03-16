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
    public partial class Form2 : Form
    {
        public bool Clicked { get; private set; }

        public Form2()
        {
            InitializeComponent();
            Clicked = false;
        }

        private void btnZdravo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здраво");
            Clicked = true;
        }

        private void btnDogledanje_Click(object sender, EventArgs e)
        {
            if (Clicked)
            {
                MessageBox.Show("Догледање");
                Application.Exit();
            }
            else
                MessageBox.Show("Си одиш, а ни здраво не кажа");
        }
    }
}