namespace WindowsFormsApp1
{
    partial class FormUslovi
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
            this.txbUslovi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbUslovi
            // 
            this.txbUslovi.Location = new System.Drawing.Point(1, 2);
            this.txbUslovi.Multiline = true;
            this.txbUslovi.Name = "txbUslovi";
            this.txbUslovi.ReadOnly = true;
            this.txbUslovi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbUslovi.Size = new System.Drawing.Size(278, 250);
            this.txbUslovi.TabIndex = 0;
            this.txbUslovi.TabStop = false;
            // 
            // FormUslovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txbUslovi);
            this.Name = "FormUslovi";
            this.Text = "Услови";
            this.Load += new System.EventHandler(this.FormUslovi_Load);
            this.Resize += new System.EventHandler(this.FormUslovi_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUslovi;
    }
}