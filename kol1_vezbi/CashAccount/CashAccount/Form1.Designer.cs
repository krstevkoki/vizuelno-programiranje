namespace CashAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstProdukti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nupKolicina = new System.Windows.Forms.NumericUpDown();
            this.btnDodadiVoSmetka = new System.Windows.Forms.Button();
            this.btnDodadiNov = new System.Windows.Forms.Button();
            this.lstSmetka = new System.Windows.Forms.ListBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVkupno = new System.Windows.Forms.TextBox();
            this.txtZaPlakjanje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupDanok = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDanok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodadiNov);
            this.groupBox1.Controls.Add(this.btnDodadiVoSmetka);
            this.groupBox1.Controls.Add(this.nupKolicina);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstProdukti);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продукти";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nupDanok);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtZaPlakjanje);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVkupno);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnIzbrisi);
            this.groupBox2.Controls.Add(this.lstSmetka);
            this.groupBox2.Location = new System.Drawing.Point(289, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 522);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сметка";
            // 
            // lstProdukti
            // 
            this.lstProdukti.FormattingEnabled = true;
            this.lstProdukti.ItemHeight = 16;
            this.lstProdukti.Location = new System.Drawing.Point(7, 22);
            this.lstProdukti.Name = "lstProdukti";
            this.lstProdukti.Size = new System.Drawing.Size(258, 356);
            this.lstProdukti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количина:";
            // 
            // nupKolicina
            // 
            this.nupKolicina.Location = new System.Drawing.Point(90, 391);
            this.nupKolicina.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nupKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupKolicina.Name = "nupKolicina";
            this.nupKolicina.Size = new System.Drawing.Size(175, 22);
            this.nupKolicina.TabIndex = 2;
            this.nupKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDodadiVoSmetka
            // 
            this.btnDodadiVoSmetka.Location = new System.Drawing.Point(10, 431);
            this.btnDodadiVoSmetka.Name = "btnDodadiVoSmetka";
            this.btnDodadiVoSmetka.Size = new System.Drawing.Size(255, 34);
            this.btnDodadiVoSmetka.TabIndex = 3;
            this.btnDodadiVoSmetka.Text = "Додади во сметка";
            this.btnDodadiVoSmetka.UseVisualStyleBackColor = true;
            this.btnDodadiVoSmetka.Click += new System.EventHandler(this.btnDodadiVoSmetka_Click);
            // 
            // btnDodadiNov
            // 
            this.btnDodadiNov.Location = new System.Drawing.Point(10, 482);
            this.btnDodadiNov.Name = "btnDodadiNov";
            this.btnDodadiNov.Size = new System.Drawing.Size(255, 34);
            this.btnDodadiNov.TabIndex = 4;
            this.btnDodadiNov.Text = "Додади нов";
            this.btnDodadiNov.UseVisualStyleBackColor = true;
            this.btnDodadiNov.Click += new System.EventHandler(this.btnDodadiNov_Click);
            // 
            // lstSmetka
            // 
            this.lstSmetka.FormattingEnabled = true;
            this.lstSmetka.ItemHeight = 16;
            this.lstSmetka.Location = new System.Drawing.Point(16, 22);
            this.lstSmetka.Name = "lstSmetka";
            this.lstSmetka.Size = new System.Drawing.Size(258, 324);
            this.lstSmetka.TabIndex = 5;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(16, 352);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(258, 26);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "Избриши ставка";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вкупно:";
            // 
            // txtVkupno
            // 
            this.txtVkupno.Location = new System.Drawing.Point(107, 396);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.ReadOnly = true;
            this.txtVkupno.Size = new System.Drawing.Size(167, 22);
            this.txtVkupno.TabIndex = 6;
            // 
            // txtZaPlakjanje
            // 
            this.txtZaPlakjanje.Location = new System.Drawing.Point(107, 491);
            this.txtZaPlakjanje.Name = "txtZaPlakjanje";
            this.txtZaPlakjanje.ReadOnly = true;
            this.txtZaPlakjanje.Size = new System.Drawing.Size(167, 22);
            this.txtZaPlakjanje.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "За плаќање";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Данок (%):";
            // 
            // nupDanok
            // 
            this.nupDanok.Location = new System.Drawing.Point(107, 441);
            this.nupDanok.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nupDanok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDanok.Name = "nupDanok";
            this.nupDanok.Size = new System.Drawing.Size(167, 22);
            this.nupDanok.TabIndex = 5;
            this.nupDanok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupDanok.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nupDanok.ValueChanged += new System.EventHandler(this.nupDanok_ValueChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDodadiNov;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Каса";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDanok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodadiNov;
        private System.Windows.Forms.Button btnDodadiVoSmetka;
        private System.Windows.Forms.NumericUpDown nupKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProdukti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nupDanok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZaPlakjanje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.ListBox lstSmetka;
    }
}

