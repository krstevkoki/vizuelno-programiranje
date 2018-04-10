using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTimer
{
    public partial class DisplayBestPlayers : Form
    {
        public IOrderedEnumerable<Player> Players { get; }
        public DisplayBestPlayers(IOrderedEnumerable<Player> players)
        {
            InitializeComponent();
            Players = players;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DisplayBestPlayers_Load(object sender, EventArgs e)
        {
            int i = 1;
            foreach (var player in Players)
            {
                var row = (DataGridViewRow)dgvIgraci.Rows[0].Clone();
                row.Cells[0].Value = i++.ToString();
                row.Cells[1].Value = player.Name;
                row.Cells[2].Value = player.Score.ToString();
                dgvIgraci.Rows.Add(row);
            }
        }
    }
}
