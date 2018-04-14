namespace ImageViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbPateka = new System.Windows.Forms.TextBox();
            this.lblDimenzija = new System.Windows.Forms.Label();
            this.cbZoom = new System.Windows.Forms.CheckBox();
            this.cbScale = new System.Windows.Forms.CheckBox();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 37);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.Controls.Add(this.pbImage);
            this.panelImage.Location = new System.Drawing.Point(133, 46);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(433, 491);
            this.panelImage.TabIndex = 1;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(4, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 50);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images (*.BMP, *.JPG, *.PNG, *.GIF, *.TIFF) | *.BMP; *.JPG; *.PNG; *.GIF; .TIFF| " +
    "All Files (*.*)| *.*";
            // 
            // tbPateka
            // 
            this.tbPateka.Location = new System.Drawing.Point(133, 13);
            this.tbPateka.Name = "tbPateka";
            this.tbPateka.ReadOnly = true;
            this.tbPateka.Size = new System.Drawing.Size(433, 22);
            this.tbPateka.TabIndex = 2;
            // 
            // lblDimenzija
            // 
            this.lblDimenzija.AutoSize = true;
            this.lblDimenzija.Location = new System.Drawing.Point(13, 88);
            this.lblDimenzija.Name = "lblDimenzija";
            this.lblDimenzija.Size = new System.Drawing.Size(0, 17);
            this.lblDimenzija.TabIndex = 3;
            // 
            // cbZoom
            // 
            this.cbZoom.AutoSize = true;
            this.cbZoom.Location = new System.Drawing.Point(13, 88);
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(102, 21);
            this.cbZoom.TabIndex = 4;
            this.cbZoom.Text = "Zoom small";
            this.cbZoom.UseVisualStyleBackColor = true;
            this.cbZoom.CheckedChanged += new System.EventHandler(this.cbZoom_CheckedChanged);
            // 
            // cbScale
            // 
            this.cbScale.AutoSize = true;
            this.cbScale.Location = new System.Drawing.Point(13, 124);
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(88, 21);
            this.cbScale.TabIndex = 5;
            this.cbScale.Text = "Scale big";
            this.cbScale.UseVisualStyleBackColor = true;
            this.cbScale.CheckedChanged += new System.EventHandler(this.cbZoom_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 549);
            this.Controls.Add(this.cbScale);
            this.Controls.Add(this.cbZoom);
            this.Controls.Add(this.lblDimenzija);
            this.Controls.Add(this.tbPateka);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbPateka;
        private System.Windows.Forms.Label lblDimenzija;
        private System.Windows.Forms.CheckBox cbZoom;
        private System.Windows.Forms.CheckBox cbScale;
    }
}

