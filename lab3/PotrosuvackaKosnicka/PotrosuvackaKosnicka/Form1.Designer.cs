namespace PotrosuvackaKosnicka
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstProdukti = new System.Windows.Forms.ListBox();
            this.btnIsprazniLista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnDodadiKosnicka = new System.Windows.Forms.Button();
            this.btnIzbrisiKosnicka = new System.Windows.Forms.Button();
            this.btnDodadiProdukt = new System.Windows.Forms.Button();
            this.btnIzbrisiProdukt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstKosnicka = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVkupno = new System.Windows.Forms.TextBox();
            this.btnIsprazniKosnicka = new System.Windows.Forms.Button();
            this.nupKolicina = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на продукти:";
            // 
            // lstProdukti
            // 
            this.lstProdukti.FormattingEnabled = true;
            this.lstProdukti.ItemHeight = 16;
            this.lstProdukti.Location = new System.Drawing.Point(17, 34);
            this.lstProdukti.Name = "lstProdukti";
            this.lstProdukti.Size = new System.Drawing.Size(266, 404);
            this.lstProdukti.TabIndex = 1;
            this.lstProdukti.SelectedIndexChanged += new System.EventHandler(this.lstProdukti_SelectedIndexChanged);
            // 
            // btnIsprazniLista
            // 
            this.btnIsprazniLista.Location = new System.Drawing.Point(17, 452);
            this.btnIsprazniLista.Name = "btnIsprazniLista";
            this.btnIsprazniLista.Size = new System.Drawing.Size(266, 26);
            this.btnIsprazniLista.TabIndex = 2;
            this.btnIsprazniLista.Text = "Испразни ја листата со продукти?";
            this.btnIsprazniLista.UseVisualStyleBackColor = true;
            this.btnIsprazniLista.Click += new System.EventHandler(this.btnIsprazniLista_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKategorija);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(289, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(10, 92);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.ReadOnly = true;
            this.txtKategorija.Size = new System.Drawing.Size(252, 22);
            this.txtKategorija.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категорија:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(10, 43);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(252, 22);
            this.txtIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Име";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(299, 180);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(124, 22);
            this.txtCena.TabIndex = 5;
            this.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDodadiKosnicka
            // 
            this.btnDodadiKosnicka.Location = new System.Drawing.Point(289, 236);
            this.btnDodadiKosnicka.Name = "btnDodadiKosnicka";
            this.btnDodadiKosnicka.Size = new System.Drawing.Size(189, 26);
            this.btnDodadiKosnicka.TabIndex = 6;
            this.btnDodadiKosnicka.Text = "Додади во кошничка >>";
            this.btnDodadiKosnicka.UseVisualStyleBackColor = true;
            this.btnDodadiKosnicka.Click += new System.EventHandler(this.btnDodadiKosnicka_Click);
            // 
            // btnIzbrisiKosnicka
            // 
            this.btnIzbrisiKosnicka.Location = new System.Drawing.Point(289, 286);
            this.btnIzbrisiKosnicka.Name = "btnIzbrisiKosnicka";
            this.btnIzbrisiKosnicka.Size = new System.Drawing.Size(278, 26);
            this.btnIzbrisiKosnicka.TabIndex = 7;
            this.btnIzbrisiKosnicka.Text = "Избриши од кошничка";
            this.btnIzbrisiKosnicka.UseVisualStyleBackColor = true;
            this.btnIzbrisiKosnicka.Click += new System.EventHandler(this.btnIzbrisiKosnicka_Click);
            // 
            // btnDodadiProdukt
            // 
            this.btnDodadiProdukt.Location = new System.Drawing.Point(289, 341);
            this.btnDodadiProdukt.Name = "btnDodadiProdukt";
            this.btnDodadiProdukt.Size = new System.Drawing.Size(278, 26);
            this.btnDodadiProdukt.TabIndex = 8;
            this.btnDodadiProdukt.Text = "Додади нов продукт";
            this.btnDodadiProdukt.UseVisualStyleBackColor = true;
            this.btnDodadiProdukt.Click += new System.EventHandler(this.btnDodadiProdukt_Click);
            // 
            // btnIzbrisiProdukt
            // 
            this.btnIzbrisiProdukt.Location = new System.Drawing.Point(289, 395);
            this.btnIzbrisiProdukt.Name = "btnIzbrisiProdukt";
            this.btnIzbrisiProdukt.Size = new System.Drawing.Size(278, 26);
            this.btnIzbrisiProdukt.TabIndex = 9;
            this.btnIzbrisiProdukt.Text = "Избриши продукт";
            this.btnIzbrisiProdukt.UseVisualStyleBackColor = true;
            this.btnIzbrisiProdukt.Click += new System.EventHandler(this.btnIzbrisiProdukt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кошничка";
            // 
            // lstKosnicka
            // 
            this.lstKosnicka.FormattingEnabled = true;
            this.lstKosnicka.ItemHeight = 16;
            this.lstKosnicka.Location = new System.Drawing.Point(573, 39);
            this.lstKosnicka.Name = "lstKosnicka";
            this.lstKosnicka.Size = new System.Drawing.Size(350, 340);
            this.lstKosnicka.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(585, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Вкупно:";
            // 
            // txtVkupno
            // 
            this.txtVkupno.Location = new System.Drawing.Point(650, 402);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.ReadOnly = true;
            this.txtVkupno.Size = new System.Drawing.Size(273, 22);
            this.txtVkupno.TabIndex = 13;
            this.txtVkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIsprazniKosnicka
            // 
            this.btnIsprazniKosnicka.Location = new System.Drawing.Point(573, 452);
            this.btnIsprazniKosnicka.Name = "btnIsprazniKosnicka";
            this.btnIsprazniKosnicka.Size = new System.Drawing.Size(345, 26);
            this.btnIsprazniKosnicka.TabIndex = 14;
            this.btnIsprazniKosnicka.Text = "Испразни ја кошничката?";
            this.btnIsprazniKosnicka.UseVisualStyleBackColor = true;
            this.btnIsprazniKosnicka.Click += new System.EventHandler(this.btnIsprazniKosnicka_Click);
            // 
            // nupKolicina
            // 
            this.nupKolicina.Location = new System.Drawing.Point(499, 240);
            this.nupKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupKolicina.Name = "nupKolicina";
            this.nupKolicina.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nupKolicina.Size = new System.Drawing.Size(68, 22);
            this.nupKolicina.TabIndex = 5;
            this.nupKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 488);
            this.Controls.Add(this.nupKolicina);
            this.Controls.Add(this.btnIsprazniKosnicka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVkupno);
            this.Controls.Add(this.lstKosnicka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIzbrisiProdukt);
            this.Controls.Add(this.btnDodadiProdukt);
            this.Controls.Add(this.btnIzbrisiKosnicka);
            this.Controls.Add(this.btnDodadiKosnicka);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIsprazniLista);
            this.Controls.Add(this.lstProdukti);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProdukti;
        private System.Windows.Forms.Button btnIsprazniLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button btnDodadiKosnicka;
        private System.Windows.Forms.Button btnIzbrisiKosnicka;
        private System.Windows.Forms.Button btnDodadiProdukt;
        private System.Windows.Forms.Button btnIzbrisiProdukt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstKosnicka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.Button btnIsprazniKosnicka;
        private System.Windows.Forms.NumericUpDown nupKolicina;
    }
}

