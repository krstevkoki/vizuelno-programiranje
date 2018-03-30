using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearValues();
        }

        private void btnDodadiMarka_Click(object sender, EventArgs e)
        {
            DodadiMarka form = new DodadiMarka();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                lstMarki.Items.Add(form.Marka);
                lstMarki.SelectedIndex = -1;
                RefreshComputation();
                RefreshValues();
                cbMarki.SelectedIndex = 0;
            }
        }

        private void btnDodadiAvtomobil_Click(object sender, EventArgs e)
        {
            if (cbMarki.SelectedIndex == -1)
            {
                string message = "Изберете марка!";
                string caption = "Неуспешно додавање на автомобил";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtModel.Text.Trim().Length == 0)
            {
                string message = "Внесете модел!";
                string caption = "Неуспешно додавање на автомобил";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Avtomobil avtomobil = new Avtomobil();

            avtomobil.Marka = cbMarki.SelectedItem as Marka;
            avtomobil.Model = txtModel.Text;
            avtomobil.Cena = nupCena.Value;
            avtomobil.Potrosuvacka = nupPotrosuvacka.Value;

            lstAvtomobili.Items.Add(avtomobil);
            ClearValues();
            RefreshComputation();
        }


        private void btnIzbrisiAvtomobil_Click(object sender, EventArgs e)
        {
            if (lstAvtomobili.SelectedIndex != -1)
            {
                string message = "Дали сте сигурни дека сакате да го избришете автомобилот?";
                string caption = "Бришење на автомобил";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lstAvtomobili.Items.Remove(lstAvtomobili.SelectedItem);
                    RefreshComputation();
                }
            }
            else
            {
                string message = "Изберете автомобил!";
                string caption = "Неуспешно бришење на автомобил";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearValues()
        {
            txtModel.Clear();
            cbMarki.SelectedIndex = -1;
            nupPotrosuvacka.Value = nupPotrosuvacka.Minimum;
            nupPotrosuvacka.ResetText();

            nupCena.Value = nupCena.Minimum;
            nupCena.ResetText();
        }

        private void RefreshValues()
        {
            cbMarki.SelectedIndex = -1;
            cbMarki.Items.Clear();
            foreach (Marka item in lstMarki.Items)
                cbMarki.Items.Add(item);
        }

        private void RefreshComputation()
        {
            decimal averageConsumption = 0M;
            decimal minConsumption = Decimal.MaxValue;
            decimal maxPrice = Decimal.MinValue;
            Avtomobil minCar = null;
            Avtomobil maxCar = null;

            foreach (Avtomobil item in lstAvtomobili.Items)
            {
                if (item.Cena > maxPrice)
                {
                    maxPrice = item.Cena;
                    maxCar = item;
                }

                if (item.Potrosuvacka < minConsumption)
                {
                    minConsumption = item.Potrosuvacka;
                    minCar = item;
                }

                averageConsumption += item.Potrosuvacka;
            }

            if ((minCar != null && maxCar != null) || averageConsumption != 0M)
            {
                txtNajskap.Text = maxCar.ToString();
                txtNajekonomicen.Text = minCar.ToString();
                txtProsecnaPotrosuvacka.Text = (averageConsumption / lstAvtomobili.Items.Count).ToString("0.0");
            }
            else
            {
                ClearComputed();
            }
        }

        private void ClearComputed()
        {
            txtNajskap.Clear();
            txtNajekonomicen.Clear();
            txtProsecnaPotrosuvacka.Clear();
        }
    }
}