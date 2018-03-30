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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ispit ispit1 = new Ispit();
            ispit1.Year = 2017;
            ispit1.Month = "Јуни";

            Ispit ispit2 = new Ispit();
            ispit2.Year = 2018;
            ispit2.Month = "Јуни";

            lstIspiti.Items.Add(ispit1);
            lstIspiti.Items.Add(ispit2);
        }

        private void btnDodadiIspit_Click(object sender, EventArgs e)
        {
            DodadiIspit form = new DodadiIspit();
            var res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                lstIspiti.Items.Add(form.Ispit);
            }
        }

        private void lstIspiti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIspiti.SelectedIndex != -1)
            {
                btnIzbrisiIspit.Enabled = true;
                Ispit ispit = lstIspiti.SelectedItem as Ispit;
                txtOpis1.Text = ispit.Zadaca1.Description;
                txtOpis2.Text = ispit.Zadaca2.Description;

                nudPoeni1.Value = ispit.Zadaca1.Points;
                nudPoeni2.Value = ispit.Zadaca2.Points;
            }
        }

        private void btnIzbrisiIspit_Click(object sender, EventArgs e)
        {
            string message = "Дали сте сигурни дека сакате да го избришете испитот?";
            string caption = "Бришење на испит";
            var res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                lstIspiti.Items.Remove(lstIspiti.SelectedItem);
                ClearValues();
            }
        }

        private void ClearValues()
        {
            btnIzbrisiIspit.Enabled = false;
            txtOpis1.Clear();
            txtOpis2.Clear();
            nudPoeni1.Value = nudPoeni1.Minimum;
            nudPoeni2.Value = nudPoeni2.Minimum;
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (lstIspiti.SelectedIndex != -1)
            {
                Ispit ispit = lstIspiti.SelectedItem as Ispit;
                ispit.Zadaca1.Description = txtOpis1.Text;
                ispit.Zadaca1.Points = Convert.ToInt32(nudPoeni1.Value);
            }
            else
            {
                string message = "Изберете испит!";
                string caption = "Грешка при зачувување";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (lstIspiti.SelectedIndex != -1)
            {
                Ispit ispit = lstIspiti.SelectedItem as Ispit;
                ispit.Zadaca2.Description = txtOpis2.Text;
                ispit.Zadaca2.Points = Convert.ToInt32(nudPoeni2.Value);
            }
            else
            {
                string message = "Изберете испит!";
                string caption = "Грешка при зачувување";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}