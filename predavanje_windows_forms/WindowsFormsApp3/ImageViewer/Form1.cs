using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Bitmap Image { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckState();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var res = openFileDialog1.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                Bitmap image = null;

                try
                {
                    image = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception )
                {
                    if (image != null)
                    {
                        image.Dispose();
                        image = null;
                    }
                }

                if (image != null)
                {
                    panelImage.HorizontalScroll.Value = 0;
                    panelImage.VerticalScroll.Value = 0;
                    ShowImage(image);
                }
            }

            CheckState();
        }

        private void ShowImage(Bitmap image)
        {
            SuspendLayout();

            lblDimenzija.Text = image.Width + "x" + image.Height;
            tbPateka.Text = openFileDialog1.SafeFileName;

            pbImage.Size = panelImage.Size;
            if (image.Height < panelImage.Height && image.Width < panelImage.Width)
            {
                pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
                if (cbZoom.Checked)
                    pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                if (cbScale.Checked)
                    pbImage.SizeMode = PictureBoxSizeMode.Zoom;
                else
                    pbImage.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            Bitmap oldImg = Image;

            pbImage.Image = Image = image;

            if (oldImg != null && oldImg != Image)
            {
                oldImg.Dispose();
                oldImg = null;
            }

            pbImage.Image = image;
            ResumeLayout();
        }

        private void cbZoom_CheckedChanged(object sender, EventArgs e)
        {
            panelImage.HorizontalScroll.Value = 0;
            panelImage.VerticalScroll.Value = 0;
            ShowImage(Image);
        }

        public void CheckState()
        {
            if (Image == null)
            {
                cbScale.Enabled = false;
                cbZoom.Enabled = false;
            }
            else
            {
                cbScale.Enabled = true;
                cbZoom.Enabled = true;
            }
        }
        
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Size newSize = new Size(this.Width - 120, this.Height - 80);

            panelImage.Size = newSize;
            pbImage.Size = newSize;
            panelImage.HorizontalScroll.Value = 0;
            panelImage.VerticalScroll.Value = 0;
            if (Image != null)
                ShowImage(Image);
        }
    }
}