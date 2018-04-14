using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Environment.MachineName;
            timerRefresh.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timerRefresh.Stop();
            string message = "Дали сте сигурни дека сакате да ја исклучете апликацијата?";
            string caption = "Исклучување на апликација";
            var res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
            else
                timerRefresh.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblRam.Text = pcRam.NextValue().ToString("#,000");
            lblProcesor.Text = $"{pcProcesor.NextValue():0.0}%";
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }
    }
}