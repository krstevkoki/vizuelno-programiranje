namespace F1Race
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
            this.lstVozaci = new System.Windows.Forms.ListBox();
            this.btnDodadiVozac = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKrugovi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMinuti = new System.Windows.Forms.NumericUpDown();
            this.nudSekundi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadiKrug = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNajdobar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudVreme = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekundi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisi);
            this.groupBox1.Controls.Add(this.btnDodadiVozac);
            this.groupBox1.Controls.Add(this.lstVozaci);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возачи";
            // 
            // lstVozaci
            // 
            this.lstVozaci.FormattingEnabled = true;
            this.lstVozaci.ItemHeight = 16;
            this.lstVozaci.Location = new System.Drawing.Point(7, 22);
            this.lstVozaci.Name = "lstVozaci";
            this.lstVozaci.Size = new System.Drawing.Size(316, 436);
            this.lstVozaci.TabIndex = 0;
            this.lstVozaci.SelectedIndexChanged += new System.EventHandler(this.lstVozaci_SelectedIndexChanged);
            // 
            // btnDodadiVozac
            // 
            this.btnDodadiVozac.Location = new System.Drawing.Point(6, 481);
            this.btnDodadiVozac.Name = "btnDodadiVozac";
            this.btnDodadiVozac.Size = new System.Drawing.Size(316, 31);
            this.btnDodadiVozac.TabIndex = 1;
            this.btnDodadiVozac.Text = "Додади возач";
            this.btnDodadiVozac.UseVisualStyleBackColor = true;
            this.btnDodadiVozac.Click += new System.EventHandler(this.btnDodadiVozac_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(6, 518);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(316, 31);
            this.btnIzbrisi.TabIndex = 2;
            this.btnIzbrisi.Text = "Избриши возач";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudVreme);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNajdobar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDodadiKrug);
            this.groupBox2.Controls.Add(this.nudSekundi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudMinuti);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lstKrugovi);
            this.groupBox2.Location = new System.Drawing.Point(349, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 555);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кругови";
            // 
            // lstKrugovi
            // 
            this.lstKrugovi.FormattingEnabled = true;
            this.lstKrugovi.ItemHeight = 16;
            this.lstKrugovi.Location = new System.Drawing.Point(6, 21);
            this.lstKrugovi.Name = "lstKrugovi";
            this.lstKrugovi.Size = new System.Drawing.Size(330, 340);
            this.lstKrugovi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Минути";
            // 
            // nudMinuti
            // 
            this.nudMinuti.Location = new System.Drawing.Point(7, 389);
            this.nudMinuti.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMinuti.Name = "nudMinuti";
            this.nudMinuti.Size = new System.Drawing.Size(88, 22);
            this.nudMinuti.TabIndex = 5;
            // 
            // nudSekundi
            // 
            this.nudSekundi.Location = new System.Drawing.Point(101, 389);
            this.nudSekundi.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSekundi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSekundi.Name = "nudSekundi";
            this.nudSekundi.Size = new System.Drawing.Size(88, 22);
            this.nudSekundi.TabIndex = 7;
            this.nudSekundi.ValueChanged += new System.EventHandler(this.nudSekundi_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Секунди";
            // 
            // btnDodadiKrug
            // 
            this.btnDodadiKrug.Location = new System.Drawing.Point(195, 389);
            this.btnDodadiKrug.Name = "btnDodadiKrug";
            this.btnDodadiKrug.Size = new System.Drawing.Size(141, 34);
            this.btnDodadiKrug.TabIndex = 8;
            this.btnDodadiKrug.Text = "Додади круг";
            this.btnDodadiKrug.UseVisualStyleBackColor = true;
            this.btnDodadiKrug.Click += new System.EventHandler(this.btnDodadiKrug_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Најдобар круг";
            // 
            // txtNajdobar
            // 
            this.txtNajdobar.Location = new System.Drawing.Point(6, 458);
            this.txtNajdobar.Name = "txtNajdobar";
            this.txtNajdobar.ReadOnly = true;
            this.txtNajdobar.Size = new System.Drawing.Size(326, 22);
            this.txtNajdobar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Време";
            // 
            // nudVreme
            // 
            this.nudVreme.Location = new System.Drawing.Point(7, 503);
            this.nudVreme.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudVreme.Name = "nudVreme";
            this.nudVreme.Size = new System.Drawing.Size(88, 22);
            this.nudVreme.TabIndex = 12;
            this.nudVreme.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudVreme.ValueChanged += new System.EventHandler(this.nudVreme_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ф1 Трка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekundi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodadiVozac;
        private System.Windows.Forms.ListBox lstVozaci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudVreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNajdobar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodadiKrug;
        private System.Windows.Forms.NumericUpDown nudSekundi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinuti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstKrugovi;
    }
}

