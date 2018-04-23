using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines2
{
    public enum LineThickness
    {
        Thin = 1, Normal = 3, Thick = 5
    }

    public partial class Form1 : Form
    {
        public LinesDoc LinesDoc { get; set; }

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinesDoc = new LinesDoc(this.Width, this.Height);
            lblColor.Text = $"{LinesDoc.Color}";
            lblLines.Text = $"Lines: {LinesDoc.GetLinesNumber()}";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Дали сакате да ја исклучете апликацијата?";
            string caption = "Исклучување на апликација";
            var res = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinesDoc.Thickness = Convert.ToInt32(LineThickness.Thin);
            UncheckOthers(0);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinesDoc.Thickness = Convert.ToInt32(LineThickness.Normal);
            UncheckOthers(1);
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinesDoc.Thickness = Convert.ToInt32(LineThickness.Thick);
            UncheckOthers(2);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var res = colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                LinesDoc.Color = colorDialog.Color;
                lblColor.Text = $"{LinesDoc.Color}";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var newLocation = new Point(e.X, e.Y);
            LinesDoc.UpdateLocation(newLocation);
            lblCoordinates.Text = $"X: {e.X}, Y:{e.Y}";
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            LinesDoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var location = new Point(e.X, e.Y);
            LinesDoc.AddLine(location);
            lblLines.Text = $"Lines: {LinesDoc.GetLinesNumber()}";
            Invalidate();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinesDoc.Undo();
            lblLines.Text = $"Lines: {LinesDoc.GetLinesNumber()}";
            Invalidate();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinesDoc.Redo();
            lblLines.Text = $"Lines: {LinesDoc.GetLinesNumber()}";
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                LinesDoc.Move(0, -10);

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                LinesDoc.Move(0, 10);

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                LinesDoc.Move(-10, 0);

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                LinesDoc.Move(10, 0);

            Invalidate();
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionerToolStripMenuItem.Checked = !positionerToolStripMenuItem.Checked;
            LinesDoc.Positioner = positionerToolStripMenuItem.Checked;
            Invalidate();
        }

        private void UncheckOthers(int itemId)
        {
            for (int i = 1; i <= 3; ++i)
            {
                if (itemId == 0)
                {
                    thinToolStripMenuItem.Checked = true;
                    normalToolStripMenuItem.Checked = false;
                    thickToolStripMenuItem.Checked = false;
                }

                if (itemId == 1)
                {
                    thinToolStripMenuItem.Checked = false;
                    normalToolStripMenuItem.Checked = true;
                    thickToolStripMenuItem.Checked = false;
                }

                if (itemId == 2)
                {
                    thinToolStripMenuItem.Checked = false;
                    normalToolStripMenuItem.Checked = false;
                    thickToolStripMenuItem.Checked = true;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int previousThickness = LinesDoc.Thickness;
            Color previousColor = LinesDoc.Color;

            LinesDoc = new LinesDoc(this.Width, this.Height);
            LinesDoc.Thickness = previousThickness;
            LinesDoc.Color = previousColor;

            lblColor.Text = $"{LinesDoc.Color}";
            lblLines.Text = $"Lines: {LinesDoc.GetLinesNumber()}";
            Invalidate();
        }
    }
}