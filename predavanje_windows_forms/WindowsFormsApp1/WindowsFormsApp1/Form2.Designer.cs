namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnZdravo = new System.Windows.Forms.Button();
            this.btnDogledanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZdravo
            // 
            this.btnZdravo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZdravo.Location = new System.Drawing.Point(87, 49);
            this.btnZdravo.Name = "btnZdravo";
            this.btnZdravo.Size = new System.Drawing.Size(265, 78);
            this.btnZdravo.TabIndex = 0;
            this.btnZdravo.Text = "Здраво";
            this.btnZdravo.UseVisualStyleBackColor = true;
            this.btnZdravo.Click += new System.EventHandler(this.btnZdravo_Click);
            // 
            // btnDogledanje
            // 
            this.btnDogledanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDogledanje.Location = new System.Drawing.Point(87, 221);
            this.btnDogledanje.Name = "btnDogledanje";
            this.btnDogledanje.Size = new System.Drawing.Size(265, 78);
            this.btnDogledanje.TabIndex = 1;
            this.btnDogledanje.Text = "Догледање";
            this.btnDogledanje.UseVisualStyleBackColor = true;
            this.btnDogledanje.Click += new System.EventHandler(this.btnDogledanje_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 392);
            this.Controls.Add(this.btnDogledanje);
            this.Controls.Add(this.btnZdravo);
            this.Name = "Form2";
            this.Text = "Поздрав";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZdravo;
        private System.Windows.Forms.Button btnDogledanje;
    }
}