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
    public partial class PrintTicket : Form
    {
        public string Payment { get; set; }
        public string Coefficient { get; set; }
        public string Profit { get; set; }
        public string Danok { get; set; }
        public string Isplata { get; set; }
        public List<Ticket> Tickets { get; set; }

        public PrintTicket()
        {
            InitializeComponent();
            Tickets = new List<Ticket>();
        }

        public void init()
        {
            txtProfit.Text = Profit;
            txtCoefficient.Text = Coefficient;
            txtDanok.Text = Danok;
            txtIsplata.Text = Isplata;
            txtPayment.Text = Payment;
            foreach (var ticket in Tickets)
            {
                DataGridViewRow row = (DataGridViewRow) dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = ticket.Game.Code;
                row.Cells[1].Value = string.Format("{0} - {1}", ticket.Game.Home.Name, ticket.Game.Away.Name);
                row.Cells[2].Value = ticket.Game.Coefficients[ticket.Tip].ToString(".00");
                dataGridView1.Rows.Add(row);
            }
        }
    }
}