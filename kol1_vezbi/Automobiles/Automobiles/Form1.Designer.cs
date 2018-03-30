namespace Automobiles
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
            this.lstMarki = new System.Windows.Forms.ListBox();
            this.btnDodadiMarka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarki = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nupPotrosuvacka = new System.Windows.Forms.NumericUpDown();
            this.nupCena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodadiAvtomobil = new System.Windows.Forms.Button();
            this.btnIzbrisiAvtomobil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstAvtomobili = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProsecnaPotrosuvacka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNajekonomicen = new System.Windows.Forms.TextBox();
            this.txtNajskap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPotrosuvacka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCena)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisiAvtomobil);
            this.groupBox1.Controls.Add(this.btnDodadiAvtomobil);
            this.groupBox1.Controls.Add(this.nupCena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nupPotrosuvacka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMarki);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нов автомобил";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodadiMarka);
            this.groupBox2.Controls.Add(this.lstMarki);
            this.groupBox2.Location = new System.Drawing.Point(13, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Марки на автомобили";
            // 
            // lstMarki
            // 
            this.lstMarki.FormattingEnabled = true;
            this.lstMarki.ItemHeight = 16;
            this.lstMarki.Location = new System.Drawing.Point(7, 22);
            this.lstMarki.Name = "lstMarki";
            this.lstMarki.Size = new System.Drawing.Size(342, 148);
            this.lstMarki.TabIndex = 0;
            // 
            // btnDodadiMarka
            // 
            this.btnDodadiMarka.Location = new System.Drawing.Point(189, 176);
            this.btnDodadiMarka.Name = "btnDodadiMarka";
            this.btnDodadiMarka.Size = new System.Drawing.Size(160, 23);
            this.btnDodadiMarka.TabIndex = 1;
            this.btnDodadiMarka.Text = "Додади нова марка";
            this.btnDodadiMarka.UseVisualStyleBackColor = true;
            this.btnDodadiMarka.Click += new System.EventHandler(this.btnDodadiMarka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка:";
            // 
            // cbMarki
            // 
            this.cbMarki.FormattingEnabled = true;
            this.cbMarki.Location = new System.Drawing.Point(10, 43);
            this.cbMarki.Name = "cbMarki";
            this.cbMarki.Size = new System.Drawing.Size(345, 24);
            this.cbMarki.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модел:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(10, 90);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(345, 22);
            this.txtModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Потрошувачка:";
            // 
            // nupPotrosuvacka
            // 
            this.nupPotrosuvacka.Location = new System.Drawing.Point(10, 141);
            this.nupPotrosuvacka.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nupPotrosuvacka.Name = "nupPotrosuvacka";
            this.nupPotrosuvacka.Size = new System.Drawing.Size(156, 22);
            this.nupPotrosuvacka.TabIndex = 5;
            // 
            // nupCena
            // 
            this.nupCena.Location = new System.Drawing.Point(10, 193);
            this.nupCena.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nupCena.Name = "nupCena";
            this.nupCena.Size = new System.Drawing.Size(156, 22);
            this.nupCena.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена:";
            // 
            // btnDodadiAvtomobil
            // 
            this.btnDodadiAvtomobil.Location = new System.Drawing.Point(10, 239);
            this.btnDodadiAvtomobil.Name = "btnDodadiAvtomobil";
            this.btnDodadiAvtomobil.Size = new System.Drawing.Size(170, 23);
            this.btnDodadiAvtomobil.TabIndex = 2;
            this.btnDodadiAvtomobil.Text = "Додади автомобил";
            this.btnDodadiAvtomobil.UseVisualStyleBackColor = true;
            this.btnDodadiAvtomobil.Click += new System.EventHandler(this.btnDodadiAvtomobil_Click);
            // 
            // btnIzbrisiAvtomobil
            // 
            this.btnIzbrisiAvtomobil.Location = new System.Drawing.Point(196, 239);
            this.btnIzbrisiAvtomobil.Name = "btnIzbrisiAvtomobil";
            this.btnIzbrisiAvtomobil.Size = new System.Drawing.Size(159, 23);
            this.btnIzbrisiAvtomobil.TabIndex = 8;
            this.btnIzbrisiAvtomobil.Text = "Избриши автомобил";
            this.btnIzbrisiAvtomobil.UseVisualStyleBackColor = true;
            this.btnIzbrisiAvtomobil.Click += new System.EventHandler(this.btnIzbrisiAvtomobil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNajskap);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNajekonomicen);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lstAvtomobili);
            this.groupBox3.Location = new System.Drawing.Point(381, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 486);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Листа на автомобили";
            // 
            // lstAvtomobili
            // 
            this.lstAvtomobili.FormattingEnabled = true;
            this.lstAvtomobili.ItemHeight = 16;
            this.lstAvtomobili.Location = new System.Drawing.Point(7, 22);
            this.lstAvtomobili.Name = "lstAvtomobili";
            this.lstAvtomobili.Size = new System.Drawing.Size(370, 324);
            this.lstAvtomobili.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Просечна потрошувачка:";
            // 
            // txtProsecnaPotrosuvacka
            // 
            this.txtProsecnaPotrosuvacka.Location = new System.Drawing.Point(588, 376);
            this.txtProsecnaPotrosuvacka.Name = "txtProsecnaPotrosuvacka";
            this.txtProsecnaPotrosuvacka.ReadOnly = true;
            this.txtProsecnaPotrosuvacka.Size = new System.Drawing.Size(170, 22);
            this.txtProsecnaPotrosuvacka.TabIndex = 9;
            this.txtProsecnaPotrosuvacka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Најекономичен:";
            // 
            // txtNajekonomicen
            // 
            this.txtNajekonomicen.Location = new System.Drawing.Point(9, 412);
            this.txtNajekonomicen.Name = "txtNajekonomicen";
            this.txtNajekonomicen.ReadOnly = true;
            this.txtNajekonomicen.Size = new System.Drawing.Size(368, 22);
            this.txtNajekonomicen.TabIndex = 10;
            // 
            // txtNajskap
            // 
            this.txtNajskap.Location = new System.Drawing.Point(9, 458);
            this.txtNajskap.Name = "txtNajskap";
            this.txtNajskap.ReadOnly = true;
            this.txtNajskap.Size = new System.Drawing.Size(368, 22);
            this.txtNajskap.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Најскап:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDodadiAvtomobil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 507);
            this.Controls.Add(this.txtProsecnaPotrosuvacka);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupPotrosuvacka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCena)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrisiAvtomobil;
        private System.Windows.Forms.Button btnDodadiAvtomobil;
        private System.Windows.Forms.NumericUpDown nupCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupPotrosuvacka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMarki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodadiMarka;
        private System.Windows.Forms.ListBox lstMarki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNajskap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNajekonomicen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstAvtomobili;
        private System.Windows.Forms.TextBox txtProsecnaPotrosuvacka;
    }
}

