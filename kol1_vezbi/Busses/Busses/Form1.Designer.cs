namespace Busses
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
            this.lstAvtobusi = new System.Windows.Forms.ListBox();
            this.lstLinii = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadiAvtobus = new System.Windows.Forms.Button();
            this.btnIzbrisiAvtobus = new System.Windows.Forms.Button();
            this.btnDodadiLinija = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNajskapa = new System.Windows.Forms.TextBox();
            this.txtProsecnaCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автобуси";
            // 
            // lstAvtobusi
            // 
            this.lstAvtobusi.FormattingEnabled = true;
            this.lstAvtobusi.ItemHeight = 16;
            this.lstAvtobusi.Location = new System.Drawing.Point(13, 34);
            this.lstAvtobusi.Name = "lstAvtobusi";
            this.lstAvtobusi.Size = new System.Drawing.Size(289, 244);
            this.lstAvtobusi.TabIndex = 1;
            this.lstAvtobusi.SelectedIndexChanged += new System.EventHandler(this.lstAvtobusi_SelectedIndexChanged);
            // 
            // lstLinii
            // 
            this.lstLinii.FormattingEnabled = true;
            this.lstLinii.ItemHeight = 16;
            this.lstLinii.Location = new System.Drawing.Point(308, 34);
            this.lstLinii.Name = "lstLinii";
            this.lstLinii.Size = new System.Drawing.Size(342, 244);
            this.lstLinii.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Линии";
            // 
            // btnDodadiAvtobus
            // 
            this.btnDodadiAvtobus.Location = new System.Drawing.Point(13, 300);
            this.btnDodadiAvtobus.Name = "btnDodadiAvtobus";
            this.btnDodadiAvtobus.Size = new System.Drawing.Size(289, 23);
            this.btnDodadiAvtobus.TabIndex = 4;
            this.btnDodadiAvtobus.Text = "Додади автобус";
            this.btnDodadiAvtobus.UseVisualStyleBackColor = true;
            this.btnDodadiAvtobus.Click += new System.EventHandler(this.btnDodadiAvtobus_Click);
            // 
            // btnIzbrisiAvtobus
            // 
            this.btnIzbrisiAvtobus.Location = new System.Drawing.Point(13, 343);
            this.btnIzbrisiAvtobus.Name = "btnIzbrisiAvtobus";
            this.btnIzbrisiAvtobus.Size = new System.Drawing.Size(289, 23);
            this.btnIzbrisiAvtobus.TabIndex = 5;
            this.btnIzbrisiAvtobus.Text = "Избриши автобус";
            this.btnIzbrisiAvtobus.UseVisualStyleBackColor = true;
            this.btnIzbrisiAvtobus.Click += new System.EventHandler(this.btnIzbrisiAvtobus_Click);
            // 
            // btnDodadiLinija
            // 
            this.btnDodadiLinija.Location = new System.Drawing.Point(13, 386);
            this.btnDodadiLinija.Name = "btnDodadiLinija";
            this.btnDodadiLinija.Size = new System.Drawing.Size(289, 23);
            this.btnDodadiLinija.TabIndex = 6;
            this.btnDodadiLinija.Text = "Додади линија";
            this.btnDodadiLinija.UseVisualStyleBackColor = true;
            this.btnDodadiLinija.Click += new System.EventHandler(this.btnDodadiLinija_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProsecnaCena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNajskapa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(311, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Линии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Најскапа линија";
            // 
            // txtNajskapa
            // 
            this.txtNajskapa.Location = new System.Drawing.Point(7, 43);
            this.txtNajskapa.Name = "txtNajskapa";
            this.txtNajskapa.ReadOnly = true;
            this.txtNajskapa.Size = new System.Drawing.Size(326, 22);
            this.txtNajskapa.TabIndex = 9;
            // 
            // txtProsecnaCena
            // 
            this.txtProsecnaCena.Location = new System.Drawing.Point(7, 89);
            this.txtProsecnaCena.Name = "txtProsecnaCena";
            this.txtProsecnaCena.ReadOnly = true;
            this.txtProsecnaCena.Size = new System.Drawing.Size(326, 22);
            this.txtProsecnaCena.TabIndex = 11;
            this.txtProsecnaCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Просечна цена на линиите";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDodadiAvtobus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodadiLinija);
            this.Controls.Add(this.btnIzbrisiAvtobus);
            this.Controls.Add(this.btnDodadiAvtobus);
            this.Controls.Add(this.lstLinii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAvtobusi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Автобуси";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAvtobusi;
        private System.Windows.Forms.ListBox lstLinii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodadiAvtobus;
        private System.Windows.Forms.Button btnIzbrisiAvtobus;
        private System.Windows.Forms.Button btnDodadiLinija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProsecnaCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNajskapa;
        private System.Windows.Forms.Label label3;
    }
}

