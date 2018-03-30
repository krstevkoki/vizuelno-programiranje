namespace NarackaNaPica
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
            this.txtCenaGolema = new System.Windows.Forms.TextBox();
            this.txtCenaSredna = new System.Windows.Forms.TextBox();
            this.txtCenaMala = new System.Windows.Forms.TextBox();
            this.rbGolema = new System.Windows.Forms.RadioButton();
            this.rbSredna = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCenaKecap = new System.Windows.Forms.TextBox();
            this.txtCenaSirenje = new System.Windows.Forms.TextBox();
            this.txtCenaFeferonki = new System.Windows.Forms.TextBox();
            this.chbKecap = new System.Windows.Forms.CheckBox();
            this.chbSirenje = new System.Windows.Forms.CheckBox();
            this.chbFeferonki = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVkupnoPivo = new System.Windows.Forms.TextBox();
            this.txtVkupnoGusti = new System.Windows.Forms.TextBox();
            this.txtVkupnoGaziran = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCenaPivo = new System.Windows.Forms.TextBox();
            this.txtCenaGusti = new System.Windows.Forms.TextBox();
            this.txtCenaGaziran = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKolicinaPivo = new System.Windows.Forms.TextBox();
            this.txtKolicinaGusti = new System.Windows.Forms.TextBox();
            this.txtKolicinaGaziran = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCenaDesert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstDeserti = new System.Windows.Forms.ListBox();
            this.btnNaracaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVkupno = new System.Windows.Forms.TextBox();
            this.txtNaplata = new System.Windows.Forms.TextBox();
            this.txtKusur = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCenaGolema);
            this.groupBox1.Controls.Add(this.txtCenaSredna);
            this.groupBox1.Controls.Add(this.txtCenaMala);
            this.groupBox1.Controls.Add(this.rbGolema);
            this.groupBox1.Controls.Add(this.rbSredna);
            this.groupBox1.Controls.Add(this.rbMala);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // txtCenaGolema
            // 
            this.txtCenaGolema.Location = new System.Drawing.Point(207, 108);
            this.txtCenaGolema.Name = "txtCenaGolema";
            this.txtCenaGolema.Size = new System.Drawing.Size(100, 22);
            this.txtCenaGolema.TabIndex = 5;
            this.txtCenaGolema.Text = "500";
            this.txtCenaGolema.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // txtCenaSredna
            // 
            this.txtCenaSredna.Location = new System.Drawing.Point(207, 65);
            this.txtCenaSredna.Name = "txtCenaSredna";
            this.txtCenaSredna.Size = new System.Drawing.Size(100, 22);
            this.txtCenaSredna.TabIndex = 4;
            this.txtCenaSredna.Text = "300";
            this.txtCenaSredna.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // txtCenaMala
            // 
            this.txtCenaMala.Location = new System.Drawing.Point(207, 22);
            this.txtCenaMala.Name = "txtCenaMala";
            this.txtCenaMala.Size = new System.Drawing.Size(100, 22);
            this.txtCenaMala.TabIndex = 3;
            this.txtCenaMala.Text = "200";
            this.txtCenaMala.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // rbGolema
            // 
            this.rbGolema.AutoSize = true;
            this.rbGolema.Location = new System.Drawing.Point(7, 108);
            this.rbGolema.Name = "rbGolema";
            this.rbGolema.Size = new System.Drawing.Size(78, 21);
            this.rbGolema.TabIndex = 2;
            this.rbGolema.Text = "Голема";
            this.rbGolema.UseVisualStyleBackColor = true;
            this.rbGolema.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // rbSredna
            // 
            this.rbSredna.AutoSize = true;
            this.rbSredna.Location = new System.Drawing.Point(7, 65);
            this.rbSredna.Name = "rbSredna";
            this.rbSredna.Size = new System.Drawing.Size(78, 21);
            this.rbSredna.TabIndex = 1;
            this.rbSredna.Text = "Средна";
            this.rbSredna.UseVisualStyleBackColor = true;
            this.rbSredna.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Checked = true;
            this.rbMala.Location = new System.Drawing.Point(7, 22);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(64, 21);
            this.rbMala.TabIndex = 0;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Мала";
            this.rbMala.UseVisualStyleBackColor = true;
            this.rbMala.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCenaKecap);
            this.groupBox2.Controls.Add(this.txtCenaSirenje);
            this.groupBox2.Controls.Add(this.txtCenaFeferonki);
            this.groupBox2.Controls.Add(this.chbKecap);
            this.groupBox2.Controls.Add(this.chbSirenje);
            this.groupBox2.Controls.Add(this.chbFeferonki);
            this.groupBox2.Location = new System.Drawing.Point(351, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатоци";
            // 
            // txtCenaKecap
            // 
            this.txtCenaKecap.Location = new System.Drawing.Point(217, 108);
            this.txtCenaKecap.Name = "txtCenaKecap";
            this.txtCenaKecap.Size = new System.Drawing.Size(100, 22);
            this.txtCenaKecap.TabIndex = 8;
            this.txtCenaKecap.Text = "20";
            this.txtCenaKecap.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // txtCenaSirenje
            // 
            this.txtCenaSirenje.Location = new System.Drawing.Point(217, 63);
            this.txtCenaSirenje.Name = "txtCenaSirenje";
            this.txtCenaSirenje.Size = new System.Drawing.Size(100, 22);
            this.txtCenaSirenje.TabIndex = 7;
            this.txtCenaSirenje.Text = "30";
            this.txtCenaSirenje.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // txtCenaFeferonki
            // 
            this.txtCenaFeferonki.Location = new System.Drawing.Point(217, 22);
            this.txtCenaFeferonki.Name = "txtCenaFeferonki";
            this.txtCenaFeferonki.Size = new System.Drawing.Size(100, 22);
            this.txtCenaFeferonki.TabIndex = 6;
            this.txtCenaFeferonki.Text = "40";
            this.txtCenaFeferonki.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // chbKecap
            // 
            this.chbKecap.AutoSize = true;
            this.chbKecap.Location = new System.Drawing.Point(6, 108);
            this.chbKecap.Name = "chbKecap";
            this.chbKecap.Size = new System.Drawing.Size(71, 21);
            this.chbKecap.TabIndex = 2;
            this.chbKecap.Text = "Кечап";
            this.chbKecap.UseVisualStyleBackColor = true;
            this.chbKecap.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // chbSirenje
            // 
            this.chbSirenje.AutoSize = true;
            this.chbSirenje.Location = new System.Drawing.Point(7, 65);
            this.chbSirenje.Name = "chbSirenje";
            this.chbSirenje.Size = new System.Drawing.Size(131, 21);
            this.chbSirenje.TabIndex = 1;
            this.chbSirenje.Text = "Екстра сирење";
            this.chbSirenje.UseVisualStyleBackColor = true;
            this.chbSirenje.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // chbFeferonki
            // 
            this.chbFeferonki.AutoSize = true;
            this.chbFeferonki.Location = new System.Drawing.Point(6, 22);
            this.chbFeferonki.Name = "chbFeferonki";
            this.chbFeferonki.Size = new System.Drawing.Size(109, 21);
            this.chbFeferonki.TabIndex = 0;
            this.chbFeferonki.Text = "Феферонки";
            this.chbFeferonki.UseVisualStyleBackColor = true;
            this.chbFeferonki.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVkupnoPivo);
            this.groupBox3.Controls.Add(this.txtVkupnoGusti);
            this.groupBox3.Controls.Add(this.txtVkupnoGaziran);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCenaPivo);
            this.groupBox3.Controls.Add(this.txtCenaGusti);
            this.groupBox3.Controls.Add(this.txtCenaGaziran);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtKolicinaPivo);
            this.groupBox3.Controls.Add(this.txtKolicinaGusti);
            this.groupBox3.Controls.Add(this.txtKolicinaGaziran);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 169);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пијалок";
            // 
            // txtVkupnoPivo
            // 
            this.txtVkupnoPivo.Location = new System.Drawing.Point(543, 139);
            this.txtVkupnoPivo.Name = "txtVkupnoPivo";
            this.txtVkupnoPivo.ReadOnly = true;
            this.txtVkupnoPivo.Size = new System.Drawing.Size(100, 22);
            this.txtVkupnoPivo.TabIndex = 16;
            // 
            // txtVkupnoGusti
            // 
            this.txtVkupnoGusti.Location = new System.Drawing.Point(543, 92);
            this.txtVkupnoGusti.Name = "txtVkupnoGusti";
            this.txtVkupnoGusti.ReadOnly = true;
            this.txtVkupnoGusti.Size = new System.Drawing.Size(100, 22);
            this.txtVkupnoGusti.TabIndex = 15;
            // 
            // txtVkupnoGaziran
            // 
            this.txtVkupnoGaziran.Location = new System.Drawing.Point(543, 41);
            this.txtVkupnoGaziran.Name = "txtVkupnoGaziran";
            this.txtVkupnoGaziran.ReadOnly = true;
            this.txtVkupnoGaziran.Size = new System.Drawing.Size(100, 22);
            this.txtVkupnoGaziran.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Вкупно";
            // 
            // txtCenaPivo
            // 
            this.txtCenaPivo.Location = new System.Drawing.Point(403, 139);
            this.txtCenaPivo.Name = "txtCenaPivo";
            this.txtCenaPivo.Size = new System.Drawing.Size(100, 22);
            this.txtCenaPivo.TabIndex = 12;
            this.txtCenaPivo.Text = "80";
            this.txtCenaPivo.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // txtCenaGusti
            // 
            this.txtCenaGusti.Location = new System.Drawing.Point(403, 92);
            this.txtCenaGusti.Name = "txtCenaGusti";
            this.txtCenaGusti.Size = new System.Drawing.Size(100, 22);
            this.txtCenaGusti.TabIndex = 11;
            this.txtCenaGusti.Text = "70";
            this.txtCenaGusti.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // txtCenaGaziran
            // 
            this.txtCenaGaziran.Location = new System.Drawing.Point(403, 41);
            this.txtCenaGaziran.Name = "txtCenaGaziran";
            this.txtCenaGaziran.Size = new System.Drawing.Size(100, 22);
            this.txtCenaGaziran.TabIndex = 10;
            this.txtCenaGaziran.Text = "60";
            this.txtCenaGaziran.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Цена";
            // 
            // txtKolicinaPivo
            // 
            this.txtKolicinaPivo.Location = new System.Drawing.Point(260, 139);
            this.txtKolicinaPivo.Name = "txtKolicinaPivo";
            this.txtKolicinaPivo.Size = new System.Drawing.Size(100, 22);
            this.txtKolicinaPivo.TabIndex = 8;
            this.txtKolicinaPivo.Text = "0";
            this.txtKolicinaPivo.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // txtKolicinaGusti
            // 
            this.txtKolicinaGusti.Location = new System.Drawing.Point(260, 92);
            this.txtKolicinaGusti.Name = "txtKolicinaGusti";
            this.txtKolicinaGusti.Size = new System.Drawing.Size(100, 22);
            this.txtKolicinaGusti.TabIndex = 7;
            this.txtKolicinaGusti.Text = "0";
            this.txtKolicinaGusti.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // txtKolicinaGaziran
            // 
            this.txtKolicinaGaziran.Location = new System.Drawing.Point(260, 41);
            this.txtKolicinaGaziran.Name = "txtKolicinaGaziran";
            this.txtKolicinaGaziran.Size = new System.Drawing.Size(100, 22);
            this.txtKolicinaGaziran.TabIndex = 6;
            this.txtKolicinaGaziran.Text = "0";
            this.txtKolicinaGaziran.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко / портокал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока кола / Фанта / Спрајт";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOtkazi);
            this.groupBox4.Controls.Add(this.btnNaracaj);
            this.groupBox4.Controls.Add(this.txtCenaDesert);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lstDeserti);
            this.groupBox4.Location = new System.Drawing.Point(13, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 166);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Десерт";
            // 
            // txtCenaDesert
            // 
            this.txtCenaDesert.Location = new System.Drawing.Point(177, 48);
            this.txtCenaDesert.Name = "txtCenaDesert";
            this.txtCenaDesert.Size = new System.Drawing.Size(183, 22);
            this.txtCenaDesert.TabIndex = 18;
            this.txtCenaDesert.TextChanged += new System.EventHandler(this.txtCenaMala_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Цена на десерт:";
            // 
            // lstDeserti
            // 
            this.lstDeserti.FormattingEnabled = true;
            this.lstDeserti.ItemHeight = 16;
            this.lstDeserti.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lstDeserti.Location = new System.Drawing.Point(7, 22);
            this.lstDeserti.Name = "lstDeserti";
            this.lstDeserti.Size = new System.Drawing.Size(152, 132);
            this.lstDeserti.TabIndex = 0;
            this.lstDeserti.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNaracaj
            // 
            this.btnNaracaj.Location = new System.Drawing.Point(177, 88);
            this.btnNaracaj.Name = "btnNaracaj";
            this.btnNaracaj.Size = new System.Drawing.Size(183, 23);
            this.btnNaracaj.TabIndex = 19;
            this.btnNaracaj.Text = "Нарачај";
            this.btnNaracaj.UseVisualStyleBackColor = true;
            this.btnNaracaj.Click += new System.EventHandler(this.btnNaracaj_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(177, 131);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(183, 23);
            this.btnOtkazi.TabIndex = 20;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtKusur);
            this.groupBox5.Controls.Add(this.txtNaplata);
            this.groupBox5.Controls.Add(this.txtVkupno);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(392, 342);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 166);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Наплата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Вкупно за плаќање:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Наплатено:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "За враќање:";
            // 
            // txtVkupno
            // 
            this.txtVkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVkupno.Location = new System.Drawing.Point(153, 22);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.ReadOnly = true;
            this.txtVkupno.Size = new System.Drawing.Size(123, 26);
            this.txtVkupno.TabIndex = 17;
            // 
            // txtNaplata
            // 
            this.txtNaplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNaplata.Location = new System.Drawing.Point(153, 73);
            this.txtNaplata.Name = "txtNaplata";
            this.txtNaplata.Size = new System.Drawing.Size(123, 26);
            this.txtNaplata.TabIndex = 17;
            this.txtNaplata.Text = "0";
            // 
            // txtKusur
            // 
            this.txtKusur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtKusur.Location = new System.Drawing.Point(153, 128);
            this.txtKusur.Name = "txtKusur";
            this.txtKusur.Size = new System.Drawing.Size(123, 26);
            this.txtKusur.TabIndex = 24;
            this.txtKusur.Text = "0";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNaracaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(686, 515);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Нарачка на пица";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCenaGolema;
        private System.Windows.Forms.TextBox txtCenaSredna;
        private System.Windows.Forms.TextBox txtCenaMala;
        private System.Windows.Forms.RadioButton rbGolema;
        private System.Windows.Forms.RadioButton rbSredna;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCenaKecap;
        private System.Windows.Forms.TextBox txtCenaSirenje;
        private System.Windows.Forms.TextBox txtCenaFeferonki;
        private System.Windows.Forms.CheckBox chbKecap;
        private System.Windows.Forms.CheckBox chbSirenje;
        private System.Windows.Forms.CheckBox chbFeferonki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtVkupnoPivo;
        private System.Windows.Forms.TextBox txtVkupnoGusti;
        private System.Windows.Forms.TextBox txtVkupnoGaziran;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCenaPivo;
        private System.Windows.Forms.TextBox txtCenaGusti;
        private System.Windows.Forms.TextBox txtCenaGaziran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKolicinaPivo;
        private System.Windows.Forms.TextBox txtKolicinaGusti;
        private System.Windows.Forms.TextBox txtKolicinaGaziran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCenaDesert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstDeserti;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnNaracaj;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtKusur;
        private System.Windows.Forms.TextBox txtNaplata;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

